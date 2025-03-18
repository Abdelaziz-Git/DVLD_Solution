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
using System.IO;

namespace DVLD_Project.UserControls
{
    public partial class ucPersonInfo: UserControl
    {
        private int _PersonID = -1;
        private clsPerson _Person;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SelectedPerson
        {
            get { return _Person; }
        }
        public ucPersonInfo()
        {
            InitializeComponent();
        }
        private void LoadPersonImage()
        {
            pbPerson.Image = _Person.Gender == 1 ? pbPerson.Image = Properties.Resources.icons8_male_100 : pbPerson.Image = Properties.Resources.icons8_female_100;

            if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
            {
                if (File.Exists(_Person.ImagePath))
                {
                    pbPerson.ImageLocation = _Person.ImagePath;
                }
                else
                {
                    MessageBox.Show($"Image with Path = {_Person.ImagePath} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void LoadPersonInfo(int personID)
        {
            _Person = clsPerson.Find(personID);
            if (_Person == null)
            {
                SetDefaultValues();
                MessageBox.Show($"Person with ID = {personID} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            clsPerson Person = clsPerson.Find(NationalNo);
            if (Person == null)
            {
                SetDefaultValues();
                MessageBox.Show($"Person with National No = {NationalNo} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Person = Person;
            FillPersonInfo();
        }
        private void FillPersonInfo()
        {
            _PersonID = _Person.ID;
            lblPersonIDValue.Text = _Person.ID.ToString();
            lblNationalNoValue.Text = _Person.NationalNo;
            lblNameValue.Text = _Person.FullName;
            lblEmailValue.Text = _Person.Email;
            lblPhoneValue.Text = _Person.PhoneNum;
            lblAddressValue.Text = _Person.Address;
            lblBirthDateValue.Text = _Person.BirthDate.ToShortDateString();
            lblGenderValue.Text = _Person.Gender == 1 ? "Male" : "Female";
            pbGendor.Image = _Person.Gender == 1 ? pbPerson.Image = Properties.Resources.person_male_icon_32 :
                Properties.Resources.icons8_female_32;
            lblCountryValue.Text = _Person.Country.Name;
            LoadPersonImage();
        }
        public void SetDefaultValues()
        {
            _PersonID = -1;
            _Person = null;
            lblPersonIDValue.Text = "[???]";
            lblNationalNoValue.Text = "[???]";
            lblNameValue.Text = "[???]";
            lblEmailValue.Text = "[???]";
            lblPhoneValue.Text = "[???]";
            lblAddressValue.Text = "[???]";
            lblBirthDateValue.Text = "[???]";
            lblGenderValue.Text = "[???]";
            lblCountryValue.Text = "[???]";
        }
        private void ucPersonInfo_Load(object sender, EventArgs e)
        {
            if(_PersonID == -1)
            {
                SetDefaultValues();
            }
        }
        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            using(Form frmEdit=new frmAddEditPerson(_PersonID))
            {
                frmEdit.ShowDialog();
            }
            LoadPersonInfo(_PersonID);   
        }
    }
}
