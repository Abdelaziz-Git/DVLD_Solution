using DVLD_Business1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses.International.Controls
{
    public partial class ucDriverInternationalLicenseCard : UserControl
    {
        // Properties
        private clsInternationalLicenses _InternationalLicense;
        private clsPerson _Person;
        public ucDriverInternationalLicenseCard()
        {
            InitializeComponent();
        }
        public bool LoadInternationalLicenseInfo(int internationalLicenseID)
        {
            _InternationalLicense = clsInternationalLicenses.Find(internationalLicenseID);
            if (_InternationalLicense == null)
                return false;
            _Person = clsPerson.Find(clsDrivers.Find(_InternationalLicense.DriverID).PersonID);
            if (_Person == null)
                return false;
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email;
            lblissueDate.Text = _InternationalLicense.IssueDate.ToString("d");
            lblBirthDate.Text = _Person.BirthDate.ToString("d");
            lblPhone.Text = _Person.PhoneNum;
            lblCountry.Text = _Person.Country.Name;
            lblisActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblexpirationDate.Text = _InternationalLicense.ExpirationDate.ToString("d");
            if (!string.IsNullOrWhiteSpace(_Person.ImagePath))
                pbPerson.ImageLocation = _Person.ImagePath;

                return true;
        }

    }
}
