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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.tcMain = new Bunifu.UI.WinForms.BunifuPages();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tcSubMain = new Bunifu.UI.WinForms.BunifuPages();
            this.tpPersons = new System.Windows.Forms.TabPage();
            this.ctrTpPeople2 = new DVLD_Project.ctrTpPeople();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.usTpUsers2 = new DVLD_Project.People.Controls.usTpUsers();
            this.tpLocalDrivingLicenseApplications = new System.Windows.Forms.TabPage();
            this.ucManageLocalDrivingLicenseApplications1 = new DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls.ucManageLocalDrivingLicenseApplications();
            this.msApplications = new System.Windows.Forms.MenuStrip();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intenationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainLeft = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnApplications = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnManageUsers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnManagePeople = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pbCurrentUser = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tcSubMain.SuspendLayout();
            this.tpPersons.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.tpLocalDrivingLicenseApplications.SuspendLayout();
            this.msApplications.SuspendLayout();
            this.pnlMainLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcMain.AllowTransitions = false;
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(217, 0);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.Page = this.tpMain;
            this.tcMain.PageIndex = 0;
            this.tcMain.PageName = "tpMain";
            this.tcMain.PageTitle = "Main";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1002, 701);
            this.tcMain.TabIndex = 3;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.tcMain.Transition = animation2;
            this.tcMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.tcSubMain);
            this.tpMain.Controls.Add(this.msApplications);
            this.tpMain.Location = new System.Drawing.Point(4, 4);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(994, 675);
            this.tpMain.TabIndex = 3;
            this.tpMain.Text = "Main";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // tcSubMain
            // 
            this.tcSubMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcSubMain.AllowTransitions = false;
            this.tcSubMain.Controls.Add(this.tpPersons);
            this.tcSubMain.Controls.Add(this.tpUsers);
            this.tcSubMain.Controls.Add(this.tpLocalDrivingLicenseApplications);
            this.tcSubMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSubMain.Location = new System.Drawing.Point(3, 39);
            this.tcSubMain.Multiline = true;
            this.tcSubMain.Name = "tcSubMain";
            this.tcSubMain.Page = this.tpLocalDrivingLicenseApplications;
            this.tcSubMain.PageIndex = 2;
            this.tcSubMain.PageName = "tpLocalDrivingLicenseApplications";
            this.tcSubMain.PageTitle = "LDLApp";
            this.tcSubMain.SelectedIndex = 0;
            this.tcSubMain.Size = new System.Drawing.Size(988, 633);
            this.tcSubMain.TabIndex = 1;
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
            this.tcSubMain.Transition = animation1;
            this.tcSubMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tpPersons
            // 
            this.tpPersons.Controls.Add(this.ctrTpPeople2);
            this.tpPersons.Location = new System.Drawing.Point(4, 4);
            this.tpPersons.Name = "tpPersons";
            this.tpPersons.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersons.Size = new System.Drawing.Size(980, 607);
            this.tpPersons.TabIndex = 0;
            this.tpPersons.Text = "Persons";
            this.tpPersons.UseVisualStyleBackColor = true;
            // 
            // ctrTpPeople2
            // 
            this.ctrTpPeople2.BackColor = System.Drawing.Color.White;
            this.ctrTpPeople2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrTpPeople2.Location = new System.Drawing.Point(3, 3);
            this.ctrTpPeople2.Name = "ctrTpPeople2";
            this.ctrTpPeople2.Size = new System.Drawing.Size(974, 601);
            this.ctrTpPeople2.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.usTpUsers2);
            this.tpUsers.Location = new System.Drawing.Point(4, 4);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(980, 607);
            this.tpUsers.TabIndex = 1;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // usTpUsers2
            // 
            this.usTpUsers2.BackColor = System.Drawing.Color.White;
            this.usTpUsers2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usTpUsers2.Location = new System.Drawing.Point(3, 3);
            this.usTpUsers2.Name = "usTpUsers2";
            this.usTpUsers2.Size = new System.Drawing.Size(974, 601);
            this.usTpUsers2.TabIndex = 0;
            // 
            // tpLocalDrivingLicenseApplications
            // 
            this.tpLocalDrivingLicenseApplications.Controls.Add(this.ucManageLocalDrivingLicenseApplications1);
            this.tpLocalDrivingLicenseApplications.Location = new System.Drawing.Point(4, 4);
            this.tpLocalDrivingLicenseApplications.Name = "tpLocalDrivingLicenseApplications";
            this.tpLocalDrivingLicenseApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalDrivingLicenseApplications.Size = new System.Drawing.Size(980, 607);
            this.tpLocalDrivingLicenseApplications.TabIndex = 2;
            this.tpLocalDrivingLicenseApplications.Text = "LDLApp";
            this.tpLocalDrivingLicenseApplications.UseVisualStyleBackColor = true;
            // 
            // ucManageLocalDrivingLicenseApplications1
            // 
            this.ucManageLocalDrivingLicenseApplications1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManageLocalDrivingLicenseApplications1.Location = new System.Drawing.Point(3, 3);
            this.ucManageLocalDrivingLicenseApplications1.Name = "ucManageLocalDrivingLicenseApplications1";
            this.ucManageLocalDrivingLicenseApplications1.Size = new System.Drawing.Size(974, 601);
            this.ucManageLocalDrivingLicenseApplications1.TabIndex = 0;
            // 
            // msApplications
            // 
            this.msApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.msApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationsToolStripMenuItem,
            this.drivingLicensesServicesToolStripMenuItem,
            this.applicationsTypesToolStripMenuItem,
            this.testTypesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.msApplications.Location = new System.Drawing.Point(3, 3);
            this.msApplications.Name = "msApplications";
            this.msApplications.Padding = new System.Windows.Forms.Padding(0);
            this.msApplications.Size = new System.Drawing.Size(988, 36);
            this.msApplications.TabIndex = 0;
            this.msApplications.Text = "menuStrip1";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.intenationalLicenseApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Manage_Applications_32;
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(208, 36);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_address_32;
            this.localDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(343, 38);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // intenationalLicenseApplicationsToolStripMenuItem
            // 
            this.intenationalLicenseApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.international_32;
            this.intenationalLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.intenationalLicenseApplicationsToolStripMenuItem.Name = "intenationalLicenseApplicationsToolStripMenuItem";
            this.intenationalLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(343, 38);
            this.intenationalLicenseApplicationsToolStripMenuItem.Text = "Intenational License Applications";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingLicensesServicesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.drivingLicensesServicesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Driving_services_32;
            this.drivingLicensesServicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseToolStripMenuItem,
            this.internationalDrivingLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.drivers_license_32;
            this.newDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(243, 38);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            this.localDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_address_32;
            this.localDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            this.localDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 38);
            this.localDrivingLicenseToolStripMenuItem.Text = "Local Driving License";
            this.localDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseToolStripMenuItem_Click);
            // 
            // internationalDrivingLicenseToolStripMenuItem
            // 
            this.internationalDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.international_32;
            this.internationalDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalDrivingLicenseToolStripMenuItem.Name = "internationalDrivingLicenseToolStripMenuItem";
            this.internationalDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 38);
            this.internationalDrivingLicenseToolStripMenuItem.Text = "International Driving License";
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.AutoToolTip = true;
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem1,
            this.changePasswordToolStripMenuItem1,
            this.logOutToolStripMenuItem1});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.icons8_settings_32;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(180, 0, 0, 0);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // currentUserToolStripMenuItem1
            // 
            this.currentUserToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.person_male_icon_32;
            this.currentUserToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserToolStripMenuItem1.Name = "currentUserToolStripMenuItem1";
            this.currentUserToolStripMenuItem1.Size = new System.Drawing.Size(232, 46);
            this.currentUserToolStripMenuItem1.Text = "Current User";
            this.currentUserToolStripMenuItem1.Click += new System.EventHandler(this.currentUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.icons8_change_password_40;
            this.changePasswordToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(232, 46);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.turn_off_32;
            this.logOutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(232, 46);
            this.logOutToolStripMenuItem1.Text = "Log out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnManageUsers.CustomizableEdges = borderEdges2;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnManagePeople.CustomizableEdges = borderEdges3;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 701);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pnlMainLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.tcSubMain.ResumeLayout(false);
            this.tpPersons.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpLocalDrivingLicenseApplications.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuPages tcMain;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnManagePeople;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lblUsername;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnManageUsers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnApplications;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.MenuStrip msApplications;
        private System.Windows.Forms.ToolStripMenuItem applicationsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intenationalLicenseApplicationsToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuPages tcSubMain;
        private System.Windows.Forms.TabPage tpPersons;
        private System.Windows.Forms.TabPage tpUsers;
        private ctrTpPeople ctrTpPeople2;
        private People.Controls.usTpUsers usTpUsers2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.TabPage tpLocalDrivingLicenseApplications;
        private Applications.LocalDrivingLicenseApplications.Controls.ucManageLocalDrivingLicenseApplications ucManageLocalDrivingLicenseApplications1;
    }
}

