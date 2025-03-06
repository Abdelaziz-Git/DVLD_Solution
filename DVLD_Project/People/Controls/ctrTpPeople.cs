using DVLD_Business1;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class ctrTpPeople : UserControl
    {
        public ctrTpPeople()
        {
            InitializeComponent();
        }
        private void RefreshListPeople()
        {
            dgvPeople.Rows.Clear();
            dgvPeople.SuspendLayout();
            foreach (DataRowView Row in clsPerson.GetAllPeopleDetails().DefaultView)
            {
                dgvPeople.Rows.Add(Row.Row.ItemArray);
            }
            dgvPeople.ResumeLayout();
            txtNumberOfPeople.Text = $"Number of People: {dgvPeople.Rows.Count}";
        }
        private string GetSelectedColumnNameInDropDown()
        {
            switch (dpdFilterBy.SelectedIndex)
            {
                case 0:
                    return "None";
                case 1:
                    return "PersonID";
                case 2:
                    return "NationalNo";
                case 3:
                    return "FirstName";
                case 4:
                    return "LastName";
                case 5:
                    return "Email";
                case 6:
                    return "Phone";
                case 7:
                    return "Address";
                case 8:
                    return "Gender";
                case 9:
                    return "CountryName";
                default:
                    return "None";
            }
        }
        private void FilterListPeople(string columnName, string SearchText)
        {
            if (columnName == "None")
            {
                RefreshListPeople();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                DataView dv = clsPerson.GetAllPeopleDetails().DefaultView;
                dv.RowFilter = columnName == "PersonID" ? $"{columnName} = {SearchText}" : $"{columnName} LIKE '{SearchText}%'";
                dgvPeople.Rows.Clear();
                dgvPeople.SuspendLayout();
                foreach (DataRowView rowView in dv)
                {
                    dgvPeople.Rows.Add(rowView.Row.ItemArray);
                }
                dgvPeople.ResumeLayout();
            }
            else
            {
                RefreshListPeople();
            }

            txtNumberOfPeople.Text = $"Number of People: {dgvPeople.Rows.Count}";
        }
        private void ctrTpPeople_Load(object sender, EventArgs e)
        {
            RefreshListPeople();
        }

        private void dpdFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterBy.Visible = dpdFilterBy.SelectedIndex != 0;
            if(txtFilterBy.Visible)
            {
                txtFilterBy.Focus();
                txtFilterBy.PlaceholderText = dpdFilterBy.Text;
                txtFilterBy.Text = "";
            }
            RefreshListPeople();    
        }

        private void txtFilterBy_TextChange_1(object sender, EventArgs e)
        {
            FilterListPeople(GetSelectedColumnNameInDropDown(), txtFilterBy.Text);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            using (var frmAddPerson = new frmAddEditPerson())
            {
                frmAddPerson.ShowDialog();
            }
            RefreshListPeople();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dpdFilterBy.Text == "Person ID" && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmAddPerson = new frmAddEditPerson())
            {
                frmAddPerson.ShowDialog();
            }
            RefreshListPeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvPeople.SelectedRows[0];
            if (!int.TryParse(selectedRow.Cells["clmnPersonID"].Value.ToString(), out int personID))
            {
                MessageBox.Show("Selected person ID is not valid.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imagePath = selectedRow.Cells["clmnImagePath"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Are you sure you want to delete person with ID = {personID} ?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPerson.Delete(personID))
                {
                    RefreshListPeople();
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                    MessageBox.Show("Person deleted successfully", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete person", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvPeople.SelectedRows[0];

            if (!int.TryParse(selectedRow.Cells["clmnPersonID"].Value.ToString(), out int personID))
            {
                MessageBox.Show("Selected person ID is not valid.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var frmEditPerson = new frmAddEditPerson(personID))
            {
                frmEditPerson.ShowDialog();
            }
            RefreshListPeople();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvPeople.SelectedRows[0].Cells["clmnPersonID"].Value == null)
            {
                MessageBox.Show("Selected person does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int PersonId;
            if (!int.TryParse(dgvPeople.SelectedRows[0].Cells["clmnPersonID"].Value.ToString(), out PersonId))
            {
                MessageBox.Show("Selected person ID is not valid.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var frmPersonDetails = new frmPersonDetails(PersonId))
            {
                frmPersonDetails.ShowDialog();
            }
        }
    }
}
