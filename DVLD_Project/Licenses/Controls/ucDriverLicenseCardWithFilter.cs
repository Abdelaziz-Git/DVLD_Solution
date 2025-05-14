using DVLD_Business1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses.Controls
{
    public partial class ucDriverLicenseCardWithFilter : UserControl
    {
        public event Action<clsLicenses> OnLicenseSelected;

        // Properties
        

        // Constructor
        public ucDriverLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        // Methods
        private bool LicenseIsFound(int LicenseID)
        {
            return ucDriverLicenseCard1.LoadLicenseInfo(LicenseID);
        }

        // Event Handlers
        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                MessageBox.Show("Please enter a license ID to search for.");
                return;
            }
            if (!int.TryParse(txtLicenseID.Text, out int licenseID))
            {
                MessageBox.Show("Please enter a valid license ID.");
                return;
            }
            if (!LicenseIsFound(licenseID))
                MessageBox.Show("License not found. Please try again!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.None);

            OnLicenseSelected?.Invoke(ucDriverLicenseCard1.LicenseInfo);

        }
    }
}
