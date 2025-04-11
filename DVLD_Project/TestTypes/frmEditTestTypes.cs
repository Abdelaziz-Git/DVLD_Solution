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

namespace DVLD_Project.TestTypes
{
    public partial class frmEditTestTypes: Form
    {
        clsTestTypes _TestTypes;
        public frmEditTestTypes(int TestTypesID)
        {
            InitializeComponent();
            _TestTypes = clsTestTypes.Find(TestTypesID);
            if (_TestTypes == null)
            {
                SetDefaultValues();
                return;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetDefaultValues()
        {
            lblID.Text = "[???]";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtFees.Text = "";
        }
        void LoadData()
        {
            if (_TestTypes != null)
            {
                lblID.Text = _TestTypes.Id.ToString();
                txtTitle.Text = _TestTypes.Title;
                txtDescription.Text = _TestTypes.Description;
                txtFees.Text = _TestTypes.Fees.ToString();
            }
            else
                SetDefaultValues();
        }
        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool ValidateDataInput()
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                MessageBox.Show("Description cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                MessageBox.Show("Fees cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys such as backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Allow one decimal point only if it's not the first character
            if (e.KeyChar == '.' && !txtFees.Text.Contains(".") && txtFees.SelectionStart > 0)
            {
                return;
            }

            // If the key pressed is not a digit or a control key, consume the event
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateDataInput())
            {
                return;
            }
            _TestTypes.Title = txtTitle.Text.Trim();
            _TestTypes.Description = txtDescription.Text.Trim();
            if (decimal.TryParse(txtFees.Text, out decimal fees))
            {
                _TestTypes.Fees = fees;
            }
            else
            {
                MessageBox.Show("The Fees value entered is not valid. Please enter a valid decimal number.", "Invalid Fees", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFees.Focus();
                return;
            }
            if (_TestTypes.Save())
            {
                MessageBox.Show("The Test type data has been saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("An error occurred while saving the Test type data. Please try again.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
