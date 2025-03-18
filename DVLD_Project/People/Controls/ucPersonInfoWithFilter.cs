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
    public partial class ucPersonInfoWithFilter: UserControl
    {
        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } }
        public ucPersonInfoWithFilter()
        {
            InitializeComponent();
        }
        public void SetDefaultValues()
        {
            ddFindBy.SelectedIndex = 0;
            txtFindValue.Text = "";
            _PersonID = -1; 
            ucPersonInfo1.SetDefaultValues();
        }
        public void LoadPersonInfo(int personID)
        {
            _PersonID = personID;
            ddFindBy.SelectedIndex = 1;
            txtFindValue.Text = personID.ToString();
            gbFilter.Enabled = false;
            ucPersonInfo1.LoadPersonInfo(personID);
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _PersonID = clsPerson.Find(NationalNo).ID;
            ddFindBy.SelectedIndex = 0;
            txtFindValue.Text = NationalNo;
            gbFilter.Enabled = false;
            ucPersonInfo1.LoadPersonInfo(NationalNo);
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtFindValue.Text == "")
            {
                MessageBox.Show("Please enter a value to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ddFindBy.SelectedIndex == 0)
            {
                if(clsPerson.IsExist(txtFindValue.Text))
                {
                    ucPersonInfo1.LoadPersonInfo(txtFindValue.Text);
                    _PersonID = ucPersonInfo1.PersonID;
                }
                else
                {
                    ucPersonInfo1.SetDefaultValues();
                    _PersonID = -1;
                    MessageBox.Show("Invalid National No !", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            else if (ddFindBy.SelectedIndex == 1) 
            {
                if (clsPerson.IsExist(Convert.ToInt32(txtFindValue.Text)))
                {
                    ucPersonInfo1.LoadPersonInfo(Convert.ToInt32(txtFindValue.Text));
                    _PersonID = ucPersonInfo1.PersonID;
                }
                else
                {
                    ucPersonInfo1.SetDefaultValues();
                    _PersonID = -1;
                    MessageBox.Show("Invalid Person ID !", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }

        private void ucPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
        }

        private void ddFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddFindBy.SelectedIndex == 0)
            {
                txtFindValue.TextPlaceholder = "Enter National No";
            }
            else if (ddFindBy.SelectedIndex == 1)
            {
                txtFindValue.TextPlaceholder = "Enter Person ID";
            }

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            using(Form frm = new frmAddEditPerson())
            {
                frm.ShowDialog();
            }
        }
    }
}
