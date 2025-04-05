namespace DVLD_Project.TestTypes.Controls
{
    partial class ucManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageTestTypes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblManageTestTypes = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvTestTypes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pbManageTest = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clmnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageTest)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(264, 485);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(21, 15);
            this.lblNumberOfRecords.TabIndex = 38;
            this.lblNumberOfRecords.Text = "??";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(192, 485);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(66, 15);
            this.lblRecords.TabIndex = 37;
            this.lblRecords.Text = "# Records:";
            // 
            // lblManageTestTypes
            // 
            this.lblManageTestTypes.AllowParentOverrides = false;
            this.lblManageTestTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageTestTypes.AutoEllipsis = false;
            this.lblManageTestTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblManageTestTypes.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageTestTypes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblManageTestTypes.Location = new System.Drawing.Point(408, 157);
            this.lblManageTestTypes.Name = "lblManageTestTypes";
            this.lblManageTestTypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblManageTestTypes.Size = new System.Drawing.Size(219, 32);
            this.lblManageTestTypes.TabIndex = 36;
            this.lblManageTestTypes.Text = "Manage Test Types";
            this.lblManageTestTypes.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblManageTestTypes.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowCustomTheming = false;
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTestTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvTestTypes.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvTestTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTestTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTestTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestTypes.ColumnHeadersHeight = 40;
            this.dgvTestTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnID,
            this.clmnTitle,
            this.clmnDescription,
            this.clmnFees});
            this.dgvTestTypes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvTestTypes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTestTypes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTestTypes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTestTypes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTestTypes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvTestTypes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTestTypes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTestTypes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTestTypes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTestTypes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvTestTypes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTestTypes.CurrentTheme.Name = null;
            this.dgvTestTypes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTestTypes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTestTypes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTestTypes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTestTypes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestTypes.EnableHeadersVisualStyles = false;
            this.dgvTestTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTestTypes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTestTypes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTestTypes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTestTypes.Location = new System.Drawing.Point(195, 216);
            this.dgvTestTypes.MultiSelect = false;
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestTypes.RowHeadersVisible = false;
            this.dgvTestTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvTestTypes.RowTemplate.Height = 40;
            this.dgvTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestTypes.Size = new System.Drawing.Size(644, 255);
            this.dgvTestTypes.TabIndex = 35;
            this.dgvTestTypes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pbManageTest
            // 
            this.pbManageTest.AllowFocused = false;
            this.pbManageTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbManageTest.AutoSizeHeight = true;
            this.pbManageTest.BorderRadius = 0;
            this.pbManageTest.Image = global::DVLD_Project.Properties.Resources.test_management_128;
            this.pbManageTest.IsCircle = true;
            this.pbManageTest.Location = new System.Drawing.Point(459, 26);
            this.pbManageTest.Name = "pbManageTest";
            this.pbManageTest.Size = new System.Drawing.Size(116, 116);
            this.pbManageTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageTest.TabIndex = 39;
            this.pbManageTest.TabStop = false;
            this.pbManageTest.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.EditApplicationTypeToolStripMenuItem,
            this.toolStripSeparator2});
            this.cmsTestTypes.Name = "cmsListPeople";
            this.cmsTestTypes.Size = new System.Drawing.Size(196, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // EditApplicationTypeToolStripMenuItem
            // 
            this.EditApplicationTypeToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Test_management_32;
            this.EditApplicationTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplicationTypeToolStripMenuItem.Name = "EditApplicationTypeToolStripMenuItem";
            this.EditApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.EditApplicationTypeToolStripMenuItem.Text = "Edit Test Types";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // clmnID
            // 
            this.clmnID.HeaderText = "ID";
            this.clmnID.Name = "clmnID";
            this.clmnID.ReadOnly = true;
            this.clmnID.Width = 97;
            // 
            // clmnTitle
            // 
            this.clmnTitle.HeaderText = "Title";
            this.clmnTitle.Name = "clmnTitle";
            this.clmnTitle.ReadOnly = true;
            this.clmnTitle.Width = 150;
            // 
            // clmnDescription
            // 
            this.clmnDescription.HeaderText = "Description";
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.ReadOnly = true;
            this.clmnDescription.Width = 300;
            // 
            // clmnFees
            // 
            this.clmnFees.HeaderText = "Fees";
            this.clmnFees.Name = "clmnFees";
            this.clmnFees.ReadOnly = true;
            this.clmnFees.Width = 97;
            // 
            // ucManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbManageTest);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblManageTestTypes);
            this.Controls.Add(this.dgvTestTypes);
            this.Name = "ucManageTestTypes";
            this.Size = new System.Drawing.Size(1029, 683);
            this.Load += new System.EventHandler(this.ucTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageTest)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pbManageTest;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblRecords;
        private Bunifu.UI.WinForms.BunifuLabel lblManageTestTypes;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFees;
    }
}
