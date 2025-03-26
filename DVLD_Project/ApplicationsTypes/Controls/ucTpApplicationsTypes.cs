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

namespace DVLD_Project.ApplicationsTypes.Controls
{
    public partial class ucTpApplicationsTypes: UserControl
    {
        public ucTpApplicationsTypes()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvApplicationsTypes.Rows.Clear();
            foreach (clsApplicationType applicationType in clsApplicationType.GetAll())
            {
                dgvApplicationsTypes.Rows.Add(applicationType.Id, applicationType.Title, applicationType.Fees);
            }
            lblNumberOfRecords.Text = dgvApplicationsTypes.Rows.Count.ToString();
        }
        private void ucTpApplicationsTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void EditApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplicationsTypes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvApplicationsTypes.SelectedRows[0];
                if (selectedRow.Cells["clmnID"].Value != null && int.TryParse(selectedRow.Cells["clmnID"].Value.ToString(), out int applicationTypeId))
                {
                    using (frmEditApplicationsTypes frm = new frmEditApplicationsTypes(applicationTypeId))
                    {
                        frm.ShowDialog();
                    }
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Invalid application type selected.", "Edit Application Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an application type to edit.", "Edit Application Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
