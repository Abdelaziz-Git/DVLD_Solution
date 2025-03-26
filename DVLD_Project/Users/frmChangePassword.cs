using Bunifu.UI.WinForms;
using DVLD_Business1;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Users
{
    public partial class frmChangePassword: Form
    {
        private int _UserID = -1;
        private clsUser _User;
        public frmChangePassword(int userID)
        {
            if(!clsUser.IsExistByID(userID))
            {
                MessageBox.Show($"User with ID = {userID} not found");
                this.Close();
            }
            InitializeComponent();
            _UserID = userID;
            _User = clsUser.Find(_UserID);
            ucUserInfo1.LoadUserInfo(_UserID);
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            BunifuTextBox txtPassword = (BunifuTextBox)sender;

            if (string.IsNullOrEmpty(txtPassword.Text))
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
        private void txtCurrentPassword_OnIconRightClick(object sender, EventArgs e)
        {
            if (txtCurrentPassword.IconRight.Tag.ToString() == "Show")
            {
                txtCurrentPassword.IconRight = Resources.icons8_hide_Password_48;
                txtCurrentPassword.IconRight.Tag = "Hide";
                txtCurrentPassword.PasswordChar = '\0';
            }
            else
            {
                txtCurrentPassword.IconRight = Resources.icons8_show_password_48;
                txtCurrentPassword.IconRight.Tag = "Show";
                txtCurrentPassword.PasswordChar = '*';
            }
        }
        private void txtNewPassword_OnIconRightClick(object sender, EventArgs e)
        {
            if (txtNewPassword.IconRight.Tag.ToString() == "Show")
            {
                txtNewPassword.IconRight = Resources.icons8_hide_Password_48;
                txtNewPassword.IconRight.Tag = "Hide";
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.IconRight = Resources.icons8_show_password_48;
                txtNewPassword.IconRight.Tag = "Show";
                txtNewPassword.PasswordChar = '*';
            }
        }
        private void txtConfirmPassword_OnIconRightClick(object sender, EventArgs e)
        {
            if (txtConfirmPassword.IconRight.Tag.ToString() == "Show")
            {
                txtConfirmPassword.IconRight = Resources.icons8_hide_Password_48;
                txtConfirmPassword.IconRight.Tag = "Hide";
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtConfirmPassword.IconRight = Resources.icons8_show_password_48;
                txtConfirmPassword.IconRight.Tag = "Show";
                txtConfirmPassword.PasswordChar = '*';
            }
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtCurrentPassword.IconRight.Tag = "Show";
            txtCurrentPassword.PasswordChar = '\0';
            txtNewPassword.IconRight.Tag = "Show";
            txtNewPassword.PasswordChar = '\0';
            txtConfirmPassword.IconRight.Tag = "Show";
            txtConfirmPassword.PasswordChar = '\0';

        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Validete()
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                MessageBox.Show("Please enter your current password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return false;
            }
            if(!clsUser.IsCorrectPassword(_UserID, txtCurrentPassword.Text.Trim()))
            {
                MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Please enter your new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPassword.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("Please confirm your new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return false;
            }
            if (txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("New password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return false;
            }

           
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validete())
                return;
            if (clsUser.ChangePassword(_UserID, txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("An error occurred while changing the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucUserInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
