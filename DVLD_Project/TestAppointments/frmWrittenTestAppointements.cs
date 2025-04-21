using DVLD_Business1;
using DVLD_Project.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Tests
{
    public partial class frmWrittenTestAppointements: Form
    {
        // Constructor
        public frmWrittenTestAppointements(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);

        }


        // Properties
        clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication = null;


        // Methods
        private void Load_dgvWrittenTestAppointementsRecords()
        {
            dgvWrittenTestAppointments.Rows.Clear();
            foreach (clsTestAppointments WrittenTestAppointment in clsTestAppointments.GetTestAppointmentsByLDLA_and_TestTypeID(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.WrittenTest))
            {
                dgvWrittenTestAppointments.Rows.Add(WrittenTestAppointment.TestAppointmentID, WrittenTestAppointment.AppointmentDate.ToString("dd/MM/yyyy"), WrittenTestAppointment.PaidFees.ToString("0.00"), WrittenTestAppointment.IsLocked);
            }
        }
        private void LoadData()
        {
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No application found.");
                this.Close();
                return;
            }
            ucLocalDrivingLicenseApplicationCard1.LoadLocalDrivingLicenseApplicationInfo(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            Load_dgvWrittenTestAppointementsRecords();
        }
        private void AddWrittenTestAppointment()
        {
            clsTestAppointments _LastWrittenTestAppointmnet = clsTestAppointments.
                   GetTestAppointmentsByLDLA_and_TestTypeID
                   (_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.WrittenTest).
                   LastOrDefault();

            if (_LastWrittenTestAppointmnet == null)
            {
                using (frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.WrittenTest))
                {
                    frm.ShowDialog();
                    Load_dgvWrittenTestAppointementsRecords();
                }
                return;
            }
            else if (_LastWrittenTestAppointmnet.IsLocked)
            {
                if (clsTests.FindByAppointmentID(_LastWrittenTestAppointmnet.TestAppointmentID).TestResult)
                {
                    MessageBox.Show("You already have a locked Written test appointment with a passed result.");
                    return;
                }
                else
                {
                    if (MessageBox.Show("You already have a locked Written test appointment with a failed result. Do you want to retake an other Written test?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int RetakeTestApplicationID = clsTestAppointments.CreateRetakeTestApplication
                            (_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, clsGlobal.CurrentUser.Id);
                        if (RetakeTestApplicationID < 1)
                        {
                            MessageBox.Show("Failed to create a retake test application.");
                            return;
                        }
                        else
                        {
                            using (frmScheduleTest frm = new frmScheduleTest
                                (_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID,
                                (int)clsUtil.enTestTypes.WrittenTest, RetakeTestApplicationID))
                            {
                                frm.ShowDialog();
                                Load_dgvWrittenTestAppointementsRecords();
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("You already have an open Written test appointment.");
                return;
            }

        }
        private bool Is_dgvWrittenTestAppointementsValidate()
        {
            if (dgvWrittenTestAppointments.Rows.Count == 0)
            {
                MessageBox.Show("No Written test appointments found.");
                return false;
            }
            if (dgvWrittenTestAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Written test appointment.");
                return false;
            }
            return true;
        }
        private void EditAppointment()
        {
            if (!Is_dgvWrittenTestAppointementsValidate())
                return;
            bool IsLocked = (bool)dgvWrittenTestAppointments.SelectedRows[0].Cells[3].Value;
            if (IsLocked)
            {
                MessageBox.Show("This appointment is locked. You cannot edit it.");
                return;
            }

            int TestAppointmentID = (int)dgvWrittenTestAppointments.SelectedRows[0].Cells[0].Value;
            using (frmScheduleTest frm = new frmScheduleTest(TestAppointmentID))
            {
                frm.ShowDialog();
                Load_dgvWrittenTestAppointementsRecords();
            }
        }
        private void TakeTest()
        {
            if (!Is_dgvWrittenTestAppointementsValidate())
                return;
            int TestAppointmentID = (int)dgvWrittenTestAppointments.SelectedRows[0].Cells[0].Value;
            DateTime AppointmentDate = DateTime.ParseExact(
                dgvWrittenTestAppointments.SelectedRows[0].Cells[1].Value.ToString(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );
            bool IsLocked = (bool)dgvWrittenTestAppointments.SelectedRows[0].Cells[3].Value;

            if (IsLocked)
            {
                MessageBox.Show("This appointment is locked. You cannot take the test.");
                return;
            }
            if (AppointmentDate > DateTime.Now)
            {
                MessageBox.Show($"This appointment is in the future. You cannot take the test before {AppointmentDate.ToString("d")}.");
                return;
            }

            using (frmTakeTest frm = new frmTakeTest(TestAppointmentID))
            {
                frm.ShowDialog();
                Load_dgvWrittenTestAppointementsRecords();
            }
        }

        // Events
        private void BtnAddWrittenTestAppointment_Click(object sender, EventArgs e)
        {
            AddWrittenTestAppointment();
        }
        private void frmWrittenTestAppointements_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAppointment();
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeTest();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
