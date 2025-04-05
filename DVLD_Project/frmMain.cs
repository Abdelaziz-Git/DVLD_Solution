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
            Settings = 2,
            Applications = 3
        }
        public frmMain(frmLogin LoginForm)
        {
            InitializeComponent();
            _LoginForm = LoginForm;
        }

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            tcPagesMain.PageIndex = (int)PageIndex.ManagePeople;
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            tcPagesMain.PageIndex = (int)PageIndex.ManageUsers;
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            tcPagesMain.PageIndex = (int)PageIndex.Settings;
        }

        private void applicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmManageApplicationsTypes manageApplicationsTypes = new frmManageApplicationsTypes())
            {
                manageApplicationsTypes.ShowDialog();
            }   
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            tcPagesMain.PageIndex = (int)PageIndex.Applications;
        }

        private void testTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmManageTestTypes frm = new frmManageTestTypes())
            {
                frm.ShowDialog();
            }   
        }
    }
}
