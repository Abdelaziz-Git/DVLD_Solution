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
using DVLD_Project.ApplicationsTypes;

namespace DVLD_Project.TestTypes.Controls
{
    public partial class ucManageTestTypes: UserControl
    {
        public ucManageTestTypes()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dgvTestTypes.Rows.Clear();
            foreach (clsTestTypes clsTestTypes in clsTestTypes.GetAll())
            {
                dgvTestTypes.Rows.Add(clsTestTypes.Id, clsTestTypes.Title,clsTestTypes.Description, clsTestTypes.Fees);
            }
            lblNumberOfRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }
        private void ucTestTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //private void EditApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (dgvTestTypes.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dgvTestTypes.SelectedRows[0];
        //        if (selectedRow.Cells["clmnID"].Value != null && int.TryParse(selectedRow.Cells["clmnID"].Value.ToString(), out int applicationTypeId))
        //        {
        //            using (frmEditTestTypes frm = new frmEditTestTypes())
        //            {
        //                frm.ShowDialog();
        //            }
        //            LoadData();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid application type selected.", "Edit Application Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select an application type to edit.", "Edit Application Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
    }
}
