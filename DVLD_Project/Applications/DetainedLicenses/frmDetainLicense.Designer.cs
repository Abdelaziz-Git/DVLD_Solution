namespace DVLD_Project.Applications.DetainedLicenses
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtFineFees = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetainLicense = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ucDriverLicenseCardWithFilter1 = new DVLD_Project.Licenses.Controls.ucDriverLicenseCardWithFilter();
            this.SuspendLayout();
            // 
            // txtFineFees
            // 
            this.txtFineFees.AcceptsReturn = false;
            this.txtFineFees.AcceptsTab = false;
            this.txtFineFees.AnimationSpeed = 200;
            this.txtFineFees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFineFees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFineFees.AutoSizeHeight = true;
            this.txtFineFees.BackColor = System.Drawing.Color.White;
            this.txtFineFees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFineFees.BackgroundImage")));
            this.txtFineFees.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFineFees.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFineFees.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFineFees.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFineFees.BorderRadius = 10;
            this.txtFineFees.BorderThickness = 1;
            this.txtFineFees.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtFineFees.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFineFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFineFees.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFineFees.DefaultText = "";
            this.txtFineFees.FillColor = System.Drawing.Color.White;
            this.txtFineFees.HideSelection = true;
            this.txtFineFees.IconLeft = null;
            this.txtFineFees.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFineFees.IconPadding = 10;
            this.txtFineFees.IconRight = null;
            this.txtFineFees.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFineFees.Lines = new string[0];
            this.txtFineFees.Location = new System.Drawing.Point(360, 578);
            this.txtFineFees.MaxLength = 32767;
            this.txtFineFees.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFineFees.Modified = false;
            this.txtFineFees.Multiline = false;
            this.txtFineFees.Name = "txtFineFees";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFineFees.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFineFees.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFineFees.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFineFees.OnIdleState = stateProperties4;
            this.txtFineFees.Padding = new System.Windows.Forms.Padding(3);
            this.txtFineFees.PasswordChar = '\0';
            this.txtFineFees.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFineFees.PlaceholderText = "Please enter fine amount";
            this.txtFineFees.ReadOnly = false;
            this.txtFineFees.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFineFees.SelectedText = "";
            this.txtFineFees.SelectionLength = 0;
            this.txtFineFees.SelectionStart = 0;
            this.txtFineFees.ShortcutsEnabled = true;
            this.txtFineFees.Size = new System.Drawing.Size(187, 43);
            this.txtFineFees.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtFineFees.TabIndex = 21;
            this.txtFineFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFineFees.TextMarginBottom = 0;
            this.txtFineFees.TextMarginLeft = 3;
            this.txtFineFees.TextMarginTop = 1;
            this.txtFineFees.TextPlaceholder = "Please enter fine amount";
            this.txtFineFees.UseSystemPasswordChar = false;
            this.txtFineFees.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(265, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fine fees:";
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.AllowAnimations = true;
            this.btnDetainLicense.AllowMouseEffects = true;
            this.btnDetainLicense.AllowToggling = false;
            this.btnDetainLicense.AnimationSpeed = 200;
            this.btnDetainLicense.AutoGenerateColors = false;
            this.btnDetainLicense.AutoRoundBorders = true;
            this.btnDetainLicense.AutoSizeLeftIcon = true;
            this.btnDetainLicense.AutoSizeRightIcon = true;
            this.btnDetainLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnDetainLicense.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDetainLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetainLicense.BackgroundImage")));
            this.btnDetainLicense.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDetainLicense.ButtonText = "Detain";
            this.btnDetainLicense.ButtonTextMarginLeft = 0;
            this.btnDetainLicense.ColorContrastOnClick = 45;
            this.btnDetainLicense.ColorContrastOnHover = 45;
            this.btnDetainLicense.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDetainLicense.CustomizableEdges = borderEdges1;
            this.btnDetainLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetainLicense.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDetainLicense.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDetainLicense.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDetainLicense.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDetainLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.IconLeft = global::DVLD_Project.Properties.Resources.Police_32;
            this.btnDetainLicense.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDetainLicense.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDetainLicense.IconMarginLeft = 11;
            this.btnDetainLicense.IconPadding = 5;
            this.btnDetainLicense.IconRight = null;
            this.btnDetainLicense.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetainLicense.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDetainLicense.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDetainLicense.IconSize = 25;
            this.btnDetainLicense.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDetainLicense.IdleBorderRadius = 0;
            this.btnDetainLicense.IdleBorderThickness = 0;
            this.btnDetainLicense.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDetainLicense.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Police_32;
            this.btnDetainLicense.IdleIconRightImage = null;
            this.btnDetainLicense.IndicateFocus = false;
            this.btnDetainLicense.Location = new System.Drawing.Point(726, 672);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDetainLicense.OnDisabledState.BorderRadius = 39;
            this.btnDetainLicense.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDetainLicense.OnDisabledState.BorderThickness = 1;
            this.btnDetainLicense.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDetainLicense.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDetainLicense.OnDisabledState.IconLeftImage = null;
            this.btnDetainLicense.OnDisabledState.IconRightImage = null;
            this.btnDetainLicense.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDetainLicense.onHoverState.BorderRadius = 39;
            this.btnDetainLicense.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDetainLicense.onHoverState.BorderThickness = 1;
            this.btnDetainLicense.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDetainLicense.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.onHoverState.IconLeftImage = null;
            this.btnDetainLicense.onHoverState.IconRightImage = null;
            this.btnDetainLicense.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDetainLicense.OnIdleState.BorderRadius = 39;
            this.btnDetainLicense.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDetainLicense.OnIdleState.BorderThickness = 1;
            this.btnDetainLicense.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDetainLicense.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Police_32;
            this.btnDetainLicense.OnIdleState.IconRightImage = null;
            this.btnDetainLicense.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDetainLicense.OnPressedState.BorderRadius = 39;
            this.btnDetainLicense.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDetainLicense.OnPressedState.BorderThickness = 1;
            this.btnDetainLicense.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDetainLicense.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.OnPressedState.IconLeftImage = null;
            this.btnDetainLicense.OnPressedState.IconRightImage = null;
            this.btnDetainLicense.Size = new System.Drawing.Size(150, 39);
            this.btnDetainLicense.TabIndex = 14;
            this.btnDetainLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetainLicense.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDetainLicense.TextMarginLeft = 0;
            this.btnDetainLicense.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDetainLicense.UseDefaultRadiusAndThickness = true;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges2;
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
            this.btnClose.Location = new System.Drawing.Point(548, 671);
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
            this.btnClose.TabIndex = 13;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(354, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 32);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Detain License";
            // 
            // ucDriverLicenseCardWithFilter1
            // 
            this.ucDriverLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ucDriverLicenseCardWithFilter1.Location = new System.Drawing.Point(11, 64);
            this.ucDriverLicenseCardWithFilter1.Name = "ucDriverLicenseCardWithFilter1";
            this.ucDriverLicenseCardWithFilter1.Size = new System.Drawing.Size(865, 499);
            this.ucDriverLicenseCardWithFilter1.TabIndex = 11;
            this.ucDriverLicenseCardWithFilter1.OnLicenseSelected += new System.Action<DVLD_Business1.clsLicenses>(this.ucDriverLicenseCardWithFilter1_OnLicenseSelected);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 731);
            this.Controls.Add(this.txtFineFees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ucDriverLicenseCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtFineFees;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDetainLicense;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Licenses.Controls.ucDriverLicenseCardWithFilter ucDriverLicenseCardWithFilter1;
    }
}