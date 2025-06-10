namespace DVLD_Project.Applications.DetainedLicenses.Controls
{
    partial class ucManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageDetainedLicenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblRecords = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ddFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvDetainedLicenses = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.clmnDetainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDetainDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFineFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReleaseLicense = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnDetainLicense = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.txtFind = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AllowParentOverrides = false;
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRecords.AutoEllipsis = false;
            this.lblRecords.CursorType = null;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(110, 609);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecords.Size = new System.Drawing.Size(28, 21);
            this.lblRecords.TabIndex = 25;
            this.lblRecords.Text = "????";
            this.lblRecords.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecords.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(35, 609);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(64, 21);
            this.bunifuLabel1.TabIndex = 24;
            this.bunifuLabel1.Text = "Records:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            "License ID",
            "Status",
            "CIN",
            "Name"});
            this.ddFilterBy.ItemTopMargin = 3;
            this.ddFilterBy.Location = new System.Drawing.Point(110, 241);
            this.ddFilterBy.Name = "ddFilterBy";
            this.ddFilterBy.Size = new System.Drawing.Size(188, 32);
            this.ddFilterBy.TabIndex = 22;
            this.ddFilterBy.Text = "None";
            this.ddFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddFilterBy.TextLeftMargin = 5;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(31, 247);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(73, 21);
            this.lblFilter.TabIndex = 21;
            this.lblFilter.Text = "Filter By:";
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowCustomTheming = true;
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDetainedLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetainedLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainedLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicenses.ColumnHeadersHeight = 40;
            this.dgvDetainedLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDetainID,
            this.clmnLicenseID,
            this.clmnDetainDate,
            this.clmnFineFees,
            this.clmnStatus,
            this.clmnReleaseDate,
            this.clmnCIN,
            this.clmnName,
            this.clmnApplicationID});
            this.dgvDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLicenses.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetainedLicenses.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDetainedLicenses.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetainedLicenses.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDetainedLicenses.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.CurrentTheme.Name = null;
            this.dgvDetainedLicenses.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetainedLicenses.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicenses.EnableHeadersVisualStyles = false;
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDetainedLicenses.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDetainedLicenses.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(35, 283);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetainedLicenses.RowHeadersVisible = false;
            this.dgvDetainedLicenses.RowTemplate.Height = 40;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(901, 315);
            this.dgvDetainedLicenses.TabIndex = 20;
            this.dgvDetainedLicenses.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(323, 158);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 37);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Manage detained licenses";
            // 
            // clmnDetainID
            // 
            this.clmnDetainID.HeaderText = "Detain ID";
            this.clmnDetainID.Name = "clmnDetainID";
            this.clmnDetainID.ReadOnly = true;
            // 
            // clmnLicenseID
            // 
            this.clmnLicenseID.HeaderText = "License ID";
            this.clmnLicenseID.Name = "clmnLicenseID";
            this.clmnLicenseID.ReadOnly = true;
            this.clmnLicenseID.Width = 107;
            // 
            // clmnDetainDate
            // 
            this.clmnDetainDate.HeaderText = "Detain date";
            this.clmnDetainDate.Name = "clmnDetainDate";
            this.clmnDetainDate.ReadOnly = true;
            this.clmnDetainDate.Width = 117;
            // 
            // clmnFineFees
            // 
            this.clmnFineFees.HeaderText = "Fine fees";
            this.clmnFineFees.Name = "clmnFineFees";
            this.clmnFineFees.ReadOnly = true;
            this.clmnFineFees.Width = 98;
            // 
            // clmnStatus
            // 
            this.clmnStatus.HeaderText = "Status";
            this.clmnStatus.Name = "clmnStatus";
            this.clmnStatus.ReadOnly = true;
            this.clmnStatus.Width = 78;
            // 
            // clmnReleaseDate
            // 
            this.clmnReleaseDate.HeaderText = "Release date";
            this.clmnReleaseDate.Name = "clmnReleaseDate";
            this.clmnReleaseDate.ReadOnly = true;
            this.clmnReleaseDate.Width = 126;
            // 
            // clmnCIN
            // 
            this.clmnCIN.HeaderText = "CIN";
            this.clmnCIN.Name = "clmnCIN";
            this.clmnCIN.ReadOnly = true;
            this.clmnCIN.Width = 60;
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            this.clmnName.Width = 76;
            // 
            // clmnApplicationID
            // 
            this.clmnApplicationID.HeaderText = "Application ID";
            this.clmnApplicationID.Name = "clmnApplicationID";
            this.clmnApplicationID.ReadOnly = true;
            this.clmnApplicationID.Width = 137;
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.AllowAnimations = true;
            this.btnReleaseLicense.AllowBorderColorChanges = true;
            this.btnReleaseLicense.AllowMouseEffects = true;
            this.btnReleaseLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReleaseLicense.AnimationSpeed = 200;
            this.btnReleaseLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnReleaseLicense.BackgroundColor = System.Drawing.Color.White;
            this.btnReleaseLicense.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReleaseLicense.BorderRadius = 1;
            this.btnReleaseLicense.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnReleaseLicense.BorderThickness = 1;
            this.btnReleaseLicense.ColorContrastOnClick = 30;
            this.btnReleaseLicense.ColorContrastOnHover = 30;
            this.btnReleaseLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReleaseLicense.CustomizableEdges = borderEdges1;
            this.btnReleaseLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReleaseLicense.Image = global::DVLD_Project.Properties.Resources.Release_32;
            this.btnReleaseLicense.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnReleaseLicense.Location = new System.Drawing.Point(801, 226);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.RoundBorders = false;
            this.btnReleaseLicense.ShowBorders = true;
            this.btnReleaseLicense.Size = new System.Drawing.Size(51, 51);
            this.btnReleaseLicense.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnReleaseLicense.TabIndex = 27;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.AllowAnimations = true;
            this.btnDetainLicense.AllowBorderColorChanges = true;
            this.btnDetainLicense.AllowMouseEffects = true;
            this.btnDetainLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetainLicense.AnimationSpeed = 200;
            this.btnDetainLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnDetainLicense.BackgroundColor = System.Drawing.Color.White;
            this.btnDetainLicense.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDetainLicense.BorderRadius = 1;
            this.btnDetainLicense.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnDetainLicense.BorderThickness = 1;
            this.btnDetainLicense.ColorContrastOnClick = 30;
            this.btnDetainLicense.ColorContrastOnHover = 30;
            this.btnDetainLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDetainLicense.CustomizableEdges = borderEdges2;
            this.btnDetainLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetainLicense.Image = global::DVLD_Project.Properties.Resources.Police_32;
            this.btnDetainLicense.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnDetainLicense.Location = new System.Drawing.Point(885, 226);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.RoundBorders = true;
            this.btnDetainLicense.ShowBorders = true;
            this.btnDetainLicense.Size = new System.Drawing.Size(51, 51);
            this.btnDetainLicense.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnDetainLicense.TabIndex = 26;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
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
            this.txtFind.Location = new System.Drawing.Point(304, 241);
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
            this.txtFind.TabIndex = 23;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFind.TextMarginBottom = 0;
            this.txtFind.TextMarginLeft = 3;
            this.txtFind.TextMarginTop = 1;
            this.txtFind.TextPlaceholder = "Enter text";
            this.txtFind.UseSystemPasswordChar = false;
            this.txtFind.Visible = false;
            this.txtFind.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Police_128;
            this.pictureBox1.Location = new System.Drawing.Point(403, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 102);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.drivers_license_32;
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(206, 38);
            this.showLicenseToolStripMenuItem.Text = "Show license";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Release_32;
            this.releaseLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(206, 38);
            this.releaseLicenseToolStripMenuItem.Text = "Release license";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // ucManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReleaseLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.ddFilterBy);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucManageDetainedLicenses";
            this.Size = new System.Drawing.Size(972, 656);
            this.Load += new System.EventHandler(this.ucManageDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnDetainLicense;
        private Bunifu.UI.WinForms.BunifuLabel lblRecords;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFind;
        private Bunifu.UI.WinForms.BunifuDropdown ddFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDetainedLicenses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnReleaseLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDetainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDetainDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFineFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApplicationID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}
