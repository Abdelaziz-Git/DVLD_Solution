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
using DVLD_Project.Tests;
using DVLD_Project.Licenses;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls
{
    public partial class ucManageLocalDrivingLicenseApplications: UserControl
    {
        // Enums
        public enum enCMS_LDLA_Items
        {
            ShowApplicationDetails = 0,
            AddNewApplication = 2,
            EditApplication = 3,
            DeleteApplication = 4,
            CancelApplication = 5,
            ScheduleTest = 7,
            IssueDrivingLicense = 9,
            ShowDrivingLicense = 11,
            ShowPersonLicenseHistory = 13,
        }
        public enum enSheduleTest
        {
            VisionTest,
            WrittenTest,
            PracticalTest
        }

        // Constructors
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
                if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out int LDLA_ID) == false)
                {
                    MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int ApplicationID = clsLocalDrivingLicenseApplications.Find(LDLA_ID).ApplicationID;
                clsApplications Application = clsApplications.Find(ApplicationID);
                if (Application != null)
                {
                    Application.ApplicationStatus = (int)clsUtil.enApplicationStatus.Canceled;
                    Application.LastStatusDate = DateTime.Now;  
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
        private void ScheduleVisionTest()
        {
            if(dgvDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("No application selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvDrivingLicenseApplications.CurrentRow.Cells["clmnPassedTests"].Value.ToString() != "0")
            {
                MessageBox.Show("You can only schedule a vision test for new applications.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out int LDLA_ID) == false)
            {
                MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmVisionTestAppointements frm = new frmVisionTestAppointements(LDLA_ID))
            {
                frm.ShowDialog();
                LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
            }
        }
        private void ScheduleWrittenTest()
        {
            if (dgvDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("No application selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvDrivingLicenseApplications.CurrentRow.Cells["clmnPassedTests"].Value.ToString() != "1")
            {
                MessageBox.Show("You can only schedule a written test for applications that have passed the vision test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out int LDLA_ID) == false)
            {
                MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (frmWrittenTestAppointements frm = new frmWrittenTestAppointements(LDLA_ID))
            {
                frm.ShowDialog();
                LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
            }
        }
        private void SchedulePracticalTest()
        {
            if (dgvDrivingLicenseApplications.CurrentRow == null)
            {
                MessageBox.Show("No application selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvDrivingLicenseApplications.CurrentRow.Cells["clmnPassedTests"].Value.ToString() != "2")
            {
                MessageBox.Show("You can only schedule a practical test for applications that have passed the written test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out int LDLA_ID) == false)
            {
                MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (frmPracticalTestAppointements frm = new frmPracticalTestAppointements(LDLA_ID))
            {
                frm.ShowDialog();
                LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
            }
        }
        private void DeleteApplication()
        {
            if (MessageBox.Show("Are you sure you want to delete this application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out int LDLA_ID) == false)
                {
                    MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsLocalDrivingLicenseApplications LDLA = clsLocalDrivingLicenseApplications.Find(LDLA_ID);
                if (LDLA != null)
                {
                    if (clsLocalDrivingLicenseApplications.Delete(LDLA_ID) && clsApplications.Delete(LDLA.ApplicationID)) 
                    {
                        MessageBox.Show("Application Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
                                         }
                    else
                    {
                        MessageBox.Show("Failed to Delete Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Application Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            DeleteApplication();
        }
        private void CanceltoolStripMenuItem_Click(object sender, EventArgs e)
        {  
            CancelApplication();
        }
        private void addNewAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewApplication();
        }
        private void scheduleTestToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (byte.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmnPassedTests"].Value.ToString(),out byte PassedTests))
            {
                scheduleVisionTestToolStripMenuItem.Enabled = PassedTests == 0;
                scheduleWrittenTestToolStripMenuItem.Enabled = PassedTests == 1;
                schedulePracticalTestToolStripMenuItem.Enabled = PassedTests == 2;
            }
            else
            {
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                schedulePracticalTestToolStripMenuItem.Enabled = false;
                MessageBox.Show("Invalid Passed Tests value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmsLDLA_Opened(object sender, EventArgs e)
        {
            if (dgvDrivingLicenseApplications.CurrentRow == null)
            {
                cmsLDLA.Enabled = false;
                return;
            }
            cmsLDLA.Enabled = true;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
            showAppDetailsToolStripMenuItem.Enabled = true;
            editAppToolStripMenuItem.Enabled = true;
            deleteToolStripMenuItem.Enabled = true;
            CanceltoolStripMenuItem.Enabled = true;
            scheduleTestToolStripMenuItem.Enabled = true;
            issueDrivingLicenseToolStripMenuItem.Enabled = true;
            showDrivingLicenseToolStripMenuItem.Enabled = true;
            showAppDetailsToolStripMenuItem.Enabled = true;

            clsUtil.enApplicationStatus status;
            if (!Enum.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmnStatus"].Value.ToString(), out status)) 
            {
                MessageBox.Show("Invalid Application Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte PassedTests;

            if (!byte.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmnPassedTests"].Value.ToString(), out PassedTests))
            {
                MessageBox.Show("Invalid Passed Tests value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PassedTests == 3)
            {
                scheduleTestToolStripMenuItem.Enabled = false;
                if (status == clsUtil.enApplicationStatus.New)
                {
                    showDrivingLicenseToolStripMenuItem.Enabled = false;
                    issueDrivingLicenseToolStripMenuItem.Enabled = true;
                    editAppToolStripMenuItem.Enabled = true;
                    deleteToolStripMenuItem.Enabled = true;
                    CanceltoolStripMenuItem.Enabled = true;
                }
                else if (status == clsUtil.enApplicationStatus.Completed)
                {
                    showDrivingLicenseToolStripMenuItem.Enabled = true;
                    issueDrivingLicenseToolStripMenuItem.Enabled = false;
                    editAppToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    CanceltoolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                scheduleTestToolStripMenuItem.Enabled = true;
                showDrivingLicenseToolStripMenuItem.Enabled = false;
                issueDrivingLicenseToolStripMenuItem.Enabled = false;
                editAppToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                CanceltoolStripMenuItem.Enabled = true;
            }
            if(status==clsUtil.enApplicationStatus.Canceled)
            {
                deleteToolStripMenuItem.Enabled = true;

                editAppToolStripMenuItem.Enabled = false;
                CanceltoolStripMenuItem.Enabled = false;
                scheduleTestToolStripMenuItem.Enabled = false;
                issueDrivingLicenseToolStripMenuItem.Enabled = false;
                showDrivingLicenseToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
                showAppDetailsToolStripMenuItem.Enabled = false;
            }
           

        }
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleVisionTest();
        }
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleWrittenTest();
        }
        private void schedulePracticalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulePracticalTest();
        }
        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLA_ID;
            if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out LDLA_ID) == false)
            {
                MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (frmIssueDrivingLicenseForFirstTime frm = new frmIssueDrivingLicenseForFirstTime(LDLA_ID))
            {
                frm.ShowDialog();
                LoadData(clsLocalDrivingLicenseApplications.GetAllDataView());
            }
        }
        private void showDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLA_ID;
            if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out LDLA_ID) == false)
            {
                MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsLocalDrivingLicenseApplications LDLA = clsLocalDrivingLicenseApplications.Find(LDLA_ID);
            if (LDLA == null)
            {
                MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsLicenses license = clsLicenses.FindByApplicationID(LDLA.ApplicationID);
            if (license == null)
            {
                MessageBox.Show("No license found for this application!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (frmLicenseCrad frm = new frmLicenseCrad(license.LicenseID))
            {
                frm.ShowDialog();
            }


        }
        private void showAppDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLA_ID;
            if (int.TryParse(dgvDrivingLicenseApplications.CurrentRow.Cells["clmLDLA_ID"].Value.ToString(), out LDLA_ID) == false)
            {
                MessageBox.Show("Invalid LDLA_ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using(frmShowApplicationDetails frm = new frmShowApplicationDetails(LDLA_ID))
            {
                frm.ShowDialog();
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvDrivingLicenseApplications.CurrentRow.Cells["clmnNationalNo"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(NationalNo))
            {
                MessageBox.Show("Invalid National No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsDrivers driver = clsDrivers.FindByPersonID(clsPerson.Find(NationalNo).ID);
            if (driver == null)
            {
                MessageBox.Show("Driver not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (frmShowDriverLicenses frm = new frmShowDriverLicenses(driver.DriverID))
            {
                frm.ShowDialog();
            }

        }
    }
}
