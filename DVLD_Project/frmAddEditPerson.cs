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
    public partial class frmAddEditPerson : Form
    {
        public frmAddEditPerson()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            this.dpBirthDate.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 18, 0, 0, 0));
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMale_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rbMale.Checked)
            {
                pbPerson.Image = Properties.Resources.icons8_male_100;
            }
            else
                pbPerson.Image = Properties.Resources.icons8_female_100;
        }
    }
}
