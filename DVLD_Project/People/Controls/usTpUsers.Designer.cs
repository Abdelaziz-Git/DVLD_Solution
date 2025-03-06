namespace DVLD_Project.People.Controls
{
    partial class usTpUsers
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usTpUsers));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddPerson = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.lblManagePeople = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clmnImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.clmnAdrress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvUsers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.clmnCountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddFilterBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.cmsListPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
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
            this.btnAddPerson.Location = new System.Drawing.Point(898, 89);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.RoundBorders = false;
            this.btnAddPerson.ShowBorders = false;
            this.btnAddPerson.Size = new System.Drawing.Size(70, 70);
            this.btnAddPerson.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnAddPerson.TabIndex = 21;
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AllowParentOverrides = false;
            this.lblManagePeople.AutoEllipsis = false;
            this.lblManagePeople.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblManagePeople.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblManagePeople.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.Location = new System.Drawing.Point(6, 4);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblManagePeople.Size = new System.Drawing.Size(86, 17);
            this.lblManagePeople.TabIndex = 20;
            this.lblManagePeople.Text = "Manage Users";
            this.lblManagePeople.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblManagePeople.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AcceptsReturn = false;
            this.txtFilterValue.AcceptsTab = false;
            this.txtFilterValue.AnimationSpeed = 200;
            this.txtFilterValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilterValue.AutoSizeHeight = true;
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFilterValue.BackgroundImage")));
            this.txtFilterValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFilterValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFilterValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFilterValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFilterValue.BorderRadius = 5;
            this.txtFilterValue.BorderThickness = 2;
            this.txtFilterValue.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtFilterValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.FillColor = System.Drawing.Color.White;
            this.txtFilterValue.HideSelection = true;
            this.txtFilterValue.IconLeft = null;
            this.txtFilterValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.IconPadding = 10;
            this.txtFilterValue.IconRight = null;
            this.txtFilterValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.Lines = new string[0];
            this.txtFilterValue.Location = new System.Drawing.Point(248, 113);
            this.txtFilterValue.MaxLength = 32767;
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterValue.Modified = false;
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnIdleState = stateProperties4;
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(3);
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterValue.PlaceholderText = "Enter text";
            this.txtFilterValue.ReadOnly = false;
            this.txtFilterValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.SelectionLength = 0;
            this.txtFilterValue.SelectionStart = 0;
            this.txtFilterValue.ShortcutsEnabled = true;
            this.txtFilterValue.Size = new System.Drawing.Size(203, 32);
            this.txtFilterValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFilterValue.TabIndex = 19;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterValue.TextMarginBottom = 0;
            this.txtFilterValue.TextMarginLeft = 3;
            this.txtFilterValue.TextMarginTop = 1;
            this.txtFilterValue.TextPlaceholder = "Enter text";
            this.txtFilterValue.UseSystemPasswordChar = false;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.WordWrap = true;
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_phone_number_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_denied_person_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_Edit_Person_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_add_user_male_32;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addNewPersonToolStripMenuItem.Text = "Add new Person";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_show_details_32;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.showDetailsToolStripMenuItem.Text = "Show details";
            // 
            // cmsListPeople
            // 
            this.cmsListPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsListPeople.Name = "cmsListPeople";
            this.cmsListPeople.Size = new System.Drawing.Size(161, 148);
            // 
            // clmnImagePath
            // 
            this.clmnImagePath.HeaderText = "ImagePath";
            this.clmnImagePath.Name = "clmnImagePath";
            this.clmnImagePath.ReadOnly = true;
            this.clmnImagePath.Visible = false;
            this.clmnImagePath.Width = 112;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::DVLD_Project.Properties.Resources.People_icon_100;
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(448, 4);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(106, 106);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 16;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // clmnAdrress
            // 
            this.clmnAdrress.HeaderText = "Adrress";
            this.clmnAdrress.Name = "clmnAdrress";
            this.clmnAdrress.ReadOnly = true;
            this.clmnAdrress.Width = 90;
            // 
            // clmnCountry
            // 
            this.clmnCountry.HeaderText = "Country";
            this.clmnCountry.Name = "clmnCountry";
            this.clmnCountry.ReadOnly = true;
            this.clmnCountry.Width = 93;
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
            // clmnBirthDate
            // 
            this.clmnBirthDate.HeaderText = "Birth Date";
            this.clmnBirthDate.Name = "clmnBirthDate";
            this.clmnBirthDate.ReadOnly = true;
            this.clmnBirthDate.Width = 107;
            // 
            // clmnGender
            // 
            this.clmnGender.HeaderText = "Gender";
            this.clmnGender.Name = "clmnGender";
            this.clmnGender.ReadOnly = true;
            this.clmnGender.Width = 88;
            // 
            // clmnLastName
            // 
            this.clmnLastName.HeaderText = "LastName";
            this.clmnLastName.Name = "clmnLastName";
            this.clmnLastName.ReadOnly = true;
            this.clmnLastName.Width = 106;
            // 
            // clmnThirdName
            // 
            this.clmnThirdName.HeaderText = "ThirdName";
            this.clmnThirdName.Name = "clmnThirdName";
            this.clmnThirdName.ReadOnly = true;
            this.clmnThirdName.Visible = false;
            this.clmnThirdName.Width = 115;
            // 
            // clmnSecondName
            // 
            this.clmnSecondName.HeaderText = "SecondName";
            this.clmnSecondName.Name = "clmnSecondName";
            this.clmnSecondName.ReadOnly = true;
            this.clmnSecondName.Visible = false;
            this.clmnSecondName.Width = 132;
            // 
            // clmnFirstName
            // 
            this.clmnFirstName.HeaderText = "FirstName";
            this.clmnFirstName.Name = "clmnFirstName";
            this.clmnFirstName.ReadOnly = true;
            this.clmnFirstName.Width = 108;
            // 
            // clmnNationalNo
            // 
            this.clmnNationalNo.HeaderText = "National No";
            this.clmnNationalNo.Name = "clmnNationalNo";
            this.clmnNationalNo.ReadOnly = true;
            this.clmnNationalNo.Width = 121;
            // 
            // clmnPersonID
            // 
            this.clmnPersonID.HeaderText = "PersonID";
            this.clmnPersonID.Name = "clmnPersonID";
            this.clmnPersonID.ReadOnly = true;
            this.clmnPersonID.Width = 99;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(3, 121);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(58, 16);
            this.lblFilterBy.TabIndex = 17;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowCustomTheming = false;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnPersonID,
            this.clmnNationalNo,
            this.clmnFirstName,
            this.clmnSecondName,
            this.clmnThirdName,
            this.clmnLastName,
            this.clmnGender,
            this.clmnBirthDate,
            this.clmnPhone,
            this.clmnEmail,
            this.clmnCountry,
            this.clmnCountryID,
            this.clmnAdrress,
            this.clmnImagePath});
            this.dgvUsers.ContextMenuStrip = this.cmsListPeople;
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvUsers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvUsers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvUsers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvUsers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dgvUsers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.CurrentTheme.Name = null;
            this.dgvUsers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dgvUsers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dgvUsers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dgvUsers.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvUsers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvUsers.HeaderForeColor = System.Drawing.Color.White;
            this.dgvUsers.Location = new System.Drawing.Point(3, 165);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(965, 379);
            this.dgvUsers.TabIndex = 14;
            this.dgvUsers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // clmnCountryID
            // 
            this.clmnCountryID.HeaderText = "CountryID";
            this.clmnCountryID.Name = "clmnCountryID";
            this.clmnCountryID.ReadOnly = true;
            this.clmnCountryID.Visible = false;
            this.clmnCountryID.Width = 109;
            // 
            // ddFilterBy
            // 
            this.ddFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.ddFilterBy.BackgroundColor = System.Drawing.Color.White;
            this.ddFilterBy.BorderColor = System.Drawing.Color.Silver;
            this.ddFilterBy.BorderRadius = 5;
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
            "Person ID",
            "National No",
            "First Name",
            "Last Name",
            "Email",
            "Phone",
            "Address",
            "Gender",
            "Country"});
            this.ddFilterBy.ItemTopMargin = 3;
            this.ddFilterBy.Location = new System.Drawing.Point(67, 113);
            this.ddFilterBy.Name = "ddFilterBy";
            this.ddFilterBy.Size = new System.Drawing.Size(178, 32);
            this.ddFilterBy.TabIndex = 18;
            this.ddFilterBy.Text = "None";
            this.ddFilterBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddFilterBy.TextLeftMargin = 5;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(3, 558);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(66, 15);
            this.lblRecords.TabIndex = 22;
            this.lblRecords.Text = "# Records:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(75, 558);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(21, 15);
            this.lblNumberOfRecords.TabIndex = 23;
            this.lblNumberOfRecords.Text = "??";
            // 
            // usTpUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.ddFilterBy);
            this.Name = "usTpUsers";
            this.Size = new System.Drawing.Size(971, 590);
            this.cmsListPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnAddPerson;
        private Bunifu.UI.WinForms.BunifuLabel lblManagePeople;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterValue;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsListPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnImagePath;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAdrress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPersonID;
        private System.Windows.Forms.Label lblFilterBy;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCountryID;
        private Bunifu.UI.WinForms.BunifuDropdown ddFilterBy;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblNumberOfRecords;
    }
}
