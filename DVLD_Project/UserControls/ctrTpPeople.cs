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

namespace DVLD_Project
{
    public partial class ctrTpPeople : UserControl
    {
        public ctrTpPeople()
        {
            InitializeComponent();
        }

        private void _Refresh_dgvPeople()
        {
            DataTable dataTable = clsPerson.GetAllPeopleDetails();
            dgvPeople.Rows.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                dgvPeople.Rows.Add(row["PersonID"], row["NationalNo"], row["FirstName"], row["SecondName"], row["ThirdName"], row["LastName"],
                    row["Email"], row["Phone"], row["Address"], row["Gender"], row["BirthDate"], row["CountryName"], row["ImagePath"]);
            }
            txtNumberOfPeople.Text = "Number of People: " + dgvPeople.Rows.Count.ToString();
        }
        private void _dgvPeopleFilterBy(string ColumnName, string Text)
        {
            if (ColumnName == "None")
            {
                _Refresh_dgvPeople();
                txtFilterBy.Visible = false;
                return;
            }
            txtFilterBy.Visible = true;
            if (!string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                string FilterExpression = "";
                if (ColumnName == "PersonID")
                {
                    FilterExpression = ColumnName + "=" + Text;
                }
                else
                {
                    FilterExpression = ColumnName + " LIKE '%" + Text + "%'";
                }
                DataView dv = clsPerson.GetAllPeopleDetails().DefaultView;
                dv.RowFilter = FilterExpression;
                dgvPeople.Rows.Clear();
                foreach (DataRow row in dv.ToTable().Rows)
                {
                    dgvPeople.Rows.Add(row["PersonID"], row["NationalNo"], row["FirstName"], row["SecondName"], row["ThirdName"], row["LastName"],
                        row["Email"], row["Phone"], row["Address"], row["Gender"], row["BirthDate"], row["CountryName"], row["ImagePath"]);
                }
            }
            else
            {
                _Refresh_dgvPeople();
            }
            txtNumberOfPeople.Text = "Number of People: " + dgvPeople.Rows.Count.ToString();
        }
        private void ctrTpPeople_Load(object sender, EventArgs e)
        {
            _Refresh_dgvPeople();
        }
        private void dpdFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterBy.Text = "";
            _dgvPeopleFilterBy(dpdFilterBy.Text, txtFilterBy.Text);
        }
        private void txtFilterBy_TextChange_1(object sender, EventArgs e)
        {
            _dgvPeopleFilterBy(dpdFilterBy.Text, txtFilterBy.Text);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddPerson = new frmAddEditPerson(-1);
            frmAddPerson.ShowDialog();
        }
    }
}
