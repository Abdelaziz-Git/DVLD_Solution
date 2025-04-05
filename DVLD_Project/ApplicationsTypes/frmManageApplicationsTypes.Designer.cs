namespace DVLD_Project.ApplicationsTypes
{
    partial class frmManageApplicationsTypes
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
            this.ucTpApplicationsTypes1 = new DVLD_Project.ApplicationsTypes.Controls.ucTpApplicationsTypes();
            this.SuspendLayout();
            // 
            // ucTpApplicationsTypes1
            // 
            this.ucTpApplicationsTypes1.BackColor = System.Drawing.Color.White;
            this.ucTpApplicationsTypes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTpApplicationsTypes1.Location = new System.Drawing.Point(0, 0);
            this.ucTpApplicationsTypes1.Name = "ucTpApplicationsTypes1";
            this.ucTpApplicationsTypes1.Size = new System.Drawing.Size(1062, 613);
            this.ucTpApplicationsTypes1.TabIndex = 0;
            // 
            // frmManageApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 613);
            this.Controls.Add(this.ucTpApplicationsTypes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageApplicationsTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApplicationsTypes";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucTpApplicationsTypes ucTpApplicationsTypes1;
    }
}