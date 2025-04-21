namespace DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls
{
    partial class ucManageLocalDrivingLicenseApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageLocalDrivingLicenseApplications));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDrivingLicenseApplications = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.clmLDLA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLicenseClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPassedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLDLA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAppDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanceltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulePracticalTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFilter = new System.Windows.Forms.Label();
            this.ddFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblRecords = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddApp = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.txtFind = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicenseApplications)).BeginInit();
            this.cmsLDLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(213, 158);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(419, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Driving License Applications";
            // 
            // dgvDrivingLicenseApplications
            // 
            this.dgvDrivingLicenseApplications.AllowCustomTheming = true;
            this.dgvDrivingLicenseApplications.AllowUserToAddRows = false;
            this.dgvDrivingLicenseApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDrivingLicenseApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrivingLicenseApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDrivingLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDrivingLicenseApplications.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDrivingLicenseApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrivingLicenseApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrivingLicenseApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivingLicenseApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrivingLicenseApplications.ColumnHeadersHeight = 40;
            this.dgvDrivingLicenseApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLDLA_ID,
            this.clmnLicenseClass,
            this.clmnNationalNo,
            this.clmFullName,
            this.clmnApplicationDate,
            this.clmnPassedTests,
            this.clmnStatus});
            this.dgvDrivingLicenseApplications.ContextMenuStrip = this.cmsLDLA;
            this.dgvDrivingLicenseApplications.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDrivingLicenseApplications.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrivingLicenseApplications.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDrivingLicenseApplications.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDrivingLicenseApplications.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDrivingLicenseApplications.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDrivingLicenseApplications.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDrivingLicenseApplications.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDrivingLicenseApplications.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrivingLicenseApplications.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrivingLicenseApplications.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDrivingLicenseApplications.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrivingLicenseApplications.CurrentTheme.Name = null;
            this.dgvDrivingLicenseApplications.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrivingLicenseApplications.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrivingLicenseApplications.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDrivingLicenseApplications.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDrivingLicenseApplications.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrivingLicenseApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrivingLicenseApplications.EnableHeadersVisualStyles = false;
            this.dgvDrivingLicenseApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDrivingLicenseApplications.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDrivingLicenseApplications.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDrivingLicenseApplications.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDrivingLicenseApplications.Location = new System.Drawing.Point(19, 294);
            this.dgvDrivingLicenseApplications.Name = "dgvDrivingLicenseApplications";
            this.dgvDrivingLicenseApplications.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivingLicenseApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrivingLicenseApplications.RowHeadersVisible = false;
            this.dgvDrivingLicenseApplications.RowTemplate.Height = 40;
            this.dgvDrivingLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivingLicenseApplications.Size = new System.Drawing.Size(795, 315);
            this.dgvDrivingLicenseApplications.TabIndex = 2;
            this.dgvDrivingLicenseApplications.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // clmLDLA_ID
            // 
            this.clmLDLA_ID.HeaderText = "LDLA_ID";
            this.clmLDLA_ID.Name = "clmLDLA_ID";
            this.clmLDLA_ID.ReadOnly = true;
            this.clmLDLA_ID.Width = 94;
            // 
            // clmnLicenseClass
            // 
            this.clmnLicenseClass.HeaderText = "License Class";
            this.clmnLicenseClass.Name = "clmnLicenseClass";
            this.clmnLicenseClass.ReadOnly = true;
            this.clmnLicenseClass.Width = 127;
            // 
            // clmnNationalNo
            // 
            this.clmnNationalNo.HeaderText = "National No";
            this.clmnNationalNo.Name = "clmnNationalNo";
            this.clmnNationalNo.ReadOnly = true;
            this.clmnNationalNo.Width = 120;
            // 
            // clmFullName
            // 
            this.clmFullName.HeaderText = "Full Name";
            this.clmFullName.Name = "clmFullName";
            this.clmFullName.ReadOnly = true;
            this.clmFullName.Width = 105;
            // 
            // clmnApplicationDate
            // 
            this.clmnApplicationDate.HeaderText = "Application Date";
            this.clmnApplicationDate.Name = "clmnApplicationDate";
            this.clmnApplicationDate.ReadOnly = true;
            this.clmnApplicationDate.Width = 155;
            // 
            // clmnPassedTests
            // 
            this.clmnPassedTests.HeaderText = "Passed Tests";
            this.clmnPassedTests.Name = "clmnPassedTests";
            this.clmnPassedTests.ReadOnly = true;
            this.clmnPassedTests.Width = 123;
            // 
            // clmnStatus
            // 
            this.clmnStatus.HeaderText = "Status";
            this.clmnStatus.Name = "clmnStatus";
            this.clmnStatus.ReadOnly = true;
            this.clmnStatus.Width = 78;
            // 
            // cmsLDLA
            // 
            this.cmsLDLA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLDLA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewAppToolStripMenuItem,
            this.editAppToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.CanceltoolStripMenuItem,
            this.toolStripSeparator2,
            this.scheduleTestToolStripMenuItem});
            this.cmsLDLA.Name = "cmsListPeople";
            this.cmsLDLA.Size = new System.Drawing.Size(267, 266);
            this.cmsLDLA.Opened += new System.EventHandler(this.cmsLDLA_Opened);
            // 
            // showAppDetailsToolStripMenuItem
            // 
            this.showAppDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_show_details_32;
            this.showAppDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAppDetailsToolStripMenuItem.Name = "showAppDetailsToolStripMenuItem";
            this.showAppDetailsToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.showAppDetailsToolStripMenuItem.Text = "Show Application details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // addNewAppToolStripMenuItem
            // 
            this.addNewAppToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.add_32;
            this.addNewAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewAppToolStripMenuItem.Name = "addNewAppToolStripMenuItem";
            this.addNewAppToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.addNewAppToolStripMenuItem.Text = "Add New Application";
            this.addNewAppToolStripMenuItem.Click += new System.EventHandler(this.addNewAppToolStripMenuItem_Click);
            // 
            // editAppToolStripMenuItem
            // 
            this.editAppToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_text;
            this.editAppToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editAppToolStripMenuItem.Name = "editAppToolStripMenuItem";
            this.editAppToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.editAppToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // CanceltoolStripMenuItem
            // 
            this.CanceltoolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.CanceltoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CanceltoolStripMenuItem.Name = "CanceltoolStripMenuItem";
            this.CanceltoolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.CanceltoolStripMenuItem.Text = "Cancel Application";
            this.CanceltoolStripMenuItem.Click += new System.EventHandler(this.CanceltoolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.schedulePracticalTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_date_32;
            this.scheduleTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(266, 38);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Tests";
            this.scheduleTestToolStripMenuItem.DropDownOpened += new System.EventHandler(this.scheduleTestToolStripMenuItem_DropDownOpened);
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Vision_Test;
            this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Written_test;
            this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // schedulePracticalTestToolStripMenuItem
            // 
            this.schedulePracticalTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.test_drive1;
            this.schedulePracticalTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schedulePracticalTestToolStripMenuItem.Name = "schedulePracticalTestToolStripMenuItem";
            this.schedulePracticalTestToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.schedulePracticalTestToolStripMenuItem.Text = "Schedule Street Test";
            this.schedulePracticalTestToolStripMenuItem.Click += new System.EventHandler(this.schedulePracticalTestToolStripMenuItem_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(15, 258);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(73, 21);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filter By:";
            // 
            // ddFilterBy
            // 
            this.ddFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.ddFilterBy.BackgroundColor = System.Drawing.Color.White;
            this.ddFilterBy.BorderColor = System.Drawing.Color.Silver;
            this.ddFilterBy.BorderRadius = 10;
            this.ddFilterBy.Color = System.Drawing.Color.Silver;
            this.ddFilterBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddFilterBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddFilterBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddFilterBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddFilterBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddFilterBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddFilterBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddFilterBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddFilterBy.FillDropDown = true;
            this.ddFilterBy.FillIndicator = false;
            this.ddFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddFilterBy.ForeColor = System.Drawing.Color.Black;
            this.ddFilterBy.FormattingEnabled = true;
            this.ddFilterBy.Icon = null;
            this.ddFilterBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddFilterBy.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddFilterBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddFilterBy.IndicatorThickness = 2;
            this.ddFilterBy.IsDropdownOpened = false;
            this.ddFilterBy.ItemBackColor = System.Drawing.Color.White;
            this.ddFilterBy.ItemBorderColor = System.Drawing.Color.White;
            this.ddFilterBy.ItemForeColor = System.Drawing.Color.Black;
            this.ddFilterBy.ItemHeight = 26;
            this.ddFilterBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddFilterBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddFilterBy.Items.AddRange(new object[] {
            "None",
            "National No",
            "LDLA_ID",
            "Full Name",
            "Passed Tests",
            "Status"});
            this.ddFilterBy.ItemTopMargin = 3;
            this.ddFilterBy.Location = new System.Drawing.Point(94, 252);
            this.ddFilterBy.Name = "ddFilterBy";
            this.ddFilterBy.Size = new System.Drawing.Size(188, 32);
            this.ddFilterBy.TabIndex = 4;
            this.ddFilterBy.Text = "None";
            this.ddFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddFilterBy.TextLeftMargin = 5;
            this.ddFilterBy.SelectedIndexChanged += new System.EventHandler(this.ddFilterBy_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(19, 620);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(64, 21);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Records:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblRecords
            // 
            this.lblRecords.AllowParentOverrides = false;
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRecords.AutoEllipsis = false;
            this.lblRecords.CursorType = null;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(94, 620);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecords.Size = new System.Drawing.Size(28, 21);
            this.lblRecords.TabIndex = 7;
            this.lblRecords.Text = "????";
            this.lblRecords.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecords.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddApp
            // 
            this.btnAddApp.AllowAnimations = true;
            this.btnAddApp.AllowBorderColorChanges = true;
            this.btnAddApp.AllowMouseEffects = true;
            this.btnAddApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddApp.AnimationSpeed = 200;
            this.btnAddApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnAddApp.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddApp.BorderRadius = 1;
            this.btnAddApp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnAddApp.BorderThickness = 1;
            this.btnAddApp.ColorContrastOnClick = 30;
            this.btnAddApp.ColorContrastOnHover = 30;
            this.btnAddApp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddApp.CustomizableEdges = borderEdges1;
            this.btnAddApp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddApp.Image = global::DVLD_Project.Properties.Resources.add_file__32;
            this.btnAddApp.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnAddApp.Location = new System.Drawing.Point(768, 242);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.RoundBorders = true;
            this.btnAddApp.ShowBorders = true;
            this.btnAddApp.Size = new System.Drawing.Size(46, 46);
            this.btnAddApp.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnAddApp.TabIndex = 8;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // txtFind
            // 
            this.txtFind.AcceptsReturn = false;
            this.txtFind.AcceptsTab = false;
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFind.AnimationSpeed = 200;
            this.txtFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFind.AutoSizeHeight = true;
            this.txtFind.BackColor = System.Drawing.Color.Transparent;
            this.txtFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFind.BackgroundImage")));
            this.txtFind.BorderColorActive = System.Drawing.Color.MidnightBlue;
            this.txtFind.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFind.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFind.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFind.BorderRadius = 10;
            this.txtFind.BorderThickness = 1;
            this.txtFind.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFind.DefaultText = "";
            this.txtFind.FillColor = System.Drawing.Color.White;
            this.txtFind.HideSelection = true;
            this.txtFind.IconLeft = null;
            this.txtFind.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.IconPadding = 10;
            this.txtFind.IconRight = null;
            this.txtFind.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(288, 252);
            this.txtFind.MaxLength = 32767;
            this.txtFind.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFind.Modified = false;
            this.txtFind.Multiline = false;
            this.txtFind.Name = "txtFind";
            stateProperties1.BorderColor = System.Drawing.Color.MidnightBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnIdleState = stateProperties4;
            this.txtFind.Padding = new System.Windows.Forms.Padding(3);
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFind.PlaceholderText = "Enter text";
            this.txtFind.ReadOnly = false;
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.Size = new System.Drawing.Size(194, 32);
            this.txtFind.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFind.TabIndex = 5;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFind.TextMarginBottom = 0;
            this.txtFind.TextMarginLeft = 3;
            this.txtFind.TextMarginTop = 1;
            this.txtFind.TextPlaceholder = "Enter text";
            this.txtFind.UseSystemPasswordChar = false;
            this.txtFind.Visible = false;
            this.txtFind.WordWrap = true;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Manage_Applications_128;
            this.pictureBox1.Location = new System.Drawing.Point(357, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ucManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.ddFilterBy);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvDrivingLicenseApplications);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucManageLocalDrivingLicenseApplications";
            this.Size = new System.Drawing.Size(849, 656);
            this.Load += new System.EventHandler(this.ucManageLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicenseApplications)).EndInit();
            this.cmsLDLA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDrivingLicenseApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLDLA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLicenseClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPassedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStatus;
        private System.Windows.Forms.Label lblFilter;
        private Bunifu.UI.WinForms.BunifuDropdown ddFilterBy;
        private Bunifu.UI.WinForms.BunifuTextBox txtFind;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lblRecords;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnAddApp;
        private System.Windows.Forms.ContextMenuStrip cmsLDLA;
        private System.Windows.Forms.ToolStripMenuItem showAppDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CanceltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulePracticalTestToolStripMenuItem;
    }
}
