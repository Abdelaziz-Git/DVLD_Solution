using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using DVLD_Business1;
using DVLD_Project.Users;

namespace DVLD_Project
{
    public partial class frmMain : Form
    {
        frmLogin _LoginForm;
        public frmMain(frmLogin LoginForm)
        {
            InitializeComponent();
            _LoginForm = LoginForm;
        }

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            tcPagesMain.PageIndex = 0;
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            tcPagesMain.PageIndex = 1;
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _LoginForm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
        }
    }
}
