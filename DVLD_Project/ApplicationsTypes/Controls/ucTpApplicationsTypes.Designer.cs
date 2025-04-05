namespace DVLD_Project.ApplicationsTypes.Controls
{
    partial class ucTpApplicationsTypes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTpApplicationsTypes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblManageAppTypes = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvApplicationsTypes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsListApplicationsTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pbManageApp = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsTypes)).BeginInit();
            this.cmsListApplicationsTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(409, 465);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(21, 15);
            this.lblNumberOfRecords.TabIndex = 33;
            this.lblNumberOfRecords.Text = "??";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(337, 465);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(66, 15);
            this.lblRecords.TabIndex = 32;
            this.lblRecords.Text = "# Records:";
            // 
            // lblManageAppTypes
            // 
            this.lblManageAppTypes.AllowParentOverrides = false;
            this.lblManageAppTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageAppTypes.AutoEllipsis = false;
            this.lblManageAppTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblManageAppTypes.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblManageAppTypes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAppTypes.ForeColor = System.Drawing.Color.Orange;
            this.lblManageAppTypes.Location = new System.Drawing.Point(377, 137);
            this.lblManageAppTypes.Name = "lblManageAppTypes";
            this.lblManageAppTypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblManageAppTypes.Size = new System.Drawing.Size(315, 32);
            this.lblManageAppTypes.TabIndex = 30;
            this.lblManageAppTypes.Text = "Manage Applications Types";
            this.lblManageAppTypes.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblManageAppTypes.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvApplicationsTypes
            // 
            this.dgvApplicationsTypes.AllowCustomTheming = false;
            this.dgvApplicationsTypes.AllowUserToAddRows = false;
            this.dgvApplicationsTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationsTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicationsTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvApplicationsTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApplicationsTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApplicationsTypes.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvApplicationsTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplicationsTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplicationsTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationsTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicationsTypes.ColumnHeadersHeight = 40;
            this.dgvApplicationsTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmnTitle,
            this.clmnFees});
            this.dgvApplicationsTypes.ContextMenuStrip = this.cmsListApplicationsTypes;
            this.dgvApplicationsTypes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            this.dgvApplicationsTypes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationsTypes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationsTypes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.dgvApplicationsTypes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvApplicationsTypes.CurrentTheme.BackColor = System.Drawing.Color.Orange;
            this.dgvApplicationsTypes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.dgvApplicationsTypes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Orange;
            this.dgvApplicationsTypes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationsTypes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplicationsTypes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.dgvApplicationsTypes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApplicationsTypes.CurrentTheme.Name = null;
            this.dgvApplicationsTypes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dgvApplicationsTypes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvApplicationsTypes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicationsTypes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.dgvApplicationsTypes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplicationsTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplicationsTypes.EnableHeadersVisualStyles = false;
            this.dgvApplicationsTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.dgvApplicationsTypes.HeaderBackColor = System.Drawing.Color.Orange;
            this.dgvApplicationsTypes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvApplicationsTypes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvApplicationsTypes.Location = new System.Drawing.Point(340, 198);
            this.dgvApplicationsTypes.MultiSelect = false;
            this.dgvApplicationsTypes.Name = "dgvApplicationsTypes";
            this.dgvApplicationsTypes.ReadOnly = true;
            this.dgvApplicationsTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationsTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvApplicationsTypes.RowHeadersVisible = false;
            this.dgvApplicationsTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvApplicationsTypes.RowTemplate.Height = 40;
            this.dgvApplicationsTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationsTypes.Size = new System.Drawing.Size(389, 255);
            this.dgvApplicationsTypes.TabIndex = 25;
            this.dgvApplicationsTypes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            // 
            // clmnID
            // 
            this.clmnID.HeaderText = "ID";
            this.clmnID.Name = "clmnID";
            this.clmnID.ReadOnly = true;
            this.clmnID.Width = 50;
            // 
            // clmnTitle
            // 
            this.clmnTitle.HeaderText = "Title";
            this.clmnTitle.Name = "clmnTitle";
            this.clmnTitle.ReadOnly = true;
            this.clmnTitle.Width = 66;
            // 
            // clmnFees
            // 
            this.clmnFees.HeaderText = "Fees";
            this.clmnFees.Name = "clmnFees";
            this.clmnFees.ReadOnly = true;
            this.clmnFees.Width = 67;
            // 
            // cmsListApplicationsTypes
            // 
            this.cmsListApplicationsTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsListApplicationsTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.EditApplicationTypeToolStripMenuItem,
            this.toolStripSeparator2});
            this.cmsListApplicationsTypes.Name = "cmsListPeople";
            this.cmsListApplicationsTypes.Size = new System.Drawing.Size(225, 42);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // EditApplicationTypeToolStripMenuItem
            // 
            this.EditApplicationTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplicationTypeToolStripMenuItem.Name = "EditApplicationTypeToolStripMenuItem";
            this.EditApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.EditApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.EditApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.EditApplicationTypeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // pbManageApp
            // 
            this.pbManageApp.AllowFocused = false;
            this.pbManageApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbManageApp.AutoSizeHeight = true;
            this.pbManageApp.BorderRadius = 0;
            this.pbManageApp.Image = global::DVLD_Project.Properties.Resources.management_Applications;
            this.pbManageApp.IsCircle = true;
            this.pbManageApp.Location = new System.Drawing.Point(476, 8);
            this.pbManageApp.Name = "pbManageApp";
            this.pbManageApp.Size = new System.Drawing.Size(116, 116);
            this.pbManageApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageApp.TabIndex = 34;
            this.pbManageApp.TabStop = false;
            this.pbManageApp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // ucTpApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbManageApp);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblManageAppTypes);
            this.Controls.Add(this.dgvApplicationsTypes);
            this.Name = "ucTpApplicationsTypes";
            this.Size = new System.Drawing.Size(1073, 675);
            this.Load += new System.EventHandler(this.ucTpApplicationsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationsTypes)).EndInit();
            this.cmsListApplicationsTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblRecords;
        private Bunifu.UI.WinForms.BunifuLabel lblManageAppTypes;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvApplicationsTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFees;
        private Bunifu.UI.WinForms.BunifuPictureBox pbManageApp;
        private System.Windows.Forms.ContextMenuStrip cmsListApplicationsTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
