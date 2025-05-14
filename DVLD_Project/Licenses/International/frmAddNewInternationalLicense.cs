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

namespace DVLD_Project.Licenses.International
{
    public partial class frmAddNewInternationalLicense : Form
    {
        // Constructor
        public frmAddNewInternationalLicense()
        {
            InitializeComponent();
            ucDriverLicenseCardWithFilter1.OnLicenseSelected += OnlicenseSelected;
        }


        // Properties
        clsLicenses _LocalLicense = null;
        clsInternationalLicenses _InternationalLicense = null;
        clsApplicationType _ApplicationType = clsApplicationType.Find((int)clsUtil.enApplicationType.NewInternationalLicense);

        // Methods
        private bool HasValidetLocalLicense()
        {
            if( _LocalLicense == null )
            {
                MessageBox.Show("Please select a local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(_LocalLicense.IsActive == false)
            {
                MessageBox.Show("The selected local license is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(_LocalLicense.ExpiryDate < DateTime.Now)
            {
                MessageBox.Show("The selected local license is expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool HasActiveInternationalLicense()
        {
            List<clsInternationalLicenses> internationalLicenses = clsInternationalLicenses.FindByDriverID(_LocalLicense.DriverID);
            foreach (clsInternationalLicenses internationalLicense in internationalLicenses)
            {
                if (internationalLicense.IsActive == true)
                {
                    MessageBox.Show("The selected local license already has an active international license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        private int CreateNewApplicationForInternationalLicense()
        {
            clsApplications application = new clsApplications();
            application.ApplicationTypeID = _ApplicationType.Id;
            application.ApplicationDate = DateTime.Now;
            application.ApplicantPersonID = clsDrivers.Find(_LocalLicense.DriverID).PersonID;
            application.ApplicationStatus = (int)clsUtil.enApplicationStatus.New;
            application.CreatedByUserID = clsGlobal.CurrentUser.Id;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = _ApplicationType.Fees;
            if(application.Save() == false)
            {
                MessageBox.Show("Failed to create a new application for the international license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return application.ApplicationID;
        }
        private void AddNewInternationalLicense()
        {
            if (!HasValidetLocalLicense())
                return;
            if (HasActiveInternationalLicense())
                return;
            _InternationalLicense = new clsInternationalLicenses();
            int ApplicationID = CreateNewApplicationForInternationalLicense();
            if (ApplicationID == -1)
                return;
            _InternationalLicense.ApplicationID = ApplicationID;
            _InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.Id;
            _InternationalLicense.DriverID = _LocalLicense.DriverID;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.ExpirationDate = DateTime.Now.AddYears((clsLicenseClasses.Find(_LocalLicense.LicenseClassID).ValidityLength));
            _InternationalLicense.IsActive = true;
            _InternationalLicense.IssuedUsingLocalLicenseID = _LocalLicense.LicenseID;
            if (_InternationalLicense.Save())
            {
                MessageBox.Show("International license issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIssue.Enabled = false;
                ucDriverLicenseCardWithFilter1.Enabled = false;
                linkShowInternationalLicense.Enabled = true;
            }
            else
            {
                clsApplications.Delete(ApplicationID);
                MessageBox.Show("Failed to issue the international license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Events
        private void OnlicenseSelected(clsLicenses obj)
        {
            _LocalLicense = obj;
            linkShowDriverLicenses.Enabled = _LocalLicense != null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewInternationalLicense_Load(object sender, EventArgs e)
        {
            lblTotalFees.Text = _ApplicationType.Fees.ToString("0.00") + " DH";
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            AddNewInternationalLicense();
        }

        private void linkShowInternationalLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_InternationalLicense == null)
            {
                MessageBox.Show("Please issue an international license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using(frmInternationalLicenseCard frm =new frmInternationalLicenseCard(_InternationalLicense.InternationalLicenseID))
            {
                frm.ShowDialog();
            }
            
        }

        private void linkShowDriverLicenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LocalLicense == null)
            {
                MessageBox.Show("Please select a local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (frmShowDriverLicenses frm = new frmShowDriverLicenses(_LocalLicense.DriverID))
            {
                frm.ShowDialog();
            }
        }
    }
}
