namespace DVLD_Project.Applications.RenewLicenseApplications
{
    partial class frmRenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLicense));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRenew = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucDriverLicenseCardWithFilter1 = new DVLD_Project.Licenses.Controls.ucDriverLicenseCardWithFilter();
            this.txtNotes = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(260, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Renew License Application";
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = true;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "Close";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClose.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeft = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 7;
            this.btnClose.IconRight = null;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClose.IdleBorderRadius = 0;
            this.btnClose.IdleBorderThickness = 0;
            this.btnClose.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClose.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(547, 721);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 39;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.onHoverState.BorderRadius = 39;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnClose.OnIdleState.BorderRadius = 39;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.Maroon;
            this.btnClose.OnPressedState.BorderRadius = 39;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.Maroon;
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(150, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.AllowAnimations = true;
            this.btnRenew.AllowMouseEffects = true;
            this.btnRenew.AllowToggling = false;
            this.btnRenew.AnimationSpeed = 200;
            this.btnRenew.AutoGenerateColors = false;
            this.btnRenew.AutoRoundBorders = true;
            this.btnRenew.AutoSizeLeftIcon = true;
            this.btnRenew.AutoSizeRightIcon = true;
            this.btnRenew.BackColor = System.Drawing.Color.Transparent;
            this.btnRenew.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRenew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRenew.BackgroundImage")));
            this.btnRenew.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRenew.ButtonText = "Renew";
            this.btnRenew.ButtonTextMarginLeft = 0;
            this.btnRenew.ColorContrastOnClick = 45;
            this.btnRenew.ColorContrastOnHover = 45;
            this.btnRenew.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRenew.CustomizableEdges = borderEdges2;
            this.btnRenew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRenew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRenew.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnRenew.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnRenew.Enabled = false;
            this.btnRenew.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRenew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.IconLeft = global::DVLD_Project.Properties.Resources.Issue_license_32;
            this.btnRenew.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRenew.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRenew.IconMarginLeft = 11;
            this.btnRenew.IconPadding = 7;
            this.btnRenew.IconRight = null;
            this.btnRenew.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRenew.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRenew.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRenew.IconSize = 25;
            this.btnRenew.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnRenew.IdleBorderRadius = 0;
            this.btnRenew.IdleBorderThickness = 0;
            this.btnRenew.IdleFillColor = System.Drawing.Color.Empty;
            this.btnRenew.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Issue_license_32;
            this.btnRenew.IdleIconRightImage = null;
            this.btnRenew.IndicateFocus = false;
            this.btnRenew.Location = new System.Drawing.Point(725, 722);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRenew.OnDisabledState.BorderRadius = 39;
            this.btnRenew.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRenew.OnDisabledState.BorderThickness = 1;
            this.btnRenew.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRenew.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRenew.OnDisabledState.IconLeftImage = null;
            this.btnRenew.OnDisabledState.IconRightImage = null;
            this.btnRenew.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRenew.onHoverState.BorderRadius = 39;
            this.btnRenew.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRenew.onHoverState.BorderThickness = 1;
            this.btnRenew.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRenew.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRenew.onHoverState.IconLeftImage = null;
            this.btnRenew.onHoverState.IconRightImage = null;
            this.btnRenew.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRenew.OnIdleState.BorderRadius = 39;
            this.btnRenew.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRenew.OnIdleState.BorderThickness = 1;
            this.btnRenew.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRenew.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRenew.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Issue_license_32;
            this.btnRenew.OnIdleState.IconRightImage = null;
            this.btnRenew.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRenew.OnPressedState.BorderRadius = 39;
            this.btnRenew.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRenew.OnPressedState.BorderThickness = 1;
            this.btnRenew.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRenew.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRenew.OnPressedState.IconLeftImage = null;
            this.btnRenew.OnPressedState.IconRightImage = null;
            this.btnRenew.Size = new System.Drawing.Size(150, 39);
            this.btnRenew.TabIndex = 3;
            this.btnRenew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRenew.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRenew.TextMarginLeft = 0;
            this.btnRenew.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRenew.UseDefaultRadiusAndThickness = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(20, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Application fees:";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblApplicationFees.Location = new System.Drawing.Point(160, 636);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(73, 20);
            this.lblApplicationFees.TabIndex = 5;
            this.lblApplicationFees.Text = "00 MAD";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLicenseFees.Location = new System.Drawing.Point(195, 668);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(73, 20);
            this.lblLicenseFees.TabIndex = 7;
            this.lblLicenseFees.Text = "00 MAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(20, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Renew License fees:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Green;
            this.lblTotalFees.Location = new System.Drawing.Point(419, 646);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(103, 29);
            this.lblTotalFees.TabIndex = 9;
            this.lblTotalFees.Text = "00 MAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(333, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // ucDriverLicenseCardWithFilter1
            // 
            this.ucDriverLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucDriverLicenseCardWithFilter1.Location = new System.Drawing.Point(10, 70);
            this.ucDriverLicenseCardWithFilter1.Name = "ucDriverLicenseCardWithFilter1";
            this.ucDriverLicenseCardWithFilter1.Size = new System.Drawing.Size(865, 499);
            this.ucDriverLicenseCardWithFilter1.TabIndex = 0;
            this.ucDriverLicenseCardWithFilter1.OnLicenseSelected += new System.Action<DVLD_Business1.clsLicenses>(this.ucDriverLicenseCardWithFilter1_OnLicenseSelected);
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = false;
            this.txtNotes.AcceptsTab = false;
            this.txtNotes.AnimationSpeed = 200;
            this.txtNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNotes.AutoSizeHeight = true;
            this.txtNotes.BackColor = System.Drawing.Color.Transparent;
            this.txtNotes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNotes.BackgroundImage")));
            this.txtNotes.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNotes.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNotes.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNotes.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNotes.BorderRadius = 10;
            this.txtNotes.BorderThickness = 1;
            this.txtNotes.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNotes.DefaultText = "";
            this.txtNotes.FillColor = System.Drawing.Color.White;
            this.txtNotes.HideSelection = true;
            this.txtNotes.IconLeft = null;
            this.txtNotes.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.IconPadding = 10;
            this.txtNotes.IconRight = null;
            this.txtNotes.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(16, 575);
            this.txtNotes.MaxLength = 32767;
            this.txtNotes.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNotes.Modified = false;
            this.txtNotes.Multiline = false;
            this.txtNotes.Name = "txtNotes";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNotes.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnIdleState = stateProperties4;
            this.txtNotes.Padding = new System.Windows.Forms.Padding(3);
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNotes.PlaceholderText = "Enter notes...";
            this.txtNotes.ReadOnly = false;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotes.SelectedText = "";
            this.txtNotes.SelectionLength = 0;
            this.txtNotes.SelectionStart = 0;
            this.txtNotes.ShortcutsEnabled = true;
            this.txtNotes.Size = new System.Drawing.Size(859, 49);
            this.txtNotes.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNotes.TabIndex = 10;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNotes.TextMarginBottom = 0;
            this.txtNotes.TextMarginLeft = 3;
            this.txtNotes.TextMarginTop = 1;
            this.txtNotes.TextPlaceholder = "Enter notes...";
            this.txtNotes.UseSystemPasswordChar = false;
            this.txtNotes.WordWrap = true;
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 773);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLicenseFees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApplicationFees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ucDriverLicenseCardWithFilter1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRenewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew License";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Controls.ucDriverLicenseCardWithFilter ucDriverLicenseCardWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRenew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtNotes;
    }
}