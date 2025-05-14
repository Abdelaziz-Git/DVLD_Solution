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
using Bunifu.UI.WinForms.Helpers.Transitions;
using DVLD_Project.Licenses;

namespace DVLD_Project.Drivers.Controls
{
    public partial class ucListDrivers : UserControl
    {
        // Enums
        public enum enFilterBy
        {
            None = 0,
            DriverID = 1,
            PersonID = 2,
            NationalNo = 3,
            FullName = 4,
        }
        public ucListDrivers()
        {
            InitializeComponent();
        }
        // Methods
        public void FillDataGridViewDrivers()
        {
            dgvDrivers.Rows.Clear();
            foreach (clsDrivers driver in clsDrivers.GetAllDrivers())
            {
                dgvDrivers.Rows.Add(
                     driver.DriverID,
                     driver.PersonID,
                     driver.PersonInfo.NationalNo,
                     driver.PersonInfo.FullName,
                     driver.CreatedDate.ToString("dd/MM/yyyy"),
                     driver.ActiveLicensesCount
                 );
            }
            lblRecords.Text = dgvDrivers.Rows.Count.ToString();
        }
        private string GetSelectedFilterByColumn()
        {
            string filterBy = "";
            switch (ddFilterBy.SelectedIndex)
            {
                case (int)enFilterBy.DriverID:
                    filterBy = "DriverID";
                    break;
                case (int)enFilterBy.PersonID:
                    filterBy = "PersonID";
                    break;
                case (int)enFilterBy.NationalNo:
                    filterBy = "NationalNo";
                    break;
                case (int)enFilterBy.FullName:
                    filterBy = "FullName";
                    break;
            }
            return filterBy;
        }
        private void HandleFilter()
        {
            string filterBy = GetSelectedFilterByColumn();
            string filterValue = txtFind.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filterValue))
            {
                FillDataGridViewDrivers();
                return;
            }
            List<clsDrivers> FilteredDrivers = new List<clsDrivers>();

            if (ddFilterBy.SelectedIndex == (int)enFilterBy.DriverID ||
                   ddFilterBy.SelectedIndex == (int)enFilterBy.PersonID)
            {
                FilteredDrivers = clsDrivers.GetAllDrivers().Where(drivre => drivre.GetPropValue(filterBy).
             ToString().ToLower().Contains(filterValue)).ToList();
            }
            else if (ddFilterBy.SelectedIndex == (int)enFilterBy.NationalNo ||
                ddFilterBy.SelectedIndex == (int)enFilterBy.FullName)
            {
                FilteredDrivers = clsDrivers.GetAllDrivers().Where(DriverPersonInfo => DriverPersonInfo.PersonInfo.GetPropValue(filterBy).
                ToString().ToLower().Contains(filterValue)).ToList();
            }

            dgvDrivers.Rows.Clear();
            foreach (clsDrivers driver in FilteredDrivers)
            {
                dgvDrivers.Rows.Add(
                     driver.DriverID,
                     driver.PersonID,
                     driver.PersonInfo.NationalNo,
                     driver.PersonInfo.FullName,
                     driver.CreatedDate.ToString("dd/MM/yyyy"),
                     driver.ActiveLicensesCount
                 );
            }
            lblRecords.Text = dgvDrivers.Rows.Count.ToString();
        }
        private void HandleRowClicked()
        {
            if (!int.TryParse(dgvDrivers.SelectedRows[0].Cells["clmnDriverID"].Value.ToString(), out int driverID))
            {
                MessageBox.Show("Invalid Driver ID.\nPlease try again.");
                return;
            }
            using (frmShowDriverLicenses frm = new frmShowDriverLicenses(driverID))
            {
                frm.ShowDialog();
            }
        }

        // Events
        private void ucListDrivers_Load(object sender, EventArgs e)
        {
            FillDataGridViewDrivers();
        }

        private void ddFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddFilterBy.SelectedIndex == (int)enFilterBy.None)
            {
                txtFind.Text = "";
                txtFind.Visible = false;
            }
            else
            {
                txtFind.Visible = true;
                txtFind.PlaceholderText = "Search by " + ddFilterBy.Text;
                txtFind.Focus();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            HandleFilter();
        }

        private void showDriverLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleRowClicked();
        }

        private void dgvDrivers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HandleRowClicked();
        }
    }
}
