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

namespace DVLD_Project.Applications.Controls
{
    public partial class ucApplicationCard: UserControl
    {

        private clsApplications _application = null;
        public clsApplications Application { get { return _application; } }
        public ucApplicationCard()
        {
            InitializeComponent();
            bunifuPictureBox8.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            bunifuPictureBox7.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        }
        public void SetDeffaultValues()
        {
            _application = null;

            lblID.Text = "[???]";
            lblType.Text = "[???]";
            lblStatus.Text = "[???]";
            lblDate.Text = "[???]";
            lblApplicant.Text = "[???]";
            lblStatusDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblFees.Text = "[???]";
        }
        private void SetApplicationInfo()
        {
            clsApplicationType _applicationType = clsApplicationType.Find(_application.ApplicationTypeID);
            clsUser _user = clsUser.Find(_application.CreatedByUserID);

            lblID.Text = _application.ApplicationID.ToString();
            lblType.Text = _applicationType.Title;
            lblStatus.Text = ((clsUtil.enApplicationStatus)_application.ApplicationStatus).ToString();
            lblDate.Text = _application.ApplicationDate.ToString("dd/MM/yyyy");
            lblApplicant.Text = _user.PersonInfo.FullName;
            lblStatusDate.Text = _application.LastStatusDate.ToString("dd/MM/yyyy");
            lblCreatedBy.Text = _user.UserName;
            lblFees.Text = _applicationType.Fees.ToString("C2");
        }
        public bool LoadApplicationInfo(int ApplicationID)
        {

            _application = clsApplications.Find(ApplicationID);
            if(_application == null)
            {
                SetDeffaultValues();
                return false;
            }
            else
            {
                SetApplicationInfo();
                return true;
            }
            
        }

        private void linkLblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_application!=null)
            {
                using(frmPersonDetails _frmPersonDetails = new frmPersonDetails(_application.ApplicantPersonID))
                {
                    _frmPersonDetails.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No application selected.");
            }
        }
    }
}
