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
using DVLD_Project.Applications.LocalDrivingLicenseApplications;
using DVLD_Project.ApplicationsTypes;
using DVLD_Project.GlobalClasses;
using DVLD_Project.TestTypes;
using DVLD_Project.Users;

namespace DVLD_Project
{
    public partial class frmMain : Form
    {
        frmLogin _LoginForm;
        enum PageIndex
        {
            ManagePeople = 0,
            ManageUsers = 1,
            LDLApplications = 2,
            Drivers = 3,
        }
        public frmMain(frmLogin LoginForm)
        {
            InitializeComponent();
            _LoginForm = LoginForm;
        }

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
            settingsToolStripMenuItem.Margin = new Padding((this.Width - 1235) + 76, 0, 0, 0);
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcMain.PageIndex = 0;
            tcSubMain.PageIndex = (int)PageIndex.LDLApplications;
        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcSubMain.PageIndex = (int)PageIndex.Drivers;
            ucListDrivers1.FillDataGridViewDrivers();
        }
    }
}
