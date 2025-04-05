using DVLD_Business1;
using DVLD_Project.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Users
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            if (User != null) 
            {
                clsGlobal.CurrentUser = User;
                if(chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }
                if (!User.IsActive)
                {
                    MessageBox.Show("Your account is deactivated, Please contact your admin!", "Account deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmMain frm = new frmMain(this);
                    this.Hide();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "";
            string Password = "";
            if (clsGlobal.GetCredentials(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

            txtUserName.Focus();    
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            }
            else
            {
                clsGlobal.RememberUsernameAndPassword("", "");
            }
        }
    }
}
