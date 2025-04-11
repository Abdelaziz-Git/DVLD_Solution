using DVLD_Business1;
using DVLD_Project.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    public partial class frmNewLocalDrivingLicenseApplication: Form
    {
        enum enPage
        {
            PersonInfo = 0,
            ApplicationInfo = 1,
        }
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        void InizializeApplicationData()
        {
            FillDropDownLicenseClasses();
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationFees.Text = clsApplicationType.Find((int)clsUtil.enApplicationType.NewLocalDrivingLicenseService).Fees.ToString();   
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
        }
        void FillDropDownLicenseClasses()
        {
            ddLicenseClasses.DataSource=clsLicenseClasses.GetAll();
            ddLicenseClasses.DisplayMember = "ClassName";
            ddLicenseClasses.ValueMember = "LicenseClassID";
        }
        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(ucPersonInfoWithFilter1.PersonID == -1)
            {
                MessageBox.Show("Please select a person first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tcNewLocalDrivingLicenseApplication.SelectedIndex = (int)enPage.ApplicationInfo;
            InizializeApplicationData();
        }
        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            tcNewLocalDrivingLicenseApplication.SelectedIndex = (int)enPage.PersonInfo; 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if((clsApplications.PersonHasNewOrCompleted_L_D_L_ApplicationWithSameLicenseClass(ucPersonInfoWithFilter1.PersonID,(int)ddLicenseClasses.SelectedValue)))
            {
                MessageBox.Show("This person has a new or completed application with the same license class\nPlease Change License Class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsApplications application = new clsApplications(); 
            application.ApplicantPersonID = ucPersonInfoWithFilter1.PersonID;
            application.ApplicationTypeID = (int)clsUtil.enApplicationType.NewLocalDrivingLicenseService;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = (byte)clsUtil.enApplicationStatus.New;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = clsApplicationType.Find((int)clsUtil.enApplicationType.NewLocalDrivingLicenseService).Fees;
            application.CreatedByUserID = clsGlobal.CurrentUser.Id;
            if(!application.Save())
            {
                MessageBox.Show("Error while saving the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsLocalDrivingLicenseApplications clsLocalDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
            clsLocalDrivingLicenseApplications.ApplicationID = application.ApplicationID;
            clsLocalDrivingLicenseApplications.LicenseClassID = (int)ddLicenseClasses.SelectedValue;
            if(clsLocalDrivingLicenseApplications.Save())
            {
                lblLocalDrivingLicenseApplicationID.Text = clsLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
                MessageBox.Show("Application saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving the application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tcNewLocalDrivingLicenseApplication.SelectedIndex = (int)enPage.PersonInfo;
        }
    }
}
