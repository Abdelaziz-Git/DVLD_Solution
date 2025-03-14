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
    }
}
