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
using static DVLD_Project.GlobalClasses.clsUtil;

namespace DVLD_Project.Applications.DetainedLicenses
{
    public partial class frmReleaseLicense : Form
    {
        public frmReleaseLicense()
        {
            InitializeComponent();
        }
        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            ucDriverLicenseCardWithFilter1.PerformClickButtonFind(LicenseID);
        }
        // Properties
        private clsLicenses _LicenseSelected = null;
        private clsDetainedLicenses _DetainedLicense = null;
        private clsApplicationType _ApplicationType = clsApplicationType.Find((byte)clsUtil.enApplicationType.ReleaseDetainedDrivingLicenseService);
        // Methods
        private clsApplications InitializeReleaseLicenseApplication()
        {
            clsApplications application = new clsApplications();
            application.ApplicantPersonID = clsDrivers.Find(_LicenseSelected.DriverID).PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = (int)clsUtil.enApplicationStatus.New;
            application.ApplicationTypeID = _ApplicationType.Id;
            application.CreatedByUserID = clsGlobal.CurrentUser.Id;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = _ApplicationType.Fees;
            return application;
        }
        private void ReleaseLicense()
        {
            if(_LicenseSelected is null)
            {
                MessageBox.Show("Please select a license first.");
                return;
            }
            if(!clsLicenses.IsDetained(_LicenseSelected.LicenseID))
            {
                MessageBox.Show("The selected license is not detained.");
                return;
            }
            clsApplications application = InitializeReleaseLicenseApplication();
            if(!application.Save())
            {
                MessageBox.Show("Faild to create release license application");
                return;
            }
            if(_DetainedLicense is null)
            {
                MessageBox.Show("Detained license not found.\nPlease try again.");
                return; 
            }
            _DetainedLicense.IsRelease = true;
            _DetainedLicense.ReleaseDate = DateTime.Now;
            _DetainedLicense.ReleasedByUserID = clsGlobal.CurrentUser.Id;
            _DetainedLicense.ReleaseApplicationID = application.ApplicationID;
            if(_DetainedLicense.Save())
            {
                application.LastStatusDate = DateTime.Now;
                application.ApplicationStatus=(int)clsUtil.enApplicationStatus.Completed;
                if(!application.Save())
                {
                    MessageBox.Show("Detain license application not updated !!!");
                }
                MessageBox.Show("License is released successfully.");
                this.Close();
            }
            else 
            {
                MessageBox.Show("License is not released.\nPlease try again.", "Error");
                clsApplications.Delete(application.ApplicationID);
            }
        }

        // Events
        private void ucDriverLicenseCardWithFilter1_OnLicenseSelected(clsLicenses obj)
        {
            _LicenseSelected = obj;
            if (_LicenseSelected is null)
            {
                lblFineFees.Text = "??? MAD";
                lblTotalFees.Text = "??? MAD";
                return;
            }
            _DetainedLicense = clsDetainedLicenses.FindByLicenseID(_LicenseSelected.LicenseID);
            if (_DetainedLicense!=null)
            {
                lblFineFees.Text = _DetainedLicense.FineFees.ToString() + " MAD";
                lblTotalFees.Text = (_DetainedLicense.FineFees + _ApplicationType.Fees).ToString() + " MAD";
            }
           

        }
        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            lblApplicationFees.Text = _ApplicationType.Fees.ToString() + " MAD";
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            ReleaseLicense();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
