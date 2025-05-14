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
using DVLD_Project.Licenses.International;

namespace DVLD_Project.Licenses.Controls
{
    public partial class ucDriverLicensesHistory: UserControl
    {
        // Enums
        enum enLicenseType
        {
            Local, International
        }

        // Properties
        public clsDrivers Driver { get; private set; }
        public List<clsLicenses> LocalLicenses 
        { 
            get 
            {
                return Driver != null ? clsLicenses.FindByDriverID(Driver.DriverID) : null;
            } 
        }
        public List<clsInternationalLicenses> InternationalLicenses
        {
            get
            {
                return Driver != null ? clsInternationalLicenses.FindByDriverID(Driver.DriverID) : null;
            }
        }

        public ucDriverLicensesHistory()
        {
            InitializeComponent();
        }

        // Methods
        private void FillDataGridViewLocalLicenses()
        {
            dgvLocalLicenses.Rows.Clear();
            if (LocalLicenses == null || LocalLicenses.Count == 0)
            {
                lblRecords.Text = "No license(s) found";
                return;
            }
            foreach (clsLicenses license in LocalLicenses)
            {
                dgvLocalLicenses.Rows.Add
                (
                    license.LicenseID, 
                    license.ApplicationID,
                    license.ClassName,
                    license.IssueDate,
                    license.ExpiryDate,
                    license.IsActive
                );
            }
            lblRecords.Text = dgvLocalLicenses.Rows.Count.ToString() + " license(s)";
        }
        private void FillDataGridViewInternationalLicenses()
        {
            dgvInternationalLicenses.Rows.Clear();
            if (InternationalLicenses == null || InternationalLicenses.Count == 0) 
            {
                lblRecordsInter.Text = "No license(s) found";
                return;
            }
            string DriverName = clsPerson.Find(Driver.PersonID).FullName;
            foreach(clsInternationalLicenses internationalLicense in InternationalLicenses)
            {
                dgvInternationalLicenses.Rows.Add
                    (internationalLicense.InternationalLicenseID, internationalLicense.IssuedUsingLocalLicenseID,
                    DriverName, internationalLicense.IssueDate, internationalLicense.ExpirationDate, internationalLicense.IsActive);
            }
            lblRecordsInter.Text = nameof(dgvInternationalLicenses.RowCount);
        }
        public bool LoadDriverLicensesHistory(int DriverId)
        {
            Driver = clsDrivers.Find(DriverId);
            if (Driver == null)
                return false;

            FillDataGridViewLocalLicenses();
            FillDataGridViewInternationalLicenses();
            return true;

        }


        // Event Handlers
        private void ucDriverLicensesHistory_Load(object sender, EventArgs e)
        {
            tcLicenses.PageIndex = (int)enLicenseType.Local;
        }

        private void btnLocalLicenses_Click(object sender, EventArgs e)
        {
            tcLicenses.PageIndex = (int)enLicenseType.Local;
        }

        private void btnInternational_Click(object sender, EventArgs e)
        {
            tcLicenses.PageIndex = (int)enLicenseType.International;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = Convert.ToInt32(dgvInternationalLicenses.SelectedRows[0].Cells[0].Value);
            using(frmInternationalLicenseCard frm=new frmInternationalLicenseCard(InternationalLicenseID))
            {
                frm.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLocalLicenses.SelectedRows[0].Cells[0].Value.ToString(), out int licenseID))
            {
                using (frmLicenseCrad frm = new frmLicenseCrad(licenseID))
                { frm.ShowDialog(); }
            }
            else
                MessageBox.Show("Invalide LicenseID.");
        }
    }
}
