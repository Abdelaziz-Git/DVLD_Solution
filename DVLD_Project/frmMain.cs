using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using DVLD_Business1;
using DVLD_Project.Applications.DetainedLicenses;
using DVLD_Project.Applications.LocalDrivingLicenseApplications;
using DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls;
using DVLD_Project.Applications.RenewLicenseApplications;
using DVLD_Project.Applications.ReplacementForDamagedOrLostLicenses;
using DVLD_Project.ApplicationsTypes;
using DVLD_Project.GlobalClasses;
using DVLD_Project.Licenses.International;
using DVLD_Project.TestTypes;
using DVLD_Project.Users;

namespace DVLD_Project
{
    public partial class frmMain : Form
    {
        // Properties
        frmLogin _LoginForm;

        // Enums
        enum PageIndex
        {
            ManagePeople  ,
            ManageUsers ,
            LDLApplications ,
            Drivers ,
            InternationalLicenses,
            DetainedLicenses
        }

        // Constructor
        public frmMain(frmLogin LoginForm)
        {
            InitializeComponent();
            _LoginForm = LoginForm;
        }


        // Events
        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            tcMain.PageIndex = 0;
            tcSubMain.PageIndex = (int)PageIndex.ManagePeople;
        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            tcMain.PageIndex = 0;
            tcSubMain.PageIndex = (int)PageIndex.ManageUsers;
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _LoginForm.Show();
        }
        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmUserInfo userInfo = new frmUserInfo(clsGlobal.CurrentUser.Id))
            {
                userInfo.ShowDialog();
            }   
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmChangePassword changePassword = new frmChangePassword(clsGlobal.CurrentUser.Id))
            {
                changePassword.ShowDialog();
            }
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void applicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmManageApplicationsTypes manageApplicationsTypes = new frmManageApplicationsTypes())
            {
                manageApplicationsTypes.ShowDialog();
            }   
        }
        private void testTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmManageTestTypes frm = new frmManageTestTypes())
            {
                frm.ShowDialog();
            }   
        }
        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication())
            {
                frm.ShowDialog();
            }
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            settingsToolStripMenuItem.Margin = new Padding((this.Width - 1235) + 196, 0, 0, 0);
        }
        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcMain.PageIndex = 0;
            tcSubMain.PageIndex = (int)PageIndex.LDLApplications;
            ucManageLocalDrivingLicenseApplications1.LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
        }
        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcSubMain.PageIndex = (int)PageIndex.Drivers;
            ucListDrivers1.FillDataGridViewDrivers();
        }
        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmAddNewInternationalLicense frm = new frmAddNewInternationalLicense())
            {
                frm.ShowDialog();
            }
        }
        private void intenationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcSubMain.PageIndex = (int)PageIndex.InternationalLicenses;
            ucManageInternationalDrivingLicenseApplications1.RefreshAndFillDataGridViewInternationalLicenseApplications();
        }
        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmRenewLicense  frm = new frmRenewLicense())
            { frm.ShowDialog(); }
        }
        private void replacementForDamagedOrLostLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmReplacementForDamagedOrLostLicenses frm = new frmReplacementForDamagedOrLostLicenses())
            {
                frm.ShowDialog();
            }
        }
        private void tlsLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            pbCurrentUser.ImageLocation = clsGlobal.CurrentUser.PersonInfo.ImagePath;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            using (frmDetainLicense frm = new frmDetainLicense()) { frm.ShowDialog(); }
            ucManageDetainedLicenses1.Refresh_dgvDetainedLicenses();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            using (frmReleaseLicense frm =new frmReleaseLicense())
            {
                frm.ShowDialog();
            }
            ucManageDetainedLicenses1.Refresh_dgvDetainedLicenses();
        }

        private void btnDetainedLicenses_Click(object sender, EventArgs e)
        {
            tcSubMain.PageIndex = (byte)PageIndex.DetainedLicenses;
            ucManageDetainedLicenses1.Refresh_dgvDetainedLicenses();
        }

        private void btnAddNewLicense_Click(object sender, EventArgs e)
        {
            using (frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication())
            {
                frm.ShowDialog();
            }
        }

        private void btnAddInternationalLicense_Click(object sender, EventArgs e)
        {
            using (frmAddNewInternationalLicense frm = new frmAddNewInternationalLicense())
            {
                frm.ShowDialog();
            }
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            tcSubMain.PageIndex = (int)PageIndex.Drivers;
            ucListDrivers1.FillDataGridViewDrivers();
        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            using (frmRenewLicense frm = new frmRenewLicense())
            { frm.ShowDialog(); }
        }

        private void btnReplaceLicense_Click(object sender, EventArgs e)
        {
            using (frmReplacementForDamagedOrLostLicenses frm = new frmReplacementForDamagedOrLostLicenses())
            {
                frm.ShowDialog();
            }
        }

        private void btnApplicationsTypes_Click(object sender, EventArgs e)
        {
            using (frmManageApplicationsTypes manageApplicationsTypes = new frmManageApplicationsTypes())
            {
                manageApplicationsTypes.ShowDialog();
            }
        }

        private void btnTestsTypes_Click(object sender, EventArgs e)
        {
            using (frmManageTestTypes frm = new frmManageTestTypes())
            {
                frm.ShowDialog();
            }
        }
    }
}
