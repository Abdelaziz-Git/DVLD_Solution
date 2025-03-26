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

namespace DVLD_Project.Users
{
    public partial class frmUserInfo: Form
    {
        private int _UserID = -1;
        private clsUser _User;
        public clsUser User { get { return _User; } }
        public frmUserInfo(int userID)
        {
            if (!clsUser.IsExistByID(userID))
            {
                MessageBox.Show($"User with ID = {userID} not found");
                this.Close();
            }
            InitializeComponent();
            _UserID = userID;
            _User = clsUser.Find(_UserID);
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ucUserInfo1.LoadUserInfo(_UserID);
        }
    }
}
