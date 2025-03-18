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

namespace DVLD_Project.Users
{
    public partial class frmAddEditUser: Form
    {
        enum enMode { AddNewMode = 1, UpdateMode = 2 }
        enum enPages { PersonInfo = 0, LoginInfo = 1 }
        enMode _Mode = enMode.AddNewMode;
        int _UserID = -1;
        clsUser _User;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNewMode;
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _UserID = UserID;
        }
        private void SetDefaultValues()
        { 
            ucPersonInfoWithFilter1.SetDefaultValues();
            lblAddNewUser.Text = "Add New User";
            this.Text = "Add New User";
            lblSelectPerson.Visible = true;
            lblUserIdValue.Text = "???";
            lblPersonIDValue.Text = "???";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
            chkManagePeople.Checked = true;
            chkManageUsers.Checked = false;
            chkManageApplications.Checked = false;

        }
        private void LoadData ()
        {
            if (_Mode == enMode.AddNewMode)
            {
                SetDefaultValues();
                tcAddEditUser.SelectedIndex = (int)enPages.PersonInfo;
                _User = new clsUser();
                return;
            }
            tcAddEditUser.SelectedIndex = (int)enPages.LoginInfo;
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show($"User with ID = {_UserID} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblAddNewUser.Text = "Edit User";
            lblAddNewUser2.Text = "Edit User";  
            this.Text = "Edit User";
            lblSelectPerson.Visible = false;
            ucPersonInfoWithFilter1.LoadPersonInfo(_User.PersonID);
            lblUserIdValue.Text = _User.Id.ToString();
            lblPersonIDValue.Text = _User.PersonID.ToString();
            txtUsername.Text = _User.UserName;
            txtPassword.Text = "********";
            txtPassword.ReadOnly = true;
            txtConfirmPassword.Text = "********";
            txtConfirmPassword.ReadOnly = true;
            chkIsActive.Checked = _User.IsActive;
                
            
        }   
        private bool ValidatePersonInfo()
        {
            if (_Mode == enMode.UpdateMode)
                return true;
           
            if (ucPersonInfoWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Please select a person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (clsUser.IsExistByPersonID(ucPersonInfoWithFilter1.PersonID))
            {
                MessageBox.Show("This person is already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!ValidatePersonInfo())
                return;
            lblPersonIDValue.Text = ucPersonInfoWithFilter1.PersonID.ToString();
            tcAddEditUser.SelectedIndex = (int)enPages.LoginInfo;
        }
        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateData()
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            if(_Mode == enMode.AddNewMode)
            {
                if (clsUser.IsExistByPersonID(Convert.ToInt32(lblPersonIDValue.Text)))
                {
                    MessageBox.Show("This person is already a user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (clsUser.IsExistByUsername(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("This username is already used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return false;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return false;
                }
                if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return false;
                }
            }
            
            if(!chkIsActive.Checked)
            {
                if (MessageBox.Show("Are you sure you want to deactivate this account user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;
            if(int.TryParse(lblPersonIDValue.Text, out int PersonID))
            {
                _User.PersonID = PersonID;
            }
            else
            {
                MessageBox.Show("Error Parsing Person ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.UserName = txtUsername.Text.Trim();

            if (_Mode == enMode.AddNewMode)
            {
                _User.Password = txtPassword.Text.Trim();
            }
            _User.IsActive = chkIsActive.Checked;
            _User.Permissions = -1;
            if (_User.Save())
            {
                lblUserIdValue.Text = _User.Id.ToString();
                _UserID = _User.Id;
                _Mode = enMode.UpdateMode;
                LoadData();
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while saving the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tcAddEditUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcAddEditUser.SelectedTab == tpSelectPerson)
            {
                this.AcceptButton = btnNext;
            }
            else
            {
                this.AcceptButton = btnSave;
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcAddEditUser.SelectedIndex = (int)enPages.PersonInfo;
        }
    }
}
