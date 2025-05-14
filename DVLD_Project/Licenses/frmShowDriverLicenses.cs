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

namespace DVLD_Project.Licenses
{
    public partial class frmShowDriverLicenses: Form
    {
        // Properties
        public clsDrivers Driver { get; private set; } 
        public frmShowDriverLicenses(int DriverId)
        {
            Driver = clsDrivers.Find(DriverId);
            if (Driver == null)
            {
                MessageBox.Show("Driver not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            InitializeComponent();

        }


        // Event Handlers
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowDriverLicenses_Load(object sender, EventArgs e)
        {
            if(Driver == null)
            {
                MessageBox.Show("Driver not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ucDriverLicensesHistory1.LoadDriverLicensesHistory(Driver.DriverID);
        }
    }
}
