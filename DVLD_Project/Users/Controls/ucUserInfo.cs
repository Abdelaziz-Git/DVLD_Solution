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

namespace DVLD_Project.Users.Controls
{
    public partial class ucUserInfo: UserControl
    {
        public int UserID { get { return _UserID; } }
        int _UserID = -1;
        public clsUser User { get { return clsUser.Find(_UserID); } }
        public ucUserInfo()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(int UserId)
        {
            if(!clsUser.IsExistByID(UserId))
            {
                MessageBox.Show("User not found");
                return;
            }
            _UserID = UserId;
            ucPersonInfo1.LoadPersonInfo(User.PersonID);
            lblUserID.Text = User.Id.ToString();
            lblUsername.Text = User.UserName;
            lblIsActive.Text = User.IsActive ? "Yes" : "No";
            switchIsActive.Value = User.IsActive;
            lblPermissions.Text = User.Permissions.ToString();
        }
    }
}
