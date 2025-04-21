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
    public partial class frmVisionTestAppointements : Form
    {
        // Properties
        clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication = null;
        


        // Constructor
        public frmVisionTestAppointements(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);
            

        }


        // Methods
        private void Load_dgvVisionTestAppointementsRecords()
        {
            dgvVisionTestAppointments.Rows.Clear();
            foreach (clsTestAppointments VisionTestAppointment in clsTestAppointments.GetTestAppointmentsByLDLA_and_TestTypeID(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.VisionTest))
            {
                dgvVisionTestAppointments.Rows.Add(VisionTestAppointment.TestAppointmentID, VisionTestAppointment.AppointmentDate.ToString("dd/MM/yyyy"), VisionTestAppointment.PaidFees.ToString("0.00"), VisionTestAppointment.IsLocked);
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
            Load_dgvVisionTestAppointementsRecords();
        }
        private  void AddVisionTestAppointment()
        {
            clsTestAppointments _LastVisionTestAppointmnet = clsTestAppointments.
                   GetTestAppointmentsByLDLA_and_TestTypeID
                   (_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.VisionTest).
                   LastOrDefault();

            if (_LastVisionTestAppointmnet == null)
            {
                using (frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, (int)clsUtil.enTestTypes.VisionTest))
                {
                    frm.ShowDialog();
                    Load_dgvVisionTestAppointementsRecords();
                }
                return;
            }
            else if (_LastVisionTestAppointmnet.IsLocked)
            {
                if (clsTests.FindByAppointmentID(_LastVisionTestAppointmnet.TestAppointmentID).TestResult)
                {
                    MessageBox.Show("You already have a locked vision test appointment with a passed result.");
                    return;
                }
                else
                {
                    if (MessageBox.Show("You already have a locked vision test appointment with a failed result. Do you want to retake an other vision test?",
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
                            using(frmScheduleTest frm = new frmScheduleTest
                                (_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID,
                                (int)clsUtil.enTestTypes.VisionTest,RetakeTestApplicationID))
                            {
                                frm.ShowDialog();
                                Load_dgvVisionTestAppointementsRecords();
                            }
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("You already have an open vision test appointment.");
                return;
            }

        } 
        private bool Is_dgvVisionTestAppointementsValidate()
        {
            if (dgvVisionTestAppointments.Rows.Count == 0)
            {
                MessageBox.Show("No vision test appointments found.");
                return false;
            }
            if (dgvVisionTestAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vision test appointment.");
                return false;
            }
            return true;
        }
        private void EditAppointment()
        {
            if (!Is_dgvVisionTestAppointementsValidate())
                return;
            bool IsLocked = (bool)dgvVisionTestAppointments.SelectedRows[0].Cells[3].Value;
            if (IsLocked)
            {
                MessageBox.Show("This appointment is locked. You cannot edit it.");
                return;
            }

            int TestAppointmentID = (int)dgvVisionTestAppointments.SelectedRows[0].Cells[0].Value;
            using (frmScheduleTest frm = new frmScheduleTest(TestAppointmentID))
            {
                frm.ShowDialog();
                Load_dgvVisionTestAppointementsRecords();
            }
        }
        private void TakeTest()
        {
            if (!Is_dgvVisionTestAppointementsValidate())
                return;
            int TestAppointmentID = (int)dgvVisionTestAppointments.SelectedRows[0].Cells[0].Value;
            DateTime AppointmentDate = DateTime.ParseExact(
                dgvVisionTestAppointments.SelectedRows[0].Cells[1].Value.ToString(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );
            bool IsLocked = (bool)dgvVisionTestAppointments.SelectedRows[0].Cells[3].Value;

            if (IsLocked)
            {
                MessageBox.Show("This appointment is locked. You cannot take the test.");
                return;
            }
            if(AppointmentDate > DateTime.Now)
            {
                MessageBox.Show($"This appointment is in the future. You cannot take the test before {AppointmentDate.ToString("d")}.");
                return;
            }

            using (frmTakeTest frm = new frmTakeTest(TestAppointmentID))
            {
                frm.ShowDialog();
                Load_dgvVisionTestAppointementsRecords();
            }
        }

        // Events
        private void BtnAddVisionTestAppointment_Click(object sender, EventArgs e)
        {
            AddVisionTestAppointment();
        }
        private  void frmVisionTestAppointements_Shown(object sender, EventArgs e)
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
