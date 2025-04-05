namespace DVLD_Project
{
    partial class frmMain
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.tcPagesMain = new Bunifu.UI.WinForms.BunifuPages();
            this.tpPeopleList = new System.Windows.Forms.TabPage();
            this.ctrTpPeople1 = new DVLD_Project.ctrTpPeople();
            this.tpUsersList = new System.Windows.Forms.TabPage();
            this.usTpUsers1 = new DVLD_Project.People.Controls.usTpUsers();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.msSettings = new System.Windows.Forms.MenuStrip();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpApplications = new System.Windows.Forms.TabPage();
            this.msApplications = new System.Windows.Forms.MenuStrip();
            this.applicationsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainLeft = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnApplications = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnManageUsers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnManagePeople = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pbCurrentUser = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.testTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcPagesMain.SuspendLayout();
            this.tpPeopleList.SuspendLayout();
            this.tpUsersList.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.msSettings.SuspendLayout();
            this.tpApplications.SuspendLayout();
            this.msApplications.SuspendLayout();
            this.pnlMainLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPagesMain
            // 
            this.tcPagesMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcPagesMain.AllowTransitions = false;
            this.tcPagesMain.Controls.Add(this.tpPeopleList);
            this.tcPagesMain.Controls.Add(this.tpUsersList);
            this.tcPagesMain.Controls.Add(this.tpSettings);
            this.tcPagesMain.Controls.Add(this.tpApplications);
            this.tcPagesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPagesMain.Location = new System.Drawing.Point(217, 0);
            this.tcPagesMain.Multiline = true;
            this.tcPagesMain.Name = "tcPagesMain";
            this.tcPagesMain.Page = this.tpApplications;
            this.tcPagesMain.PageIndex = 3;
            this.tcPagesMain.PageName = "tpApplications";
            this.tcPagesMain.PageTitle = "Applications";
            this.tcPagesMain.SelectedIndex = 0;
            this.tcPagesMain.Size = new System.Drawing.Size(1002, 701);
            this.tcPagesMain.TabIndex = 3;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tcPagesMain.Transition = animation1;
            this.tcPagesMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tpPeopleList
            // 
            this.tpPeopleList.Controls.Add(this.ctrTpPeople1);
            this.tpPeopleList.Location = new System.Drawing.Point(4, 4);
            this.tpPeopleList.Name = "tpPeopleList";
            this.tpPeopleList.Padding = new System.Windows.Forms.Padding(3);
            this.tpPeopleList.Size = new System.Drawing.Size(994, 675);
            this.tpPeopleList.TabIndex = 0;
            this.tpPeopleList.Text = "People";
            this.tpPeopleList.UseVisualStyleBackColor = true;
            // 
            // ctrTpPeople1
            // 
            this.ctrTpPeople1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrTpPeople1.Location = new System.Drawing.Point(3, 3);
            this.ctrTpPeople1.Name = "ctrTpPeople1";
            this.ctrTpPeople1.Size = new System.Drawing.Size(988, 669);
            this.ctrTpPeople1.TabIndex = 0;
            // 
            // tpUsersList
            // 
            this.tpUsersList.Controls.Add(this.usTpUsers1);
            this.tpUsersList.Location = new System.Drawing.Point(4, 4);
            this.tpUsersList.Name = "tpUsersList";
            this.tpUsersList.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsersList.Size = new System.Drawing.Size(994, 675);
            this.tpUsersList.TabIndex = 1;
            this.tpUsersList.Text = "Users";
            this.tpUsersList.UseVisualStyleBackColor = true;
            // 
            // usTpUsers1
            // 
            this.usTpUsers1.BackColor = System.Drawing.Color.White;
            this.usTpUsers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usTpUsers1.Location = new System.Drawing.Point(3, 3);
            this.usTpUsers1.Name = "usTpUsers1";
            this.usTpUsers1.Size = new System.Drawing.Size(988, 669);
            this.usTpUsers1.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.msSettings);
            this.tpSettings.Location = new System.Drawing.Point(4, 4);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(994, 675);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // msSettings
            // 
            this.msSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.msSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.msSettings.Location = new System.Drawing.Point(3, 3);
            this.msSettings.Name = "msSettings";
            this.msSettings.Size = new System.Drawing.Size(988, 48);
            this.msSettings.TabIndex = 0;
            this.msSettings.Text = "menuStrip1";
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.currentUserToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Card_identity_icon_32;
            this.currentUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(146, 44);
            this.currentUserToolStripMenuItem.Text = "Current User";
            this.currentUserToolStripMenuItem.Click += new System.EventHandler(this.currentUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_change_password_40;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(190, 44);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_log_out_40;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(119, 44);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tpApplications
            // 
            this.tpApplications.Controls.Add(this.msApplications);
            this.tpApplications.Location = new System.Drawing.Point(4, 4);
            this.tpApplications.Name = "tpApplications";
            this.tpApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplications.Size = new System.Drawing.Size(994, 675);
            this.tpApplications.TabIndex = 3;
            this.tpApplications.Text = "Applications";
            this.tpApplications.UseVisualStyleBackColor = true;
            // 
            // msApplications
            // 
            this.msApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.msApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsTypesToolStripMenuItem,
            this.testTypesToolStripMenuItem});
            this.msApplications.Location = new System.Drawing.Point(3, 3);
            this.msApplications.Name = "msApplications";
            this.msApplications.Size = new System.Drawing.Size(988, 40);
            this.msApplications.TabIndex = 0;
            this.msApplications.Text = "menuStrip1";
            // 
            // applicationsTypesToolStripMenuItem
            // 
            this.applicationsTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationsTypesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.applicationsTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_applications_Type;
            this.applicationsTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationsTypesToolStripMenuItem.Name = "applicationsTypesToolStripMenuItem";
            this.applicationsTypesToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.applicationsTypesToolStripMenuItem.Text = "Applications types";
            this.applicationsTypesToolStripMenuItem.Click += new System.EventHandler(this.applicationsTypesToolStripMenuItem_Click);
            // 
            // pnlMainLeft
            // 
            this.pnlMainLeft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.pnlMainLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMainLeft.BackgroundImage")));
            this.pnlMainLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(123)))));
            this.pnlMainLeft.BorderRadius = 0;
            this.pnlMainLeft.BorderThickness = 0;
            this.pnlMainLeft.Controls.Add(this.btnApplications);
            this.pnlMainLeft.Controls.Add(this.btnSettings);
            this.pnlMainLeft.Controls.Add(this.btnManageUsers);
            this.pnlMainLeft.Controls.Add(this.lblUsername);
            this.pnlMainLeft.Controls.Add(this.bunifuSeparator1);
            this.pnlMainLeft.Controls.Add(this.btnManagePeople);
            this.pnlMainLeft.Controls.Add(this.pbCurrentUser);
            this.pnlMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLeft.Name = "pnlMainLeft";
            this.pnlMainLeft.ShowBorders = true;
            this.pnlMainLeft.Size = new System.Drawing.Size(217, 701);
            this.pnlMainLeft.TabIndex = 0;
            // 
            // btnApplications
            // 
            this.btnApplications.AllowAnimations = true;
            this.btnApplications.AllowMouseEffects = true;
            this.btnApplications.AllowToggling = false;
            this.btnApplications.AnimationSpeed = 200;
            this.btnApplications.AutoGenerateColors = false;
            this.btnApplications.AutoRoundBorders = true;
            this.btnApplications.AutoSizeLeftIcon = true;
            this.btnApplications.AutoSizeRightIcon = true;
            this.btnApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnApplications.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnApplications.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApplications.BackgroundImage")));
            this.btnApplications.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApplications.ButtonText = "Applications";
            this.btnApplications.ButtonTextMarginLeft = 0;
            this.btnApplications.ColorContrastOnClick = 45;
            this.btnApplications.ColorContrastOnHover = 45;
            this.btnApplications.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnApplications.CustomizableEdges = borderEdges1;
            this.btnApplications.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApplications.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApplications.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnApplications.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnApplications.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.IconLeft = global::DVLD_Project.Properties.Resources.icons8_applications_32;
            this.btnApplications.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnApplications.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnApplications.IconMarginLeft = 11;
            this.btnApplications.IconPadding = 5;
            this.btnApplications.IconRight = null;
            this.btnApplications.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplications.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnApplications.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnApplications.IconSize = 25;
            this.btnApplications.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnApplications.IdleBorderRadius = 0;
            this.btnApplications.IdleBorderThickness = 0;
            this.btnApplications.IdleFillColor = System.Drawing.Color.Empty;
            this.btnApplications.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.icons8_applications_32;
            this.btnApplications.IdleIconRightImage = null;
            this.btnApplications.IndicateFocus = false;
            this.btnApplications.Location = new System.Drawing.Point(0, 163);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApplications.OnDisabledState.BorderRadius = 39;
            this.btnApplications.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApplications.OnDisabledState.BorderThickness = 1;
            this.btnApplications.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApplications.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnApplications.OnDisabledState.IconLeftImage = null;
            this.btnApplications.OnDisabledState.IconRightImage = null;
            this.btnApplications.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnApplications.onHoverState.BorderRadius = 39;
            this.btnApplications.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApplications.onHoverState.BorderThickness = 1;
            this.btnApplications.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnApplications.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnApplications.onHoverState.IconLeftImage = null;
            this.btnApplications.onHoverState.IconRightImage = null;
            this.btnApplications.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnApplications.OnIdleState.BorderRadius = 39;
            this.btnApplications.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApplications.OnIdleState.BorderThickness = 1;
            this.btnApplications.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnApplications.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnApplications.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.icons8_applications_32;
            this.btnApplications.OnIdleState.IconRightImage = null;
            this.btnApplications.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApplications.OnPressedState.BorderRadius = 39;
            this.btnApplications.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnApplications.OnPressedState.BorderThickness = 1;
            this.btnApplications.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnApplications.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnApplications.OnPressedState.IconLeftImage = null;
            this.btnApplications.OnPressedState.IconRightImage = null;
            this.btnApplications.Size = new System.Drawing.Size(217, 39);
            this.btnApplications.TabIndex = 4;
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApplications.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApplications.TextMarginLeft = 0;
            this.btnApplications.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnApplications.UseDefaultRadiusAndThickness = true;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowMouseEffects = true;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AnimationSpeed = 200;
            this.btnSettings.AutoGenerateColors = false;
            this.btnSettings.AutoRoundBorders = true;
            this.btnSettings.AutoSizeLeftIcon = true;
            this.btnSettings.AutoSizeRightIcon = true;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.ButtonTextMarginLeft = 0;
            this.btnSettings.ColorContrastOnClick = 45;
            this.btnSettings.ColorContrastOnHover = 45;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges2;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSettings.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconLeft = global::DVLD_Project.Properties.Resources.icons8_settings_32;
            this.btnSettings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSettings.IconMarginLeft = 11;
            this.btnSettings.IconPadding = 5;
            this.btnSettings.IconRight = null;
            this.btnSettings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSettings.IconSize = 25;
            this.btnSettings.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSettings.IdleBorderRadius = 0;
            this.btnSettings.IdleBorderThickness = 0;
            this.btnSettings.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSettings.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.icons8_settings_32;
            this.btnSettings.IdleIconRightImage = null;
            this.btnSettings.IndicateFocus = false;
            this.btnSettings.Location = new System.Drawing.Point(0, 662);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.OnDisabledState.BorderRadius = 39;
            this.btnSettings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSettings.OnDisabledState.BorderThickness = 1;
            this.btnSettings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSettings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSettings.OnDisabledState.IconLeftImage = null;
            this.btnSettings.OnDisabledState.IconRightImage = null;
            this.btnSettings.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.onHoverState.BorderRadius = 39;
            this.btnSettings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSettings.onHoverState.BorderThickness = 1;
            this.btnSettings.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnSettings.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.onHoverState.IconLeftImage = null;
            this.btnSettings.onHoverState.IconRightImage = null;
            this.btnSettings.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnSettings.OnIdleState.BorderRadius = 39;
            this.btnSettings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSettings.OnIdleState.BorderThickness = 1;
            this.btnSettings.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnSettings.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.icons8_settings_32;
            this.btnSettings.OnIdleState.IconRightImage = null;
            this.btnSettings.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSettings.OnPressedState.BorderRadius = 39;
            this.btnSettings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSettings.OnPressedState.BorderThickness = 1;
            this.btnSettings.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSettings.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnPressedState.IconLeftImage = null;
            this.btnSettings.OnPressedState.IconRightImage = null;
            this.btnSettings.Size = new System.Drawing.Size(217, 39);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.TextMarginLeft = 0;
            this.btnSettings.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSettings.UseDefaultRadiusAndThickness = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.AllowAnimations = true;
            this.btnManageUsers.AllowMouseEffects = true;
            this.btnManageUsers.AllowToggling = false;
            this.btnManageUsers.AnimationSpeed = 200;
            this.btnManageUsers.AutoGenerateColors = false;
            this.btnManageUsers.AutoRoundBorders = true;
            this.btnManageUsers.AutoSizeLeftIcon = true;
            this.btnManageUsers.AutoSizeRightIcon = true;
            this.btnManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.BackgroundImage")));
            this.btnManageUsers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManageUsers.ButtonText = "Users";
            this.btnManageUsers.ButtonTextMarginLeft = 0;
            this.btnManageUsers.ColorContrastOnClick = 45;
            this.btnManageUsers.ColorContrastOnHover = 45;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnManageUsers.CustomizableEdges = borderEdges3;
            this.btnManageUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManageUsers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManageUsers.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnManageUsers.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnManageUsers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.IconLeft = global::DVLD_Project.Properties.Resources.Manage_People_Icon_48;
            this.btnManageUsers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnManageUsers.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnManageUsers.IconMarginLeft = 11;
            this.btnManageUsers.IconPadding = 5;
            this.btnManageUsers.IconRight = null;
            this.btnManageUsers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageUsers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnManageUsers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnManageUsers.IconSize = 25;
            this.btnManageUsers.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnManageUsers.IdleBorderRadius = 0;
            this.btnManageUsers.IdleBorderThickness = 0;
            this.btnManageUsers.IdleFillColor = System.Drawing.Color.Empty;
            this.btnManageUsers.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Manage_People_Icon_48;
            this.btnManageUsers.IdleIconRightImage = null;
            this.btnManageUsers.IndicateFocus = false;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 206);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManageUsers.OnDisabledState.BorderRadius = 39;
            this.btnManageUsers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManageUsers.OnDisabledState.BorderThickness = 1;
            this.btnManageUsers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManageUsers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnManageUsers.OnDisabledState.IconLeftImage = null;
            this.btnManageUsers.OnDisabledState.IconRightImage = null;
            this.btnManageUsers.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnManageUsers.onHoverState.BorderRadius = 39;
            this.btnManageUsers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManageUsers.onHoverState.BorderThickness = 1;
            this.btnManageUsers.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnManageUsers.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.onHoverState.IconLeftImage = null;
            this.btnManageUsers.onHoverState.IconRightImage = null;
            this.btnManageUsers.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnManageUsers.OnIdleState.BorderRadius = 39;
            this.btnManageUsers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManageUsers.OnIdleState.BorderThickness = 1;
            this.btnManageUsers.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnManageUsers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Manage_People_Icon_48;
            this.btnManageUsers.OnIdleState.IconRightImage = null;
            this.btnManageUsers.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnManageUsers.OnPressedState.BorderRadius = 39;
            this.btnManageUsers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManageUsers.OnPressedState.BorderThickness = 1;
            this.btnManageUsers.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnManageUsers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.OnPressedState.IconLeftImage = null;
            this.btnManageUsers.OnPressedState.IconRightImage = null;
            this.btnManageUsers.Size = new System.Drawing.Size(217, 39);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageUsers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManageUsers.TextMarginLeft = 0;
            this.btnManageUsers.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnManageUsers.UseDefaultRadiusAndThickness = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AllowParentOverrides = false;
            this.lblUsername.AutoEllipsis = false;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsername.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(69, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(77, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUsername.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.White;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 102);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(217, 14);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // btnManagePeople
            // 
            this.btnManagePeople.AllowAnimations = true;
            this.btnManagePeople.AllowMouseEffects = true;
            this.btnManagePeople.AllowToggling = false;
            this.btnManagePeople.AnimationSpeed = 200;
            this.btnManagePeople.AutoGenerateColors = false;
            this.btnManagePeople.AutoRoundBorders = true;
            this.btnManagePeople.AutoSizeLeftIcon = true;
            this.btnManagePeople.AutoSizeRightIcon = true;
            this.btnManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.btnManagePeople.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnManagePeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManagePeople.BackgroundImage")));
            this.btnManagePeople.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.ButtonText = "People";
            this.btnManagePeople.ButtonTextMarginLeft = 0;
            this.btnManagePeople.ColorContrastOnClick = 45;
            this.btnManagePeople.ColorContrastOnHover = 45;
            this.btnManagePeople.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnManagePeople.CustomizableEdges = borderEdges4;
            this.btnManagePeople.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManagePeople.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManagePeople.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnManagePeople.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnManagePeople.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnManagePeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePeople.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.IconLeft = global::DVLD_Project.Properties.Resources.People_icon_100;
            this.btnManagePeople.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePeople.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnManagePeople.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnManagePeople.IconMarginLeft = 11;
            this.btnManagePeople.IconPadding = 5;
            this.btnManagePeople.IconRight = null;
            this.btnManagePeople.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManagePeople.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnManagePeople.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnManagePeople.IconSize = 25;
            this.btnManagePeople.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnManagePeople.IdleBorderRadius = 0;
            this.btnManagePeople.IdleBorderThickness = 0;
            this.btnManagePeople.IdleFillColor = System.Drawing.Color.Empty;
            this.btnManagePeople.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.People_icon_100;
            this.btnManagePeople.IdleIconRightImage = null;
            this.btnManagePeople.IndicateFocus = false;
            this.btnManagePeople.Location = new System.Drawing.Point(0, 120);
            this.btnManagePeople.Name = "btnManagePeople";
            this.btnManagePeople.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManagePeople.OnDisabledState.BorderRadius = 39;
            this.btnManagePeople.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.OnDisabledState.BorderThickness = 1;
            this.btnManagePeople.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManagePeople.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnManagePeople.OnDisabledState.IconLeftImage = null;
            this.btnManagePeople.OnDisabledState.IconRightImage = null;
            this.btnManagePeople.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnManagePeople.onHoverState.BorderRadius = 39;
            this.btnManagePeople.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.onHoverState.BorderThickness = 1;
            this.btnManagePeople.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnManagePeople.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.onHoverState.IconLeftImage = null;
            this.btnManagePeople.onHoverState.IconRightImage = null;
            this.btnManagePeople.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnManagePeople.OnIdleState.BorderRadius = 39;
            this.btnManagePeople.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.OnIdleState.BorderThickness = 1;
            this.btnManagePeople.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnManagePeople.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.People_icon_100;
            this.btnManagePeople.OnIdleState.IconRightImage = null;
            this.btnManagePeople.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnManagePeople.OnPressedState.BorderRadius = 39;
            this.btnManagePeople.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.OnPressedState.BorderThickness = 1;
            this.btnManagePeople.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnManagePeople.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.OnPressedState.IconLeftImage = null;
            this.btnManagePeople.OnPressedState.IconRightImage = null;
            this.btnManagePeople.Size = new System.Drawing.Size(217, 39);
            this.btnManagePeople.TabIndex = 0;
            this.btnManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManagePeople.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManagePeople.TextMarginLeft = 0;
            this.btnManagePeople.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnManagePeople.UseDefaultRadiusAndThickness = true;
            this.btnManagePeople.Click += new System.EventHandler(this.btnManagePeople_Click);
            // 
            // pbCurrentUser
            // 
            this.pbCurrentUser.AllowFocused = false;
            this.pbCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCurrentUser.AutoSizeHeight = true;
            this.pbCurrentUser.BorderRadius = 33;
            this.pbCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("pbCurrentUser.Image")));
            this.pbCurrentUser.IsCircle = true;
            this.pbCurrentUser.Location = new System.Drawing.Point(74, 5);
            this.pbCurrentUser.Name = "pbCurrentUser";
            this.pbCurrentUser.Size = new System.Drawing.Size(66, 66);
            this.pbCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurrentUser.TabIndex = 0;
            this.pbCurrentUser.TabStop = false;
            this.pbCurrentUser.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // testTypesToolStripMenuItem
            // 
            this.testTypesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testTypesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.testTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Test_management_32;
            this.testTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.testTypesToolStripMenuItem.Name = "testTypesToolStripMenuItem";
            this.testTypesToolStripMenuItem.Size = new System.Drawing.Size(129, 36);
            this.testTypesToolStripMenuItem.Text = "Test Types";
            this.testTypesToolStripMenuItem.Click += new System.EventHandler(this.testTypesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 701);
            this.Controls.Add(this.tcPagesMain);
            this.Controls.Add(this.pnlMainLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msSettings;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.tcPagesMain.ResumeLayout(false);
            this.tpPeopleList.ResumeLayout(false);
            this.tpUsersList.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.msSettings.ResumeLayout(false);
            this.msSettings.PerformLayout();
            this.tpApplications.ResumeLayout(false);
            this.tpApplications.PerformLayout();
            this.msApplications.ResumeLayout(false);
            this.msApplications.PerformLayout();
            this.pnlMainLeft.ResumeLayout(false);
            this.pnlMainLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMainLeft;
        private Bunifu.UI.WinForms.BunifuPictureBox pbCurrentUser;
        private Bunifu.UI.WinForms.BunifuPages tcPagesMain;
        private System.Windows.Forms.TabPage tpPeopleList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnManagePeople;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lblUsername;
        private ctrTpPeople ctrTpPeople1;
        private System.Windows.Forms.TabPage tpUsersList;
        private People.Controls.usTpUsers usTpUsers1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnManageUsers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSettings;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.MenuStrip msSettings;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnApplications;
        private System.Windows.Forms.TabPage tpApplications;
        private System.Windows.Forms.MenuStrip msApplications;
        private System.Windows.Forms.ToolStripMenuItem applicationsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTypesToolStripMenuItem;
    }
}

