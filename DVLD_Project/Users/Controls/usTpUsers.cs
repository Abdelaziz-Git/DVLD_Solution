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
using DVLD_Project.Users;

namespace DVLD_Project.People.Controls
{
    public partial class usTpUsers: UserControl
    {
        public usTpUsers()
        {
            InitializeComponent();
        }
        private void RefreshListUsers()
        {
            dgvUsers.Rows.Clear();
            foreach(DataRowView rowView in clsUser.GetAllUsersDetails())
            {
                dgvUsers.Rows.Add(rowView.Row.ItemArray);   
            }
            lblNumberOfRecords.Text = dgvUsers.Rows.Count.ToString();
        }
        private void usTpUsers_Load(object sender, EventArgs e)
        {
            RefreshListUsers();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using(Form frm = new frmAddEditUser())
            {
                frm.ShowDialog();
                RefreshListUsers();
            }
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form frm = new frmAddEditUser())
            {
                frm.ShowDialog();
                RefreshListUsers();
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID;
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dgvUsers.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dgvUsers.SelectedRows[0].Cells["clmnUserID"].Value!=null)
            {
                UserID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["clmnUserID"].Value);
                using (Form frm = new frmAddEditUser(UserID))
                {
                    frm.ShowDialog();
                    RefreshListUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvUsers.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvUsers.SelectedRows[0].Cells["clmnUserID"].Value != null)
            {
                if (clsUser.Delete(Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["clmnUserID"].Value)))
                {
                    MessageBox.Show("User deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshListUsers();
                }
                else
                {
                    MessageBox.Show("Error deleting user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
