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
    public partial class frmInternationalLicenseCard : Form
    {
        // Properties
        public frmInternationalLicenseCard(int InternationalLicenseID)
        {
            InitializeComponent();
            if (!ucDriverInternationalLicenseCard1.LoadInternationalLicenseInfo(InternationalLicenseID))
            {
                MessageBox.Show("International license Not found!","Not found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
