
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business1;
namespace DVLD_Project
{
    public partial class frmAddEditPerson : Form
    {
        enum enMode { AddNewMode = 1, UpdateMode = 2 }
        enMode _Mode;
        clsPerson _Person;
        int _PersonID;
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.AddNewMode;
            }
            else
            {
                _Mode = enMode.UpdateMode;
            }
        }
        private void _FilldpdCountries()
        {
            DataTable dt = clsCountry.GetAllCountries();
            dpdCountries.ValueMember = "CountryID";
            dpdCountries.DisplayMember = "CountryName";
            dpdCountries.DataSource = dt;
        }

        private void _Load()
        {
            _FilldpdCountries();
            if (_Mode == enMode.AddNewMode)
            {
                lblAddEditPerson.Text = "Add New Person";
                rbMale.Checked = true;
                pbPerson.Image = Properties.Resources.icons8_male_100;
                if (clsCountry.IsExist("Morocco"))
                    dpdCountries.SelectedIndex = clsCountry.Find("Morocco").Id - 1;
                else
                    dpdCountries.SelectedIndex = 0;

                _Person = new clsPerson();
                return;
            }
            lblAddEditPerson.Text = "Edit Person";
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Person not found");
                this.Close();
            }
            else
            {
                txtPersonID.Text = _Person.ID.ToString();
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName == null ? "" : _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName == null ? "" : _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtNationalNo.Text = _Person.NationalNo;
                dpBirthDate.Value = _Person.BirthDate;
                if (_Person.Gender == 1)
                {
                    rbMale.Checked = true;
                    pbPerson.Image = Properties.Resources.icons8_male_100;
                }
                else
                {
                    rbFemale.Checked = true;
                    pbPerson.Image = Properties.Resources.icons8_female_100;
                }
                txtEmail.Text = _Person.Email == null ? "" : _Person.Email;
                txtPhone.Text = _Person.PhoneNum;
                txtAddress.Text = _Person.Address;
                dpdCountries.SelectedValue = _Person.CountryID;
                if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
                {
                    pbPerson.Image = Image.FromFile(_Person.ImagePath);
                    btnAddRemoveImage.Image = Properties.Resources.icons8_remove_image_32;
                }
            }
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rbMale_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rbMale.Checked)
            {
                pbPerson.Image = Properties.Resources.icons8_male_100;
            }
            else
                pbPerson.Image = Properties.Resources.icons8_female_100;
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsExist(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "This National No is already exist");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "");
            }
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _Load();
        }
    }
}
