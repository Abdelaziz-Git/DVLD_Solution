namespace DVLD_Project.TestTypes
{
    partial class frmManageTestTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucManageTestTypes1 = new DVLD_Project.TestTypes.Controls.ucManageTestTypes();
            this.SuspendLayout();
            // 
            // ucManageTestTypes1
            // 
            this.ucManageTestTypes1.BackColor = System.Drawing.Color.White;
            this.ucManageTestTypes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManageTestTypes1.Location = new System.Drawing.Point(0, 0);
            this.ucManageTestTypes1.Name = "ucManageTestTypes1";
            this.ucManageTestTypes1.Size = new System.Drawing.Size(863, 588);
            this.ucManageTestTypes1.TabIndex = 0;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 588);
            this.Controls.Add(this.ucManageTestTypes1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageTestTypes";
            this.Text = "frmManageTestTypes";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucManageTestTypes ucManageTestTypes1;
    }
}