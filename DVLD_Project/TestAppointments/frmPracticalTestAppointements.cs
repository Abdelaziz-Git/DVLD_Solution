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
    public partial class frmPracticalTestAppointements: Form
    {
        // Constructor
        public frmPracticalTestAppointements(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);

        }


        // Properties
        clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication = null;


        // Methods
        private void Load_dgvPracticalTestAppointementsRecords()
        {
            dgvPracticalTestAppointments.Rows.Clear();
            foreach (clsTestAppointments PracticalTestAppointment in clsTestAppointments.GetTestAppointmentsByLDLA_and_TestTypeID(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.PracticalTest))
            {
                dgvPracticalTestAppointments.Rows.Add(PracticalTestAppointment.TestAppointmentID, PracticalTestAppointment.AppointmentDate.ToString("dd/MM/yyyy"), PracticalTestAppointment.PaidFees.ToString("0.00"), PracticalTestAppointment.IsLocked);
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
            Load_dgvPracticalTestAppointementsRecords();
        }
        private void AddPracticalTestAppointment()
        {
            clsTestAppointments _LastPracticalTestAppointmnet = clsTestAppointments.
                   GetTestAppointmentsByLDLA_and_TestTypeID
                   (_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.PracticalTest).
                   LastOrDefault();

            if (_LastPracticalTestAppointmnet == null)
            {
                using (frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.PracticalTest))
                {
                    frm.ShowDialog();
                    Load_dgvPracticalTestAppointementsRecords();
                }
                return;
            }
            else if (_LastPracticalTestAppointmnet.IsLocked)
            {
                if (clsTests.FindByAppointmentID(_LastPracticalTestAppointmnet.TestAppointmentID).TestResult)
                {
                    MessageBox.Show("You already have a locked Practical test appointment with a passed result.");
                    return;
                }
                else
                {
                    if (MessageBox.Show("You already have a locked Practical test appointment with a failed result. Do you want to retake an other Practical test?",
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
                                (int)clsUtil.enTestTypes.PracticalTest, RetakeTestApplicationID))
                            {
                                frm.ShowDialog();
                                Load_dgvPracticalTestAppointementsRecords();
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("You already have an open Practical test appointment.");
                return;
            }

        }
        private bool Is_dgvPracticalTestAppointementsValidate()
        {
            if (dgvPracticalTestAppointments.Rows.Count == 0)
            {
                MessageBox.Show("No Practical test appointments found.");
                return false;
            }
            if (dgvPracticalTestAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Practical test appointment.");
                return false;
            }
            return true;
        }
        private void EditAppointment()
        {
            if (!Is_dgvPracticalTestAppointementsValidate())
                return;
            bool IsLocked = (bool)dgvPracticalTestAppointments.SelectedRows[0].Cells[3].Value;
            if (IsLocked)
            {
                MessageBox.Show("This appointment is locked. You cannot edit it.");
                return;
            }

            int TestAppointmentID = (int)dgvPracticalTestAppointments.SelectedRows[0].Cells[0].Value;
            using (frmScheduleTest frm = new frmScheduleTest(TestAppointmentID))
            {
                frm.ShowDialog();
                Load_dgvPracticalTestAppointementsRecords();
            }
        }
        private void TakeTest()
        {
            if (!Is_dgvPracticalTestAppointementsValidate())
                return;
            int TestAppointmentID = (int)dgvPracticalTestAppointments.SelectedRows[0].Cells[0].Value;
            DateTime AppointmentDate = DateTime.ParseExact(
                dgvPracticalTestAppointments.SelectedRows[0].Cells[1].Value.ToString(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );
            bool IsLocked = (bool)dgvPracticalTestAppointments.SelectedRows[0].Cells[3].Value;

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
                Load_dgvPracticalTestAppointementsRecords();
            }
        }

        // Events
        private void BtnAddPracticalTestAppointment_Click(object sender, EventArgs e)
        {
            AddPracticalTestAppointment();
        }
        private void frmPracticalTestAppointements_Shown(object sender, EventArgs e)
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
