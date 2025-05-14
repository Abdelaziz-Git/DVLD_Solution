using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses
{
    public partial class frmLicenseCrad : Form
    {
        public frmLicenseCrad(int LicenseID)
        {
            InitializeComponent();
            if (!ucDriverLicenseCard1.LoadLicenseInfo(LicenseID))
            {
                MessageBox.Show("Error loading license information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
