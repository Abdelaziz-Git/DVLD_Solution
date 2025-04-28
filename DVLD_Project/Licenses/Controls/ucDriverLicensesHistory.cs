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
        public bool LoadDriverLicensesHistory(int DriverId)
        {
            Driver = clsDrivers.Find(DriverId);
            if (Driver == null)
                return false;

            FillDataGridViewLocalLicenses();
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
    }
}
