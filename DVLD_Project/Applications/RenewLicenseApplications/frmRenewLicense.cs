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

namespace DVLD_Project.Applications.RenewLicenseApplications
{
    public partial class frmRenewLicense : Form
    {
        public frmRenewLicense()
        {
            InitializeComponent();
        }
        clsLicenses _LicenseSelected;
        clsApplicationType _ApplicationType = clsApplicationType.Find((int)clsUtil.enApplicationType.RenewDrivingLicenseService);
        clsLicenseClasses _LicenseClasse;

        // Methods
        private int CreateRenewLicenseApplication()
        {
            clsApplications application = new clsApplications();
            application.ApplicantPersonID = clsDrivers.Find(_LicenseSelected.DriverID).PersonID;
            application.ApplicationDate=DateTime.Now;
            application.ApplicationStatus = (int)clsUtil.enApplicationStatus.New;
            application.ApplicationTypeID = _ApplicationType.Id;
            application.CreatedByUserID = clsGlobal.CurrentUser.Id;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = _ApplicationType.Fees;
            application.Save();
            return application.ApplicationID;
        }
        private int CreateNewLicense(int applicationID)
        {
            clsLicenses license= new clsLicenses();
            license.ApplicationID= applicationID;
            license.CreatedByUserID= clsGlobal.CurrentUser.Id;
            license.DriverID=_LicenseSelected.DriverID;
            license.ExpiryDate = DateTime.Now.AddYears(_LicenseClasse.ValidityLength);
            license.IsActive = true;
            license.IssueDate= DateTime.Now;
            license.IssueReason = (byte)clsLicenses.enIssueReason.Renew;
            license.LicenseClassID=_LicenseSelected.LicenseClassID;
            license.PaidFees = _LicenseClasse.ClassFees;
            license.Notes=txtNotes.Text;
            license.Save();
            return license.LicenseID;
        }
        private void HandeledRenewLicense()
        {
            if(_LicenseSelected==null)
            {
                MessageBox.Show("Please search and select license first!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure do you want to renew the license selected?", "Renew license",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            clsApplications application = clsApplications.Find(CreateRenewLicenseApplication());
            if(application is null)
            {
                MessageBox.Show("Faild to create new application!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int licenseID = CreateNewLicense(application.ApplicationID);
            if(licenseID == -1)
            {
                clsApplications.Delete(application.ApplicationID);
                MessageBox.Show("Faild to create renew License!\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"License renewed successfully.\nLicense Id = {licenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LicenseSelected.IsActive = false;
                _LicenseSelected.Save();
                application.ApplicationStatus = (byte)clsUtil.enApplicationStatus.Completed;
                application.LastStatusDate = DateTime.Now;
                application.Save();
                this.Close();
            }
        }

        // Events
        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            lblApplicationFees.Text = _ApplicationType.Fees.ToString("0.0") + " MAD";
        }
        private void ucDriverLicenseCardWithFilter1_OnLicenseSelected(clsLicenses obj)
        {
            _LicenseSelected = obj;
            if(_LicenseSelected != null)
            {
                if (_LicenseSelected.ExpiryDate.AddDays(-1) > DateTime.Now)
                {
                    MessageBox.Show($"Selected license is not yet expired, it will expire on {_LicenseSelected.ExpiryDate.ToShortDateString()}",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRenew.Enabled = false;
                    return;
                }
                if(_LicenseSelected.IsActive==false)
                {
                    MessageBox.Show($"Selected license is inactive\nPlease select another license.",
                       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRenew.Enabled = false;
                    return;
                }

                btnRenew.Enabled = true;
                _LicenseClasse = clsLicenseClasses.Find(_LicenseSelected.LicenseClassID);
                lblLicenseFees.Text = _LicenseClasse.ClassFees.ToString("0.00") + " MAD";
                lblTotalFees.Text = (_ApplicationType.Fees + _LicenseClasse.ClassFees).ToString("0.00") + " MAD";
            }
            else
            {
                btnRenew.Enabled = false;
            }

        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            HandeledRenewLicense();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
