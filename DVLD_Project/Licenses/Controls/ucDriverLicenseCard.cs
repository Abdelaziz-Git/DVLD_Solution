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
using System.Runtime.Remoting.Messaging;
using DVLD_Project.Properties;
using System.Security.AccessControl;

namespace DVLD_Project.Licenses.Controls
{
    public partial class ucDriverLicenseCard: UserControl
    {
        public ucDriverLicenseCard()
        {
            InitializeComponent();
        }
        clsLicenses _License = null;
        clsPerson _Person = null;
        public bool LoadLicenseInfo(int LicenseID)
        {
            _License = clsLicenses.Find(LicenseID);
            if (_License == null)
                return false;
            _Person = clsPerson.Find(clsDrivers.Find(_License.DriverID).PersonID);
            if (_Person == null)
                return false;
            lblLicense.Text = clsLicenseClasses.Find(_License.LicenseClassID).ClassName;
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            if(_Person.Gender == 1)
            {
                lblGender.Text = "Male";
                pbGendor.Image = Resources.person_male_icon_32;
                pbPerson.Image = Resources.icons8_male_100;
            }
            else
            {
                lblGender.Text = "Female";
                pbGendor.Image = Resources.icons8_female_32;
                pbPerson.Image = Resources.icons8_female_100;
            }
            lblEmail.Text = _Person.Email ?? "N/A";
            lblAddress.Text = _Person.Address ?? "N/A";
            lblissueDate.Text = _License.IssueDate.ToString("dd/MM/yyyy");
            lblNotes.Text = _License.Notes ?? "N/A";
            lblBirthDate.Text = _Person.BirthDate.ToString("dd/MM/yyyy");
            lblPhone.Text = _Person.PhoneNum ?? "N/A";
            lblCountry.Text = _Person.Country.Name;
            lblisActive.Text = _License.IsActive ? "Yes" : "No";
            lblisDetained.Text = clsLicenses.IsDetained(LicenseID) ? "Yes" : "No";
            lblDriverID.Text = _License.DriverID.ToString();
            lblexpirationDate.Text = _License.ExpiryDate.ToString("dd/MM/yyyy");
            lblissueReason.Text = Enum.GetName(typeof(clsLicenses.enIssueReason), _License.IssueReason) ?? "Unknown";
            if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
            {
                pbPerson.ImageLocation = _Person.ImagePath;
            }
            return true;
        }
        private void SetDefaultValues()
        {
            lblLicense.Text = "N/A";
            lblName.Text = "N/A";
            lblNationalNo.Text = "N/A";
            lblGender.Text = "N/A";
            lblEmail.Text = "N/A";
            lblAddress.Text = "N/A";
            lblissueDate.Text = "N/A";
            lblNotes.Text = "N/A";
            lblBirthDate.Text = "N/A";
            lblPhone.Text = "N/A";
            lblCountry.Text = "N/A";
            lblisActive.Text = "N/A";
            lblisDetained.Text = "N/A";
            lblDriverID.Text = "N/A";
            lblexpirationDate.Text = "N/A";
            lblissueReason.Text = "N/A";
        }
    }
}
