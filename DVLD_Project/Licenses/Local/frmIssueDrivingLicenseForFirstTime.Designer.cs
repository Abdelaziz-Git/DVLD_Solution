namespace DVLD_Project
{
    partial class frmIssueDrivingLicenseForFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicenseForFirstTime));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.txtNotes = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnIssue = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalFees = new Bunifu.UI.WinForms.BunifuLabel();
            this.ucLocalDrivingLicenseApplicationCard1 = new DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls.ucLocalDrivingLicenseApplicationCard();
            this.SuspendLayout();
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
            this.txtNotes.IconLeft = global::DVLD_Project.Properties.Resources.Written_test;
            this.txtNotes.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.IconPadding = 14;
            this.txtNotes.IconRight = null;
            this.txtNotes.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(24, 271);
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
            this.txtNotes.PlaceholderText = "Enter notes.....";
            this.txtNotes.ReadOnly = false;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotes.SelectedText = "";
            this.txtNotes.SelectionLength = 0;
            this.txtNotes.SelectionStart = 0;
            this.txtNotes.ShortcutsEnabled = true;
            this.txtNotes.Size = new System.Drawing.Size(1059, 59);
            this.txtNotes.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNotes.TabIndex = 57;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNotes.TextMarginBottom = 0;
            this.txtNotes.TextMarginLeft = 3;
            this.txtNotes.TextMarginTop = 1;
            this.txtNotes.TextPlaceholder = "Enter notes.....";
            this.txtNotes.UseSystemPasswordChar = false;
            this.txtNotes.WordWrap = true;
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
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
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
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClose.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeft = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
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
            this.btnClose.Location = new System.Drawing.Point(736, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 49;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.BorderRadius = 49;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.BorderRadius = 49;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.BorderRadius = 49;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(150, 49);
            this.btnClose.TabIndex = 59;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.AllowAnimations = true;
            this.btnIssue.AllowMouseEffects = true;
            this.btnIssue.AllowToggling = false;
            this.btnIssue.AnimationSpeed = 200;
            this.btnIssue.AutoGenerateColors = false;
            this.btnIssue.AutoRoundBorders = true;
            this.btnIssue.AutoSizeLeftIcon = true;
            this.btnIssue.AutoSizeRightIcon = true;
            this.btnIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnIssue.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIssue.BackgroundImage")));
            this.btnIssue.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIssue.ButtonText = "Issue";
            this.btnIssue.ButtonTextMarginLeft = 0;
            this.btnIssue.ColorContrastOnClick = 45;
            this.btnIssue.ColorContrastOnHover = 45;
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnIssue.CustomizableEdges = borderEdges2;
            this.btnIssue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIssue.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIssue.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnIssue.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnIssue.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.IconLeft = global::DVLD_Project.Properties.Resources.Driving_services_32;
            this.btnIssue.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnIssue.IconMarginLeft = 11;
            this.btnIssue.IconPadding = 8;
            this.btnIssue.IconRight = null;
            this.btnIssue.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIssue.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnIssue.IconSize = 25;
            this.btnIssue.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnIssue.IdleBorderRadius = 0;
            this.btnIssue.IdleBorderThickness = 0;
            this.btnIssue.IdleFillColor = System.Drawing.Color.Empty;
            this.btnIssue.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Driving_services_32;
            this.btnIssue.IdleIconRightImage = null;
            this.btnIssue.IndicateFocus = false;
            this.btnIssue.Location = new System.Drawing.Point(933, 408);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIssue.OnDisabledState.BorderRadius = 49;
            this.btnIssue.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIssue.OnDisabledState.BorderThickness = 1;
            this.btnIssue.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIssue.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIssue.OnDisabledState.IconLeftImage = null;
            this.btnIssue.OnDisabledState.IconRightImage = null;
            this.btnIssue.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnIssue.onHoverState.BorderRadius = 49;
            this.btnIssue.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIssue.onHoverState.BorderThickness = 1;
            this.btnIssue.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnIssue.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnIssue.onHoverState.IconLeftImage = null;
            this.btnIssue.onHoverState.IconRightImage = null;
            this.btnIssue.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnIssue.OnIdleState.BorderRadius = 49;
            this.btnIssue.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIssue.OnIdleState.BorderThickness = 1;
            this.btnIssue.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnIssue.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnIssue.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Driving_services_32;
            this.btnIssue.OnIdleState.IconRightImage = null;
            this.btnIssue.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnIssue.OnPressedState.BorderRadius = 49;
            this.btnIssue.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIssue.OnPressedState.BorderThickness = 1;
            this.btnIssue.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnIssue.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnIssue.OnPressedState.IconLeftImage = null;
            this.btnIssue.OnPressedState.IconRightImage = null;
            this.btnIssue.Size = new System.Drawing.Size(150, 49);
            this.btnIssue.TabIndex = 58;
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIssue.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIssue.TextMarginLeft = 0;
            this.btnIssue.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIssue.UseDefaultRadiusAndThickness = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bunifuLabel1.Location = new System.Drawing.Point(406, 360);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(91, 25);
            this.bunifuLabel1.TabIndex = 60;
            this.bunifuLabel1.Text = "Total Fees:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AllowParentOverrides = false;
            this.lblTotalFees.AutoEllipsis = false;
            this.lblTotalFees.CursorType = null;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalFees.Location = new System.Drawing.Point(512, 360);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalFees.Size = new System.Drawing.Size(54, 25);
            this.lblTotalFees.TabIndex = 61;
            this.lblTotalFees.Text = "0.00 $";
            this.lblTotalFees.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalFees.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ucLocalDrivingLicenseApplicationCard1
            // 
            this.ucLocalDrivingLicenseApplicationCard1.BackColor = System.Drawing.Color.White;
            this.ucLocalDrivingLicenseApplicationCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucLocalDrivingLicenseApplicationCard1.Location = new System.Drawing.Point(0, 0);
            this.ucLocalDrivingLicenseApplicationCard1.Name = "ucLocalDrivingLicenseApplicationCard1";
            this.ucLocalDrivingLicenseApplicationCard1.Size = new System.Drawing.Size(1106, 265);
            this.ucLocalDrivingLicenseApplicationCard1.TabIndex = 0;
            // 
            // frmIssueDrivingLicenseForFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 477);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.ucLocalDrivingLicenseApplicationCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDrivingLicenseForFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License (First Time)";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicenseForFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.LocalDrivingLicenseApplications.Controls.ucLocalDrivingLicenseApplicationCard ucLocalDrivingLicenseApplicationCard1;
        private Bunifu.UI.WinForms.BunifuTextBox txtNotes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnIssue;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalFees;
    }
}