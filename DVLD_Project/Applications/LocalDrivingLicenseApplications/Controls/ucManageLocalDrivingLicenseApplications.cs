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
using DVLD_Project.GlobalClasses;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls
{
    public partial class ucManageLocalDrivingLicenseApplications: UserControl
    {
        public ucManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        // Methods
        private void LoadData(DataView dataView)
        {
            dgvDrivingLicenseApplications.Rows.Clear();
            foreach (DataRowView dv in dataView)
            {
                dgvDrivingLicenseApplications.Rows.Add(dv[0], dv[1], dv[2], dv[3], dv[4], dv[5], dv[6]);
            }
            lblRecords.Text = dgvDrivingLicenseApplications.Rows.Count.ToString();
        }
        private void AddNewApplication()
        {
            using (frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication())
            {
                frm.ShowDialog();
            }
            LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
        }
        private void CancelApplication()
        {
            if (MessageBox.Show("Are you sure you want to cancel this application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells[0].Value.ToString(), out int LDLA_ID) == false)
                {
                    MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int ApplicationID = clsLocalDrivingLicenseApplications.Find(LDLA_ID).ApplicationID;
                clsApplications Application = clsApplications.Find(ApplicationID);
                if (Application != null)
                {
                    Application.ApplicationStatus = (int)clsUtil.enApplicationStatus.Cancelled;
                    if (Application.Save())
                    {
                        MessageBox.Show("Application Cancelled Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
                    }
                    else
                    {
                        MessageBox.Show("Failed to Cancel Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Application Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FilterData(string ColumnName, string TextValue)
        {
            string FilterExp;
            if (ddFilterBy.Text == "LDLA_ID" || ddFilterBy.Text == "Passed Tests")
            {
                FilterExp = $"{ColumnName} = {TextValue}";
            }
            else
            {
                FilterExp = $"{ColumnName} LIKE '{TextValue}%'";
            }
            DataView dataView = clsLocalDrivingLicenseApplications.GetAllDataView();
            dataView.RowFilter = FilterExp;
            LoadData(dataView);
        }
        private string GetSelectedColumnNameInDropDown()
        {

            switch (ddFilterBy.SelectedIndex)
            {
                case 0:
                    return "None";
                case 1:
                    return "NationalNo";
                case 2:
                    return "LocalDrivingLicenseApplicationID";
                case 3:
                    return "FullName";
                case 4:
                    return "PassedTests";
                case 5:
                    return "Status";
                default:
                    return "None";
            }
        }

        // Event Handlers
        private void ucManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
        }
        private void ddFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddFilterBy.Text == "None") 
            {
                txtFind.Visible = false;
            }
            else
            {
                txtFind.Visible = true;
                txtFind.Focus();
                txtFind.Text = "";
                txtFind.PlaceholderText = ddFilterBy.Text;
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFind.Text) && ddFilterBy.Text != "None")
            {
                FilterData(GetSelectedColumnNameInDropDown(), txtFind.Text);
            }
            else
                LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
        }
        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AddNewApplication();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void CanceltoolStripMenuItem_Click(object sender, EventArgs e)
        {  
            CancelApplication();
        }
        private void addNewAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewApplication();
        }
    }
}
