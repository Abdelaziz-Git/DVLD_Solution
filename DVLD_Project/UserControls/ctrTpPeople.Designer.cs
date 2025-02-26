namespace DVLD_Project
{
    partial class ctrTpPeople
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrTpPeople));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dpdFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvPeople = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.clmnPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAdrress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblManagePeople = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddPerson = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.txtFilterBy = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtNumberOfPeople = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dpdFilterBy
            // 
            this.dpdFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.dpdFilterBy.BackgroundColor = System.Drawing.Color.White;
            this.dpdFilterBy.BorderColor = System.Drawing.Color.Silver;
            this.dpdFilterBy.BorderRadius = 5;
            this.dpdFilterBy.Color = System.Drawing.Color.Silver;
            this.dpdFilterBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dpdFilterBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dpdFilterBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dpdFilterBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dpdFilterBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dpdFilterBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dpdFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dpdFilterBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dpdFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpdFilterBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dpdFilterBy.FillDropDown = true;
            this.dpdFilterBy.FillIndicator = false;
            this.dpdFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dpdFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpdFilterBy.ForeColor = System.Drawing.Color.Black;
            this.dpdFilterBy.FormattingEnabled = true;
            this.dpdFilterBy.Icon = null;
            this.dpdFilterBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dpdFilterBy.IndicatorColor = System.Drawing.Color.DarkGray;
            this.dpdFilterBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dpdFilterBy.IndicatorThickness = 2;
            this.dpdFilterBy.IsDropdownOpened = false;
            this.dpdFilterBy.ItemBackColor = System.Drawing.Color.White;
            this.dpdFilterBy.ItemBorderColor = System.Drawing.Color.White;
            this.dpdFilterBy.ItemForeColor = System.Drawing.Color.Black;
            this.dpdFilterBy.ItemHeight = 26;
            this.dpdFilterBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dpdFilterBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dpdFilterBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "LastName",
            "Email",
            "Phone",
            "Address",
            "Gender",
            "CountryName"});
            this.dpdFilterBy.ItemTopMargin = 3;
            this.dpdFilterBy.Location = new System.Drawing.Point(69, 113);
            this.dpdFilterBy.Name = "dpdFilterBy";
            this.dpdFilterBy.Size = new System.Drawing.Size(178, 32);
            this.dpdFilterBy.TabIndex = 10;
            this.dpdFilterBy.Text = "None";
            this.dpdFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dpdFilterBy.TextLeftMargin = 5;
            this.dpdFilterBy.SelectedIndexChanged += new System.EventHandler(this.dpdFilterBy_SelectedIndexChanged_1);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(5, 121);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(58, 16);
            this.lblFilterBy.TabIndex = 9;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowCustomTheming = false;
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeople.ColumnHeadersHeight = 40;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnPersonID,
            this.clmnNationalNo,
            this.clmnFirstName,
            this.clmnSecondName,
            this.clmnThirdName,
            this.clmnLastName,
            this.clmnEmail,
            this.clmnPhone,
            this.clmnAdrress,
            this.clmnGender,
            this.clmnBirthDate,
            this.clmnCountry,
            this.clmnCountryID,
            this.clmnImagePath});
            this.dgvPeople.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.dgvPeople.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPeople.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPeople.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvPeople.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeople.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvPeople.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvPeople.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvPeople.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPeople.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPeople.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dgvPeople.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeople.CurrentTheme.Name = null;
            this.dgvPeople.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dgvPeople.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPeople.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPeople.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvPeople.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvPeople.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvPeople.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPeople.Location = new System.Drawing.Point(5, 165);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPeople.RowTemplate.Height = 40;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1012, 429);
            this.dgvPeople.TabIndex = 6;
            this.dgvPeople.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // clmnPersonID
            // 
            this.clmnPersonID.HeaderText = "PersonID";
            this.clmnPersonID.Name = "clmnPersonID";
            this.clmnPersonID.ReadOnly = true;
            this.clmnPersonID.Width = 99;
            // 
            // clmnNationalNo
            // 
            this.clmnNationalNo.HeaderText = "National No";
            this.clmnNationalNo.Name = "clmnNationalNo";
            this.clmnNationalNo.ReadOnly = true;
            this.clmnNationalNo.Width = 121;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.HeaderText = "FirstName";
            this.clmnFirstName.Name = "clmnFirstName";
            this.clmnFirstName.ReadOnly = true;
            this.clmnFirstName.Width = 108;
            // 
            // clmnSecondName
            // 
            this.clmnSecondName.HeaderText = "SecondName";
            this.clmnSecondName.Name = "clmnSecondName";
            this.clmnSecondName.ReadOnly = true;
            this.clmnSecondName.Width = 132;
            // 
            // clmnThirdName
            // 
            this.clmnThirdName.HeaderText = "ThirdName";
            this.clmnThirdName.Name = "clmnThirdName";
            this.clmnThirdName.ReadOnly = true;
            this.clmnThirdName.Width = 115;
            // 
            // clmnLastName
            // 
            this.clmnLastName.HeaderText = "LastName";
            this.clmnLastName.Name = "clmnLastName";
            this.clmnLastName.ReadOnly = true;
            this.clmnLastName.Width = 106;
            // 
            // clmnEmail
            // 
            this.clmnEmail.HeaderText = "Email";
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.ReadOnly = true;
            this.clmnEmail.Width = 72;
            // 
            // clmnPhone
            // 
            this.clmnPhone.HeaderText = "Phone";
            this.clmnPhone.Name = "clmnPhone";
            this.clmnPhone.ReadOnly = true;
            this.clmnPhone.Width = 80;
            // 
            // clmnAdrress
            // 
            this.clmnAdrress.HeaderText = "Adrress";
            this.clmnAdrress.Name = "clmnAdrress";
            this.clmnAdrress.ReadOnly = true;
            this.clmnAdrress.Width = 90;
            // 
            // clmnGender
            // 
            this.clmnGender.HeaderText = "Gender";
            this.clmnGender.Name = "clmnGender";
            this.clmnGender.ReadOnly = true;
            this.clmnGender.Width = 88;
            // 
            // clmnBirthDate
            // 
            this.clmnBirthDate.HeaderText = "Birth Date";
            this.clmnBirthDate.Name = "clmnBirthDate";
            this.clmnBirthDate.ReadOnly = true;
            this.clmnBirthDate.Width = 107;
            // 
            // clmnCountry
            // 
            this.clmnCountry.HeaderText = "Country";
            this.clmnCountry.Name = "clmnCountry";
            this.clmnCountry.ReadOnly = true;
            this.clmnCountry.Width = 93;
            // 
            // clmnCountryID
            // 
            this.clmnCountryID.HeaderText = "CountryID";
            this.clmnCountryID.Name = "clmnCountryID";
            this.clmnCountryID.ReadOnly = true;
            this.clmnCountryID.Visible = false;
            this.clmnCountryID.Width = 109;
            // 
            // clmnImagePath
            // 
            this.clmnImagePath.HeaderText = "ImagePath";
            this.clmnImagePath.Name = "clmnImagePath";
            this.clmnImagePath.ReadOnly = true;
            this.clmnImagePath.Width = 112;
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AllowParentOverrides = false;
            this.lblManagePeople.AutoEllipsis = false;
            this.lblManagePeople.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblManagePeople.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblManagePeople.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.Location = new System.Drawing.Point(8, 4);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblManagePeople.Size = new System.Drawing.Size(95, 17);
            this.lblManagePeople.TabIndex = 12;
            this.lblManagePeople.Text = "Manage People";
            this.lblManagePeople.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblManagePeople.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.AllowAnimations = true;
            this.btnAddPerson.AllowBorderColorChanges = true;
            this.btnAddPerson.AllowMouseEffects = true;
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.AnimationSpeed = 200;
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnAddPerson.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPerson.BorderRadius = 1;
            this.btnAddPerson.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnAddPerson.BorderThickness = 1;
            this.btnAddPerson.ColorContrastOnClick = 30;
            this.btnAddPerson.ColorContrastOnHover = 30;
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddPerson.CustomizableEdges = borderEdges1;
            this.btnAddPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPerson.Image = global::DVLD_Project.Properties.Resources.Add_Person_Icon8_96;
            this.btnAddPerson.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnAddPerson.Location = new System.Drawing.Point(939, 92);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.RoundBorders = false;
            this.btnAddPerson.ShowBorders = false;
            this.btnAddPerson.Size = new System.Drawing.Size(70, 70);
            this.btnAddPerson.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnAddPerson.TabIndex = 13;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.AcceptsReturn = false;
            this.txtFilterBy.AcceptsTab = false;
            this.txtFilterBy.AnimationSpeed = 200;
            this.txtFilterBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilterBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilterBy.AutoSizeHeight = true;
            this.txtFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterBy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFilterBy.BackgroundImage")));
            this.txtFilterBy.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFilterBy.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFilterBy.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFilterBy.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFilterBy.BorderRadius = 5;
            this.txtFilterBy.BorderThickness = 2;
            this.txtFilterBy.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtFilterBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFilterBy.DefaultText = "";
            this.txtFilterBy.FillColor = System.Drawing.Color.White;
            this.txtFilterBy.HideSelection = true;
            this.txtFilterBy.IconLeft = null;
            this.txtFilterBy.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.IconPadding = 10;
            this.txtFilterBy.IconRight = null;
            this.txtFilterBy.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterBy.Lines = new string[0];
            this.txtFilterBy.Location = new System.Drawing.Point(250, 113);
            this.txtFilterBy.MaxLength = 32767;
            this.txtFilterBy.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterBy.Modified = false;
            this.txtFilterBy.Multiline = false;
            this.txtFilterBy.Name = "txtFilterBy";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterBy.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterBy.OnIdleState = stateProperties4;
            this.txtFilterBy.Padding = new System.Windows.Forms.Padding(3);
            this.txtFilterBy.PasswordChar = '\0';
            this.txtFilterBy.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterBy.PlaceholderText = "Enter text";
            this.txtFilterBy.ReadOnly = false;
            this.txtFilterBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilterBy.SelectedText = "";
            this.txtFilterBy.SelectionLength = 0;
            this.txtFilterBy.SelectionStart = 0;
            this.txtFilterBy.ShortcutsEnabled = true;
            this.txtFilterBy.Size = new System.Drawing.Size(203, 32);
            this.txtFilterBy.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFilterBy.TabIndex = 11;
            this.txtFilterBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterBy.TextMarginBottom = 0;
            this.txtFilterBy.TextMarginLeft = 3;
            this.txtFilterBy.TextMarginTop = 1;
            this.txtFilterBy.TextPlaceholder = "Enter text";
            this.txtFilterBy.UseSystemPasswordChar = false;
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.WordWrap = true;
            this.txtFilterBy.TextChange += new System.EventHandler(this.txtFilterBy_TextChange_1);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::DVLD_Project.Properties.Resources.People_icon_100;
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(441, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(106, 106);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 8;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.AcceptsReturn = false;
            this.txtNumberOfPeople.AcceptsTab = false;
            this.txtNumberOfPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumberOfPeople.AnimationSpeed = 200;
            this.txtNumberOfPeople.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNumberOfPeople.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNumberOfPeople.AutoSizeHeight = true;
            this.txtNumberOfPeople.BackColor = System.Drawing.Color.White;
            this.txtNumberOfPeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNumberOfPeople.BackgroundImage")));
            this.txtNumberOfPeople.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNumberOfPeople.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNumberOfPeople.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNumberOfPeople.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNumberOfPeople.BorderRadius = 1;
            this.txtNumberOfPeople.BorderThickness = 5;
            this.txtNumberOfPeople.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtNumberOfPeople.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumberOfPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfPeople.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfPeople.DefaultText = "Number of people: 00";
            this.txtNumberOfPeople.FillColor = System.Drawing.Color.White;
            this.txtNumberOfPeople.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfPeople.HideSelection = true;
            this.txtNumberOfPeople.IconLeft = null;
            this.txtNumberOfPeople.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfPeople.IconPadding = 10;
            this.txtNumberOfPeople.IconRight = null;
            this.txtNumberOfPeople.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberOfPeople.Lines = new string[] {
        "Number of people: 00"};
            this.txtNumberOfPeople.Location = new System.Drawing.Point(5, 597);
            this.txtNumberOfPeople.MaxLength = 32767;
            this.txtNumberOfPeople.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNumberOfPeople.Modified = false;
            this.txtNumberOfPeople.Multiline = false;
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumberOfPeople.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNumberOfPeople.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumberOfPeople.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNumberOfPeople.OnIdleState = stateProperties8;
            this.txtNumberOfPeople.Padding = new System.Windows.Forms.Padding(3);
            this.txtNumberOfPeople.PasswordChar = '\0';
            this.txtNumberOfPeople.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNumberOfPeople.PlaceholderText = "";
            this.txtNumberOfPeople.ReadOnly = true;
            this.txtNumberOfPeople.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumberOfPeople.SelectedText = "";
            this.txtNumberOfPeople.SelectionLength = 0;
            this.txtNumberOfPeople.SelectionStart = 20;
            this.txtNumberOfPeople.ShortcutsEnabled = true;
            this.txtNumberOfPeople.Size = new System.Drawing.Size(183, 37);
            this.txtNumberOfPeople.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtNumberOfPeople.TabIndex = 7;
            this.txtNumberOfPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumberOfPeople.TextMarginBottom = 0;
            this.txtNumberOfPeople.TextMarginLeft = 3;
            this.txtNumberOfPeople.TextMarginTop = 1;
            this.txtNumberOfPeople.TextPlaceholder = "";
            this.txtNumberOfPeople.UseSystemPasswordChar = false;
            this.txtNumberOfPeople.WordWrap = true;
            // 
            // ctrTpPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.dpdFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.dgvPeople);
            this.Name = "ctrTpPeople";
            this.Size = new System.Drawing.Size(1023, 640);
            this.Load += new System.EventHandler(this.ctrTpPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtFilterBy;
        private Bunifu.UI.WinForms.BunifuDropdown dpdFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtNumberOfPeople;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAdrress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCountryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnImagePath;
        private Bunifu.UI.WinForms.BunifuLabel lblManagePeople;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnAddPerson;
    }
}
