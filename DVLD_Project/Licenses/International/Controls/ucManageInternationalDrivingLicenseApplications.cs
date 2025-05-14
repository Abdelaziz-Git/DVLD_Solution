using Bunifu.UI.WinForms.Helpers.Transitions;
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

namespace DVLD_Project.Licenses.International.Controls
{
    public partial class ucManageInternationalDrivingLicenseApplications : UserControl
    {
        public ucManageInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        // Methods
        public void RefreshAndFillDataGridViewInternationalLicenseApplications()
        {
            List<clsInternationalLicenses> internationalLicenses = clsInternationalLicenses.GetAllInternationalLicenses();
            dgvInternationalLicenseApplications.Rows.Clear();
            string DriverName;
            foreach(clsInternationalLicenses internationalLicense in internationalLicenses)
            {
                DriverName = clsDrivers.Find(internationalLicense.DriverID).PersonInfo.FullName;
                dgvInternationalLicenseApplications.Rows.Add
                    (
                    internationalLicense.InternationalLicenseID,
                    internationalLicense.ApplicationID,
                    internationalLicense.DriverID,
                    DriverName,
                    internationalLicense.IssuedUsingLocalLicenseID,
                    internationalLicense.IssueDate.ToShortDateString(),
                    internationalLicense.ExpirationDate.ToShortDateString(),
                    internationalLicense.IsActive == true ? "Active" : "Inactive"
                    );
            }
            lblRecords.Text=dgvInternationalLicenseApplications.RowCount.ToString();
        }
        string GetSelectedFieldNameInDropDownFilter()
        {
            switch (ddFilterBy.SelectedIndex)
            {
                case 1:
                    {
                        return "InternationalLicenseID";
                    }
                case 2:
                    {
                        return "ApplicationID";
                    }
                case 3:
                    {
                        return "IssuedUsingLocalLicenseID";
                    }
                default:
                {
                    return "None";
                }
            } 
        }

        // Events
        private void ucManageInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            RefreshAndFillDataGridViewInternationalLicenseApplications();
        }
        private void btnAddInternationalLicense_Click(object sender, EventArgs e)
        {
            using(frmAddNewInternationalLicense frm=new frmAddNewInternationalLicense())
            {
                frm.ShowDialog();
            }
            RefreshAndFillDataGridViewInternationalLicenseApplications();
        }
        private void ddFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddFilterBy.SelectedIndex==0)
            {
                txtFind.Visible = false;
            }
            else
            {
                txtFind.Text = string.Empty;
                txtFind.Visible = true;
                txtFind.Focus();
                txtFind.TextPlaceholder = "Enter " + ddFilterBy.Text;
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {

            List<clsInternationalLicenses> FilteredInternationalLicenses =
                clsInternationalLicenses.GetAllInternationalLicenses().
                Where(obj => obj.GetPropValue(GetSelectedFieldNameInDropDownFilter())
                .ToString().ToLower().Contains(txtFind.Text.ToLower())).ToList();
            dgvInternationalLicenseApplications.Rows.Clear();
            string DriverName;
            foreach (clsInternationalLicenses internationalLicense in FilteredInternationalLicenses)
            {
                DriverName = clsDrivers.Find(internationalLicense.DriverID).PersonInfo.FullName;
                dgvInternationalLicenseApplications.Rows.Add
                    (
                    internationalLicense.InternationalLicenseID,
                    internationalLicense.ApplicationID,
                    internationalLicense.DriverID,
                    DriverName,
                    internationalLicense.IssuedUsingLocalLicenseID,
                    internationalLicense.IssueDate.ToShortDateString(),
                    internationalLicense.ExpirationDate.ToShortDateString(),
                    internationalLicense.IsActive == true ? "Active" : "Inactive"
                    );
            }
            lblRecords.Text = dgvInternationalLicenseApplications.RowCount.ToString();

        }
        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvInternationalLicenseApplications.RowCount==0)
            {
                MessageBox.Show("No record selected!");
                return;
            }
            if (!int.TryParse(dgvInternationalLicenseApplications.SelectedRows[0].
                Cells["clmnInternationalLicenseID"].Value.ToString(),out int InternationalLicenseID))
            {
                MessageBox.Show("Invalide International license ID.", "Error casting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (frmInternationalLicenseCard frm = new frmInternationalLicenseCard(InternationalLicenseID))
            {
                frm.ShowDialog();
            }
        }
        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenseApplications.RowCount == 0)
            {
                MessageBox.Show("No record selected!");
                return;
            }
            //the column DriverID is invisible in data grid
            if (!int.TryParse(dgvInternationalLicenseApplications.SelectedRows[0].
                Cells["clmnDriverID"].Value.ToString(), out int DriverID))
            {
                MessageBox.Show("Invalide driver ID.", "Error casting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using(frmShowDriverLicenses frm =new frmShowDriverLicenses(DriverID))
            {
                frm.ShowDialog();
            }
        }
    }
}
