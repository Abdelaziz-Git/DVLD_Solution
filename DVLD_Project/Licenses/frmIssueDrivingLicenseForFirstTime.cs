using DVLD_Business1;
using DVLD_Project.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmIssueDrivingLicenseForFirstTime: Form
    {
        public frmIssueDrivingLicenseForFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);
            if( _localDrivingLicenseApplication == null )
            {
                MessageBox.Show("The application does not exist.","Not Found");
                this.Close();
            }
            _LicenseClasses = clsLicenseClasses.Find(_localDrivingLicenseApplication.LicenseClassID);

        }
        // Properties
        clsLicenses _license = new clsLicenses();
        private clsLocalDrivingLicenseApplications _localDrivingLicenseApplication = null;
        clsLicenseClasses _LicenseClasses = null;

        // Methods
        private void LoadData()
        {
            // Load the form with the application details
            ucLocalDrivingLicenseApplicationCard1.LoadLocalDrivingLicenseApplicationInfo(_localDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
            lblTotalFees.Text = _LicenseClasses.ClassFees.ToString() + "$";
        }
        private void IssueLicense()
        {
            // Check if the application has  license
            if(clsLicenses.IsLicenseExistsByApplicationID(_localDrivingLicenseApplication.ApplicationID))
            {
                MessageBox.Show("The application already has a license issued.", "License Exists");
                return;
            }
            // Check if the person exist in drivers table. If not, add new driver with the person ID
            clsApplications application = clsApplications.Find(_localDrivingLicenseApplication.ApplicationID);
            clsDrivers driver = clsDrivers.FindByPersonID(application.ApplicantPersonID);
            if (driver == null)
            {
                driver= new clsDrivers();
                driver.PersonID = application.ApplicantPersonID;
                driver.CreatedByUserID = clsGlobal.CurrentUser.Id;
                driver.CreatedDate = DateTime.Now;
                if(!driver.Save())
                {
                    MessageBox.Show("Failed to save the driver information.", "Error");
                    return;
                }
            }

            // Save the license information
            _license.ApplicationID = _localDrivingLicenseApplication.ApplicationID;
            _license.DriverID = driver.DriverID;
            _license.CreatedByUserID = clsGlobal.CurrentUser.Id;
            _license.IssueDate = DateTime.Now;
            _license.ExpiryDate = DateTime.Now.AddYears(_LicenseClasses.ValidityLength); // Assuming a 10-years validity period
            _license.IsActive = true;
            _license.LicenseClassID = _localDrivingLicenseApplication.LicenseClassID;
            _license.IssueReason = (byte)clsLicenses.enIssueReason.FirstTime;
            _license.PaidFees = _LicenseClasses.ClassFees;
            _license.Notes = txtNotes.Text;
            if(_license.Save())
            {
                // Update the application status
                application.ApplicationStatus = (byte)clsUtil.enApplicationStatus.Completed;
                application.LastStatusDate = DateTime.Now;
                if (!application.Save())
                {
                    clsLicenses.Delete(_license.LicenseID); // Rollback the license creation
                    MessageBox.Show("Failed to update the application status.", "Error");
                    return;
                }

                MessageBox.Show($"The license has been issued successfully.\nID = {_license.LicenseID}", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to issue the license.", "Error");
            }

        }



        // Events
        private void btnIssue_Click(object sender, EventArgs e)
        {
            IssueLicense();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmIssueDrivingLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
