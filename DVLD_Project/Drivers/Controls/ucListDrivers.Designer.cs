namespace DVLD_Project.Drivers.Controls
{
    partial class ucListDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucListDrivers));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecords = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtFind = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ddFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvDrivers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.clmnDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnActiveLicenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AllowParentOverrides = false;
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRecords.AutoEllipsis = false;
            this.lblRecords.CursorType = null;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(164, 652);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRecords.Size = new System.Drawing.Size(28, 21);
            this.lblRecords.TabIndex = 16;
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
            this.bunifuLabel1.Location = new System.Drawing.Point(89, 652);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(64, 21);
            this.bunifuLabel1.TabIndex = 15;
            this.bunifuLabel1.Text = "Records:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.txtFind.Location = new System.Drawing.Point(358, 239);
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
            this.txtFind.TabIndex = 14;
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
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.ddFilterBy.ItemTopMargin = 3;
            this.ddFilterBy.Location = new System.Drawing.Point(164, 239);
            this.ddFilterBy.Name = "ddFilterBy";
            this.ddFilterBy.Size = new System.Drawing.Size(188, 32);
            this.ddFilterBy.TabIndex = 13;
            this.ddFilterBy.Text = "None";
            this.ddFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddFilterBy.TextLeftMargin = 5;
            this.ddFilterBy.SelectedIndexChanged += new System.EventHandler(this.ddFilterBy_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(85, 245);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(73, 21);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter By:";
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowCustomTheming = true;
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDrivers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrivers.ColumnHeadersHeight = 40;
            this.dgvDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDriverID,
            this.clmnPersonID,
            this.clmnNationalNo,
            this.clmFullName,
            this.clmnDate,
            this.clmnActiveLicenses});
            this.dgvDrivers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvDrivers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrivers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDrivers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDrivers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDrivers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvDrivers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDrivers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDrivers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrivers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrivers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDrivers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrivers.CurrentTheme.Name = null;
            this.dgvDrivers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrivers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDrivers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDrivers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvDrivers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrivers.EnableHeadersVisualStyles = false;
            this.dgvDrivers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvDrivers.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvDrivers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDrivers.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDrivers.Location = new System.Drawing.Point(89, 281);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrivers.RowHeadersVisible = false;
            this.dgvDrivers.RowTemplate.Height = 40;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(635, 365);
            this.dgvDrivers.TabIndex = 11;
            this.dgvDrivers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // clmnDriverID
            // 
            this.clmnDriverID.HeaderText = "Driver ID";
            this.clmnDriverID.Name = "clmnDriverID";
            this.clmnDriverID.ReadOnly = true;
            this.clmnDriverID.Width = 97;
            // 
            // clmnPersonID
            // 
            this.clmnPersonID.HeaderText = "Person ID";
            this.clmnPersonID.Name = "clmnPersonID";
            this.clmnPersonID.ReadOnly = true;
            this.clmnPersonID.Width = 102;
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
            // clmnDate
            // 
            this.clmnDate.HeaderText = "Date";
            this.clmnDate.Name = "clmnDate";
            this.clmnDate.ReadOnly = true;
            this.clmnDate.Width = 67;
            // 
            // clmnActiveLicenses
            // 
            this.clmnActiveLicenses.HeaderText = "Active Licenses";
            this.clmnActiveLicenses.Name = "clmnActiveLicenses";
            this.clmnActiveLicenses.ReadOnly = true;
            this.clmnActiveLicenses.Width = 144;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.test_drive_128;
            this.pictureBox1.Location = new System.Drawing.Point(349, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(319, 161);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 37);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Mange Drivers";
            // 
            // ucListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.ddFilterBy);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucListDrivers";
            this.Size = new System.Drawing.Size(820, 711);
            this.Load += new System.EventHandler(this.ucListDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblRecords;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFind;
        private Bunifu.UI.WinForms.BunifuDropdown ddFilterBy;
        private System.Windows.Forms.Label lblFilter;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDrivers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnActiveLicenses;
    }
}
