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

namespace DVLD_Project.ApplicationsTypes
{
    public partial class frmEditApplicationsTypes: Form
    {
        clsApplicationType _ApplicationType;
        public frmEditApplicationsTypes(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationType = clsApplicationType.Find(ApplicationTypeID);
            if (_ApplicationType == null )
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
            txtFees.Text = "";
        }
        void LoadData()
        {
            if (_ApplicationType != null)
            {
                lblID.Text = _ApplicationType.Id.ToString();
                txtTitle.Text = _ApplicationType.Title;
                txtFees.Text = _ApplicationType.Fees.ToString();
            }
            else
                SetDefaultValues();
        }
        private void frmEditApplicationsTypes_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
        private bool ValidateDataInput()
        {
            if(string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                MessageBox.Show("Title cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            _ApplicationType.Title = txtTitle.Text.Trim();
            if (decimal.TryParse(txtFees.Text, out decimal fees))
            {
                _ApplicationType.Fees = fees;
            }
            else
            {
                MessageBox.Show("The Fees value entered is not valid. Please enter a valid decimal number.", "Invalid Fees", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFees.Focus();
                return;
            }
            if (_ApplicationType.Save())
            {
                MessageBox.Show("The application type data has been saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("An error occurred while saving the application type data. Please try again.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
