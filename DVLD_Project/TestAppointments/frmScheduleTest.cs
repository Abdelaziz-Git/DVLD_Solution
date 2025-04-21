using DVLD_Business1;
using DVLD_Project.GlobalClasses;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Tests
{
    public partial class frmScheduleTest: Form
    {
        // Enums
        public enum enMode { AddNew, Update,RetakeTest }
        // Properties
        clsTestAppointments _TestAppointment = null;
        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication = null;
        private clsTestTypes _TestType = null;
        private clsApplications _RetakTestApplication = null;
        private enMode _Mode = enMode.AddNew;

        // Constructors

        /// This constructor is used to schedule a new test appointment
        public frmScheduleTest(int LocalDrivingLicenseAppID, byte TestTypeID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseAppID);
            _TestType = clsTestTypes.Find(TestTypeID);
            _TestAppointment = new clsTestAppointments();
            _Mode = enMode.AddNew;
        }
        /// This constructor is used to update an existing test appointment
        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointment = clsTestAppointments.Find(TestAppointmentID);
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(_TestAppointment.LocalDrivingLicenseApplicationID);
            _TestType = clsTestTypes.Find(_TestAppointment.TestTypeID);
            if (_TestAppointment.RetakeTestApplicationID == null)
            {
                _RetakTestApplication = null;
            }
            else
                _RetakTestApplication = clsApplications.Find((int)_TestAppointment.RetakeTestApplicationID);
            _Mode = enMode.Update;
        }
        /// This constructor is used to schedule a retake test appointment
        public frmScheduleTest(int LocalDrivingLicenseAppID,byte TestTypeID, int RetakeTestAppID )
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseAppID);
            _TestType = clsTestTypes.Find(TestTypeID);
            _TestAppointment = new clsTestAppointments();
            _RetakTestApplication = clsApplications.Find(RetakeTestAppID);
            _Mode = enMode.RetakeTest;
        }

        // Methods
        private void OnVisionTest()
        {
            gbtest.Text = "Vision test:";
            pbTest.Image = Resources.vision_Test_256;
            lblTestTitle.Text = "Schedule vision test";
        }
        private void OnWrittenTest()
        {
            gbtest.Text = "Written test:";
            pbTest.Image = Resources.Written_test_128;
            lblTestTitle.Text = "Schedule written test";
        }
        private void OnPracticalTest()
        {
            gbtest.Text = "Practical test:";
            pbTest.Image = Resources.test_drive_128;
            lblTestTitle.Text = "Schedule practical test";
        }
        private void OnAddNewMode()
        {
            dpTestAppointment.Value = DateTime.Now;
            gpRetakTest.Enabled = false;
            lblTotalFees.Text = _TestType.Fees.ToString();
            dpTestAppointment.Focus();
        }
        private void OnUpdateMode()
        {
            dpTestAppointment.Value = _TestAppointment.AppointmentDate;
            if (_RetakTestApplication != null)
            {
                lblRetakTestAppID.Text = _RetakTestApplication.ApplicationID.ToString();
                decimal retakeTestFees = clsApplicationType.Find(_RetakTestApplication.ApplicationTypeID).Fees;
                lblRetakTestAppFees.Text = retakeTestFees.ToString();
                lblTotalFees.Text = (_TestType.Fees + retakeTestFees).ToString();
            }
            else
            {
                gpRetakTest.Enabled = false;
                lblTotalFees.Text = _TestType.Fees.ToString();
            }
            if (_TestAppointment.IsLocked)
            {
                dpTestAppointment.Enabled = false;
                btnSave.Enabled = false;
            }
            if (_RetakTestApplication != null)
            {
                lblRetakTestAppID.Text = _RetakTestApplication.ApplicationID.ToString();
                decimal retakeTestFees = clsApplicationType.Find(_RetakTestApplication.ApplicationTypeID).Fees;
                lblRetakTestAppFees.Text = retakeTestFees.ToString();
                lblTotalFees.Text = (_TestType.Fees + retakeTestFees).ToString();
            }
            else
            {
                gpRetakTest.Enabled = false;
                lblTotalFees.Text = _TestType.Fees.ToString();
            }
        }
        private void OnRetakeTestMode()
        {
            dpTestAppointment.Value = DateTime.Now;
            lblRetakTestAppID.Text = _RetakTestApplication.ApplicationID.ToString();
            decimal retakeTestFees = clsApplicationType.Find(_RetakTestApplication.ApplicationTypeID).Fees;
            lblRetakTestAppFees.Text = retakeTestFees.ToString();
            lblTotalFees.Text = (_TestType.Fees + retakeTestFees).ToString();
        }
        private void LoadData()
        {
            if (_TestType.Id == (int)clsUtil.enTestTypes.VisionTest)
            {
                OnVisionTest();
            }
            else if (_TestType.Id == (int)clsUtil.enTestTypes.WrittenTest)
            {
                OnWrittenTest();
            }
            else if (_TestType.Id == (int)clsUtil.enTestTypes.PracticalTest)
            {
                OnPracticalTest();
            }
            lbl_LDLA_ID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = clsLicenseClasses.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblTestFees.Text = _TestType.Fees.ToString();
            lblName.Text = clsPerson.Find(clsApplications.Find(_LocalDrivingLicenseApplication.ApplicationID).ApplicantPersonID).FullName;
            lblTrials.Text = clsTestAppointments.GetTrialCount(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _TestType.Id).ToString();
            if (_Mode == enMode.AddNew)
            {
                OnAddNewMode();
            }
            else if (_Mode == enMode.Update)
            {
                OnUpdateMode();
            }
            else if (_Mode == enMode.RetakeTest)
            {
                OnRetakeTestMode(); 
            }
            
        }
        private void SaveData()
        {
            if (_Mode == enMode.AddNew)
            {
                _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                _TestAppointment.IsLocked = false;
                _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.Id;
                _TestAppointment.TestTypeID = _TestType.Id;
                _TestAppointment.RetakeTestApplicationID = null;
                _TestAppointment.AppointmentDate = dpTestAppointment.Value;
                if(decimal.TryParse(lblTotalFees.Text, out decimal totalFees) == false)
                {
                    MessageBox.Show("Invalid total fees!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _TestAppointment.PaidFees = totalFees;

                if (_TestAppointment.Save())
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("Test appointment scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to schedule test appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_Mode == enMode.Update)
            {
                _TestAppointment.AppointmentDate = dpTestAppointment.Value;
                if (_TestAppointment.Save())
                {
                    MessageBox.Show("Test appointment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update test appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_Mode == enMode.RetakeTest)
            {
                _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
                _TestAppointment.IsLocked = false;
                _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.Id;
                _TestAppointment.TestTypeID = _TestType.Id;
                _TestAppointment.RetakeTestApplicationID = _RetakTestApplication.ApplicationID;
                _TestAppointment.AppointmentDate = dpTestAppointment.Value;
                if (decimal.TryParse(lblTotalFees.Text, out decimal totalFees) == false)
                {
                    MessageBox.Show("Invalid total fees!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _TestAppointment.PaidFees = totalFees;
                
                if (_TestAppointment.Save())
                {
                    _Mode = enMode.Update;
                    MessageBox.Show("Retake test appointment scheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to schedule retake test appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event Handlers
        private void dpTestAppointment_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dpTestAppointment.Value.ToString("dd/MM/yyyy");
        }

        private void frmScheduleTest_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
