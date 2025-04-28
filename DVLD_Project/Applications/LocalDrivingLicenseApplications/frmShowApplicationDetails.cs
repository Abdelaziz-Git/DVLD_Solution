using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    public partial class frmShowApplicationDetails: Form
    {
        public frmShowApplicationDetails(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            if(!ucLocalDrivingLicenseApplicationCard1.LoadLocalDrivingLicenseApplicationInfo(LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("Error loading application details.");
                this.Close();
            }

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
