
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using DVLD_Project.GlobalClasses;
namespace DVLD_Project
{
    public partial class frmAddEditPerson : Form
    {
        enum enMode { AddNewMode = 1, UpdateMode = 2 }
        enum enGender { Male=1,Female=2}
        enMode _Mode;
        clsPerson _Person;
        int _PersonID = -1;

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateMode;
            _PersonID = PersonID;
            

        }
        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNewMode;  
        }

        private void FillDropDownCountries()
        {
            DataTable dt = clsCountry.GetAllCountries();
            dpdCountries.ValueMember = "CountryID";
            dpdCountries.DisplayMember = "CountryName";
            dpdCountries.DataSource = dt;
        }
        private void SetDefaultValues()
        {
            FillDropDownCountries();

            this.Text = "Add New Person";
            lblPersonID.Visible = false;
            txtPersonID.Visible = false;
            pbImageTitle.Image = Properties.Resources.Add_Person_Icon8_96;
            rbMale.Checked = true;
            btnRemoveImage.Visible = false;
            dpdCountries.SelectedIndex = dpdCountries.FindString("Morocco");
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            dpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dpBirthDate.Value = dpBirthDate.MaxDate;
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            _Person = new clsPerson();

        }
        private void LoadData()
        {
            
            this.Text = "Edit Person";
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show($"No Person with ID = {_PersonID} ");
                this.Close();
                return;
            }
            pbImageTitle.Image = Properties.Resources.icons8_writer_male_96;
            lblPersonID.Visible = true;
            txtPersonID.Visible = true;
            txtPersonID.Text = _Person.ID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName ?? "";
            txtThirdName.Text = _Person.ThirdName ?? "";
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dpBirthDate.Value = _Person.BirthDate;
            rbMale.Checked = _Person.Gender == 1;
            txtEmail.Text = _Person.Email ?? "";
            txtPhone.Text = _Person.PhoneNum;
            txtAddress.Text = _Person.Address;
            dpdCountries.SelectedValue = _Person.CountryID;
            if (!string.IsNullOrWhiteSpace(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                using (Image tempImage = Image.FromFile(_Person.ImagePath))
                {
                    pbPerson.Image = new Bitmap(tempImage);
                    pbPerson.ImageLocation = _Person.ImagePath;
                    pbPerson.SizeMode = PictureBoxSizeMode.Zoom;
                }

                btnRemoveImage.Visible = true;

            }
            else
            {
                btnRemoveImage.Visible = false;
                pbPerson.ImageLocation = null;
            }
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rbMale_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (pbPerson.ImageLocation == null)
            {
                if (rbMale.Checked)
                {
                    pbPerson.Image = Properties.Resources.icons8_male_100;
                }
                else
                    pbPerson.Image = Properties.Resources.icons8_female_100;
            }

        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsExist(txtNationalNo.Text.Trim()) && _Mode == enMode.AddNewMode) 
            {
                errorProvider1.SetError(txtNationalNo, "This National No is already exist");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }
        }
        private bool HandlePersonImage()
        {
            if(_Person.ImagePath != pbPerson.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error deleting old image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!string.IsNullOrEmpty(pbPerson.ImageLocation))
                {
                    string SourceImageFile = pbPerson.ImageLocation;

                    if (!clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        MessageBox.Show("Error copying image to project images folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        pbPerson.ImageLocation = SourceImageFile;
                        return true;
                    }
                    
                }

            }
            return true;
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!clsValidation.IsValidEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Invalid Email");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtEmail, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to allow the user to select an image file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the file filter to allow only image files
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Show the dialog and check if the user clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbPerson.Load(openFileDialog.FileName);
                        btnRemoveImage.Visible = true;
                        openFileDialog.Dispose();

                    }
                    catch (Exception ex)
                    {
                        // Handle any errors (e.g., invalid file format)
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (pbPerson.Image != null)
            {
                pbPerson.Image.Dispose();
                pbPerson.ImageLocation= null;
                pbPerson.Image = null;
            }
            btnRemoveImage.Visible = false;
            rbMale_CheckedChanged2(rbMale, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool UserInputValidation()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required","Invalid Input!",buttons:MessageBoxButtons.OK,icon:MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required", "Invalid Input!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                MessageBox.Show("National No is required", "Invalid Input!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone Number is required", "Invalid Input!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required", "Invalid Input!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return false;
            }
            if (dpBirthDate.Value > dpBirthDate.MaxDate) 
            {
                MessageBox.Show("Invalid Birth Date", "Invalid Input!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(dpdCountries.Text.Trim())) 
            {
                MessageBox.Show("Country is required", "Invalid Input!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!UserInputValidation())
                return;
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                return;
            }
            if (!HandlePersonImage())
                return;
           
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim() ?? "";
            _Person.ThirdName = txtThirdName.Text.Trim() ?? "";
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.BirthDate = dpBirthDate.Value;
            _Person.Gender = rbMale.Checked ? (byte)enGender.Male : (byte)enGender.Female;
            _Person.Email = txtEmail.Text.Trim() ?? "";
            _Person.PhoneNum = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.CountryID = Convert.ToInt16(dpdCountries.SelectedValue);
            _Person.ImagePath = pbPerson.ImageLocation;
            if(_Person.Save())
            {
                _PersonID = _Person.ID;
                _Mode = enMode.UpdateMode;
                LoadData();
                MessageBox.Show("Person saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error saving person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void frmAddEditPerson_Shown(object sender, EventArgs e)
        {
            SetDefaultValues();
            if (_Mode == enMode.UpdateMode)
                LoadData();
        }
    }
}
