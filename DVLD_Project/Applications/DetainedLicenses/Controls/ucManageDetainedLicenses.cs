using DVLD_Business1;
using DVLD_Project.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.DetainedLicenses.Controls
{
    public partial class ucManageDetainedLicenses : UserControl
    {
        public ucManageDetainedLicenses()
        {
            InitializeComponent();
        }
        // Enums 
        enum enLicenseStatus
        {
            Released,
            Detained
        }
        public void Refresh_dgvDetainedLicenses()
        {
            List<clsDetainedLicenses> detainedLicenses = clsDetainedLicenses.GetAllDetainedLicenses();
            dgvDetainedLicenses.Rows.Clear();
            for (int i = 0; i < detainedLicenses.Count; i++) 
            {
                string status;
                if (detainedLicenses[i].IsRelease.HasValue && detainedLicenses[i].IsRelease == true)
                    status = Enum.GetName(typeof(enLicenseStatus), enLicenseStatus.Released);
                else
                    status = Enum.GetName(typeof(enLicenseStatus), enLicenseStatus.Detained);

                dgvDetainedLicenses.Rows.Add
                    (
                    detainedLicenses[i].DetainedID,
                    detainedLicenses[i].LicenseID,
                    detainedLicenses[i].DetainedDate.ToShortDateString(),
                    detainedLicenses[i].FineFees.ToString("0.00"),
                    status,
                    detainedLicenses[i].ReleaseDate.HasValue ? detainedLicenses[i].ReleaseDate.Value.ToShortDateString() : "???",
                    detainedLicenses[i].PersonInfo.NationalNo,
                    detainedLicenses[i].PersonInfo.FullName,
                    detainedLicenses[i].ReleaseApplicationID.HasValue ? detainedLicenses[i].ReleaseApplicationID.Value.ToString() : "???"
                    );
            }
            lblRecords.Text = dgvDetainedLicenses.Rows.Count.ToString() + " detained licenses";
        }
        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            using(frmReleaseLicense frm = new frmReleaseLicense())
            {
                frm.ShowDialog();
                Refresh_dgvDetainedLicenses();
            }
        }
        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            using (frmDetainLicense frm = new frmDetainLicense())
            {
                frm.ShowDialog();
                Refresh_dgvDetainedLicenses();
            }
        }
        private void ucManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            Refresh_dgvDetainedLicenses();
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvDetainedLicenses.SelectedRows.Count==0)
            {
                MessageBox.Show("No selected row!");
                return;
            }
            if (int.TryParse(dgvDetainedLicenses.SelectedRows[0].Cells["clmnLicenseID"].Value.ToString(), out int licenseID))
            {
                using (frmLicenseCrad frm = new frmLicenseCrad(licenseID))
                {
                    frm.ShowDialog();
                }
            }
            else
                MessageBox.Show("Invalid license id.");
        }
        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("No selected row!");
                return;
            }
            if (int.TryParse(dgvDetainedLicenses.SelectedRows[0].Cells["clmnLicenseID"].Value.ToString(), out int licenseID))
            {
                using(frmReleaseLicense frm = new frmReleaseLicense(licenseID))
                {
                    frm.ShowDialog();
                    Refresh_dgvDetainedLicenses();
                }
            }
            else
                MessageBox.Show("Invalid license id.");
        }
        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.RowCount == 0)
                return;
            
            releaseLicenseToolStripMenuItem.Enabled = dgvDetainedLicenses.SelectedRows[0].Cells["clmnStatus"].Value.ToString()
                == Enum.GetName(typeof(enLicenseStatus), enLicenseStatus.Detained);
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dgvDetainedLicenses.SelectedRows.Count==0)
                e.Cancel = true;
        }
    }
}
