using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business1;
using DVLD_Project.Licenses;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls
{
    public partial class ucLocalDrivingLicenseApplicationCard: UserControl
    {
        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication = null;
        public clsLocalDrivingLicenseApplications LocalDrivingLicenseApplication { get { return _LocalDrivingLicenseApplication; } }
        public ucLocalDrivingLicenseApplicationCard()
        {
            InitializeComponent();
        }
        private void SetDeffaultValues()
        {
            _LocalDrivingLicenseApplication = null;
            lblID.Text = "[???]";
            lblLicense.Text = "[???]";
            lblPassedTest.Text = "[???]";
            linkLblShowLicenseInfo.Enabled = false;
        }
        private void SetLocalDrivingLicenseApplicationInfo()
        {
            lblID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicense.Text = clsLicenseClasses.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblPassedTest.Text = _LocalDrivingLicenseApplication.PassedTest.ToString() + "/3";
            linkLblShowLicenseInfo.Enabled = clsLicenses.IsLicenseExistsByApplicationID(_LocalDrivingLicenseApplication.ApplicationID);
        }
        public bool LoadLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication != null)
            {
                SetLocalDrivingLicenseApplicationInfo();
                ucApplicationCard1.LoadApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);
                return true;
            }
            else
            {
                SetDeffaultValues();
                ucApplicationCard1.SetDeffaultValues();
                return false;
            }
        }

        private void linkLblShowLicenseInfo_MouseHover(object sender, EventArgs e)
        {
            if(linkLblShowLicenseInfo.Enabled)
            {
                ToolTip1.SetToolTip(linkLblShowLicenseInfo, "Click to view license information");
            }
            else
            {
                ToolTip1.SetToolTip(linkLblShowLicenseInfo, "No license information available");
            }
        }

        private void ucLocalDrivingLicenseApplicationCard_Load(object sender, EventArgs e)
        {
            bunifuPictureBox8.Anchor = AnchorStyles.Left | AnchorStyles.Top; 
        }

        private void linkLblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_LocalDrivingLicenseApplication != null)
            {
                using (frmLicenseCrad frm = new frmLicenseCrad(clsLicenses.FindByApplicationID(_LocalDrivingLicenseApplication.ApplicationID).LicenseID))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
