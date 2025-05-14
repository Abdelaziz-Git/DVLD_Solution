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

namespace DVLD_Project.Applications.ReplacementForDamagedOrLostLicenses
{
    public partial class frmReplacementForDamagedOrLostLicenses : Form
    {
        public frmReplacementForDamagedOrLostLicenses()
        {
            InitializeComponent();
        }

        // Properties
        private clsLicenses _LicenseSelected = null;
        private clsApplicationType _ApplicationTypeSelected = clsApplicationType.Find((int)clsUtil.enApplicationType.ReplacementforaDamagedDrivingLicense);
        private clsLicenseClasses _LicenseClasse = null;

        // Methods

        /// Handles the selection of a license and updates the UI accordingly.
        /// <param name="obj">The selected license object of type clsLicenses.</param>
        private void HandeledOnLicenseSelected(clsLicenses obj)
        {
            // Assign the selected license to the private field
            _LicenseSelected = obj;

            // If no license is selected, reset related fields and disable the Replace button
            if (_LicenseSelected is null)
            {
                _LicenseClasse = null;
                btnReplace.Enabled = false;
                return;
            }

            // Enable the Replace button since a license is selected
            btnReplace.Enabled = true;

            // Retrieve the license class details based on the selected license's class ID
            _LicenseClasse = clsLicenseClasses.Find(_LicenseSelected.LicenseClassID);

            rbDamagedLicense_CheckedChanged(null, null);
            // Check if the selected license is inactive
            if (!_LicenseSelected.IsActive)
            {
                // Show a message box indicating the license is inactive
                MessageBox.Show($"Selected license is inactive\nPlease select another license.",
                       "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disable the Replace button as the license is inactive
                btnReplace.Enabled = false;
            }
        }
        private clsApplications CreateApplicationForDamagedOrLostLicense()
        {
            clsApplications application = new clsApplications();
            application.ApplicantPersonID = clsDrivers.Find(_LicenseSelected.DriverID).PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = (int)clsUtil.enApplicationStatus.New;
            application.ApplicationTypeID = _ApplicationTypeSelected.Id;
            application.CreatedByUserID = clsGlobal.CurrentUser.Id;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = _ApplicationTypeSelected.Fees;
            return application;
        }
        private clsLicenses CreateNewLicenseForDamagedOrLostLicense(int applicationID)
        {
            clsLicenses license = new clsLicenses();
            license.ApplicationID = applicationID;
            license.CreatedByUserID = clsGlobal.CurrentUser.Id;
            license.DriverID = _LicenseSelected.DriverID;
            license.ExpiryDate = DateTime.Now.AddYears(_LicenseClasse.ValidityLength);
            license.IsActive = true;
            license.IssueDate = DateTime.Now;
            license.IssueReason = rbDamagedLicense.Checked ? (byte)clsLicenses.enIssueReason.ReplacementForDamaged : (byte)clsLicenses.enIssueReason.ReplacementForLost;
            license.LicenseClassID = _LicenseSelected.LicenseClassID;
            license.PaidFees = _LicenseClasse.ClassFees;
            license.Notes = txtNotes.Text;
            return license;
        }
        private void HandeledReplacementForDamagedOrLostLicense()
        {
            if (_LicenseSelected == null)
            {
                MessageBox.Show("Please search and select license first!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Are you sure do you want to replace the license selected\nfor {_ApplicationTypeSelected.Title}?", "Replace license",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsApplications application = CreateApplicationForDamagedOrLostLicense();

            if (application is null || application.Save() is false) 
            {
                MessageBox.Show("Faild to create new application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsLicenses NewLicense = CreateNewLicenseForDamagedOrLostLicense(application.ApplicationID);
            if (NewLicense is null || NewLicense.Save() is false) 
            {
                clsApplications.Delete(application.ApplicationID);
                MessageBox.Show("Faild to replace License!\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"License replaced successfully.\nLicense ID = {NewLicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LicenseSelected.IsActive = false;
                _LicenseSelected.Save();
                application.ApplicationStatus = (int)clsUtil.enApplicationStatus.Completed;
                application.LastStatusDate = DateTime.Now;  
                application.Save();
                this.Close();
            }
        }


        // Events
        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
            {
                _ApplicationTypeSelected = clsApplicationType.Find
                    ((int)clsUtil.enApplicationType.ReplacementforaDamagedDrivingLicense);
                lblApplicationFees.Text = _ApplicationTypeSelected.Fees.ToString("0.00") + " MAD";
                lblTitle.Text = _ApplicationTypeSelected.Title;
            }
            else
            {
                _ApplicationTypeSelected = clsApplicationType.Find
                    ((int)clsUtil.enApplicationType.ReplacementforaLostDrivingLicense);
                lblApplicationFees.Text = _ApplicationTypeSelected.Fees.ToString("0.00") + " MAD";
                lblTitle.Text = _ApplicationTypeSelected.Title;
            }
            if (_LicenseClasse != null)
            {
                // Update the license fees label with the class fees
                lblLicenseFees.Text = _LicenseClasse.ClassFees.ToString("0.00") + " MAD";

                // Calculate and update the total fees label (application fees + class fees)
                lblTotalFees.Text = (_ApplicationTypeSelected.Fees + _LicenseClasse.ClassFees).ToString("0.00");
            }

        }

        private void ucDriverLicenseCardWithFilter1_OnLicenseSelected(clsLicenses obj)
        {
            HandeledOnLicenseSelected(obj);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            HandeledReplacementForDamagedOrLostLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
