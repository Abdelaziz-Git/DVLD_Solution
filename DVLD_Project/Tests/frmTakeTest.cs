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
    public partial class frmTakeTest: Form
    {
        // Enums
        enum enMode
        {
            TakeVisionTest,
            TakeWritingTest,
            TakePracticalTest
        }
        //Properties
        private enMode _Mode;
        clsTestAppointments _TestAppointment = null;

        // Constructor
        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();
            _TestAppointment=clsTestAppointments.Find(TestAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show("Test appointment not found.");
                this.Close();
                return;
            }
            if (_TestAppointment.TestTypeID == (int)clsUtil.enTestTypes.VisionTest)
                _Mode = enMode.TakeVisionTest;
            else if (_TestAppointment.TestTypeID == (int)clsUtil.enTestTypes.WrittenTest)
                _Mode = enMode.TakeWritingTest;
            else if (_TestAppointment.TestTypeID == (int)clsUtil.enTestTypes.PracticalTest)
                _Mode = enMode.TakePracticalTest;
            else
            {
                MessageBox.Show("Invalid test type.");
                this.Close();
                return;
            }
        }

        // Methods
        private void LoadFormData()
        {
            lbl_LDLA_ID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = clsLicenseClasses.Find
                (clsLocalDrivingLicenseApplications.Find
                (_TestAppointment.LocalDrivingLicenseApplicationID).LicenseClassID).ClassName;
            lblTestFees.Text = clsTestTypes.Find(_TestAppointment.TestTypeID).Fees.ToString("C2");
            lblName.Text = clsPerson.Find(clsApplications.Find(clsLocalDrivingLicenseApplications.Find(_TestAppointment.LocalDrivingLicenseApplicationID).ApplicationID).ApplicantPersonID).FullName;
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTrials.Text = clsTestAppointments.GetTrialCount(_TestAppointment.LocalDrivingLicenseApplicationID, _TestAppointment.TestTypeID).ToString();
            if (_Mode == enMode.TakeVisionTest)
            {
                this.Text = "Take Vision Test";
                gbtest.Text = "Vision Test";
                pbTest.Image = Resources.vision_Test_256;
                
            }
            else if (_Mode == enMode.TakeWritingTest)
            {
                this.Text = "Take Writing Test";
                gbtest.Text = "Written Test";
                pbTest.Image = Resources.Written_test_128;
            }
            else if (_Mode == enMode.TakePracticalTest)
            {
                this.Text = "Take Practical Test";
                gbtest.Text = "Practical Test";
                pbTest.Image = Resources.test_drive_128;
            }
        }
        private void SaveTestResult()
        {
            clsTests NewTest = new clsTests();
            NewTest.TestAppointmentID = _TestAppointment.TestAppointmentID;
            if (rbPass.Checked)
            {
                if (MessageBox.Show("Are you sure you want to pass this test?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                NewTest.TestResult = true;
            }
            else if (rbFail.Checked)
            {
                if (MessageBox.Show("Are you sure you want to fail this test?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                NewTest.TestResult = false;
            }
            else
            {
                MessageBox.Show("Please select a test result.");
                return;
            }
            NewTest.Notes = txtNotes.Text;
            NewTest.CreatedByUserID = clsGlobal.CurrentUser.Id;
            if (NewTest.Save())
            {
                _TestAppointment.IsLocked = true;
                if (!_TestAppointment.Save())
                {
                    clsTests.Delete(NewTest.TestID);
                    MessageBox.Show("Failed to lock test appointment. Please retake test.");
                    return;
                }
           
                lblTestID.Text = NewTest.TestID.ToString();
                MessageBox.Show("Test result saved successfully.");
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save test result.");
            }
        }

        // Events
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTestResult();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
