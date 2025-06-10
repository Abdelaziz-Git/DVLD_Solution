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

namespace DVLD_Project.Applications.DetainedLicenses
{
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        private clsLicenses _LicenseSelected = null;

        // Methods
        private void DetainLicense()
        {
            if(_LicenseSelected == null)
            {
                MessageBox.Show("Please select license to detained first.", "No selected license",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if( clsLicenses.IsDetained(_LicenseSelected.LicenseID))
            {
                MessageBox.Show("Selected license is already detained.\nPlease select another!", "Already detained",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()) || !decimal.TryParse(txtFineFees.Text, out decimal FineFees))
            {
                MessageBox.Show("Invalid Fine fees.\nPlease enter a valide fine amount.", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show("Are you sure do you want to detain the selected license ?", "Confirmation"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsDetainedLicenses detainLicense = new clsDetainedLicenses();
            detainLicense.LicenseID = _LicenseSelected.LicenseID;
            detainLicense.DetainedDate = DateTime.Now;
            detainLicense.FineFees = FineFees;
            detainLicense.CreatedByUserID = clsGlobal.CurrentUser.Id;
            if(detainLicense.Save())
            {
                MessageBox.Show("License detained successfully.", "Done",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("License is not detained.\nPlease try again!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
        // Events
        private void ucDriverLicenseCardWithFilter1_OnLicenseSelected(DVLD_Business1.clsLicenses obj)
        {
            _LicenseSelected = obj;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            DetainLicense();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
