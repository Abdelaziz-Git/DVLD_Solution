namespace DVLD_Project.Users
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtCurrentPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtConfirmPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtNewPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnClose2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ucUserInfo1 = new DVLD_Project.Users.Controls.ucUserInfo();
            this.SuspendLayout();
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.AcceptsReturn = false;
            this.txtCurrentPassword.AcceptsTab = false;
            this.txtCurrentPassword.AnimationSpeed = 200;
            this.txtCurrentPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCurrentPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCurrentPassword.AutoSizeHeight = true;
            this.txtCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCurrentPassword.BackgroundImage")));
            this.txtCurrentPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtCurrentPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCurrentPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCurrentPassword.BorderRadius = 15;
            this.txtCurrentPassword.BorderThickness = 1;
            this.txtCurrentPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtCurrentPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.FillColor = System.Drawing.Color.White;
            this.txtCurrentPassword.HideSelection = true;
            this.txtCurrentPassword.IconLeft = global::DVLD_Project.Properties.Resources.icons8_sign_in_form_password_40;
            this.txtCurrentPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.IconPadding = 7;
            this.txtCurrentPassword.IconRight = global::DVLD_Project.Properties.Resources.icons8_show_password_48;
            this.txtCurrentPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtCurrentPassword.Lines = new string[0];
            this.txtCurrentPassword.Location = new System.Drawing.Point(236, 443);
            this.txtCurrentPassword.MaxLength = 32767;
            this.txtCurrentPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCurrentPassword.Modified = false;
            this.txtCurrentPassword.Multiline = false;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCurrentPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCurrentPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCurrentPassword.OnIdleState = stateProperties4;
            this.txtCurrentPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtCurrentPassword.PasswordChar = '\0';
            this.txtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCurrentPassword.PlaceholderText = "Enter Current Password";
            this.txtCurrentPassword.ReadOnly = false;
            this.txtCurrentPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.SelectionLength = 0;
            this.txtCurrentPassword.SelectionStart = 0;
            this.txtCurrentPassword.ShortcutsEnabled = true;
            this.txtCurrentPassword.Size = new System.Drawing.Size(227, 39);
            this.txtCurrentPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCurrentPassword.TabIndex = 12;
            this.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCurrentPassword.TextMarginBottom = 0;
            this.txtCurrentPassword.TextMarginLeft = 3;
            this.txtCurrentPassword.TextMarginTop = 1;
            this.txtCurrentPassword.TextPlaceholder = "Enter Current Password";
            this.txtCurrentPassword.UseSystemPasswordChar = false;
            this.txtCurrentPassword.WordWrap = true;
            this.txtCurrentPassword.TextChange += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtCurrentPassword.OnIconRightClick += new System.EventHandler(this.txtCurrentPassword_OnIconRightClick);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AcceptsReturn = false;
            this.txtConfirmPassword.AcceptsTab = false;
            this.txtConfirmPassword.AnimationSpeed = 200;
            this.txtConfirmPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConfirmPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConfirmPassword.AutoSizeHeight = true;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtConfirmPassword.BackgroundImage")));
            this.txtConfirmPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtConfirmPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtConfirmPassword.BorderRadius = 15;
            this.txtConfirmPassword.BorderThickness = 1;
            this.txtConfirmPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtConfirmPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.FillColor = System.Drawing.Color.White;
            this.txtConfirmPassword.HideSelection = true;
            this.txtConfirmPassword.IconLeft = global::DVLD_Project.Properties.Resources.icons8_sign_in_form_password_40;
            this.txtConfirmPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.IconPadding = 7;
            this.txtConfirmPassword.IconRight = global::DVLD_Project.Properties.Resources.icons8_show_password_48;
            this.txtConfirmPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(236, 551);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtConfirmPassword.Modified = false;
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPassword.OnIdleState = stateProperties8;
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.ReadOnly = false;
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(227, 39);
            this.txtConfirmPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.TextMarginBottom = 0;
            this.txtConfirmPassword.TextMarginLeft = 3;
            this.txtConfirmPassword.TextMarginTop = 1;
            this.txtConfirmPassword.TextPlaceholder = "Confirm Password";
            this.txtConfirmPassword.UseSystemPasswordChar = false;
            this.txtConfirmPassword.WordWrap = true;
            this.txtConfirmPassword.TextChange += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtConfirmPassword.OnIconRightClick += new System.EventHandler(this.txtConfirmPassword_OnIconRightClick);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AcceptsReturn = false;
            this.txtNewPassword.AcceptsTab = false;
            this.txtNewPassword.AnimationSpeed = 200;
            this.txtNewPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNewPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNewPassword.AutoSizeHeight = true;
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNewPassword.BackgroundImage")));
            this.txtNewPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNewPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNewPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNewPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNewPassword.BorderRadius = 15;
            this.txtNewPassword.BorderThickness = 1;
            this.txtNewPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtNewPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.FillColor = System.Drawing.Color.White;
            this.txtNewPassword.HideSelection = true;
            this.txtNewPassword.IconLeft = global::DVLD_Project.Properties.Resources.icons8_sign_in_form_password_40;
            this.txtNewPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.IconPadding = 7;
            this.txtNewPassword.IconRight = global::DVLD_Project.Properties.Resources.icons8_show_password_48;
            this.txtNewPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(236, 497);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNewPassword.Modified = false;
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword.OnIdleState = stateProperties12;
            this.txtNewPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNewPassword.PlaceholderText = "Enter New Password";
            this.txtNewPassword.ReadOnly = false;
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(227, 39);
            this.txtNewPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNewPassword.TabIndex = 15;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword.TextMarginBottom = 0;
            this.txtNewPassword.TextMarginLeft = 3;
            this.txtNewPassword.TextMarginTop = 1;
            this.txtNewPassword.TextPlaceholder = "Enter New Password";
            this.txtNewPassword.UseSystemPasswordChar = false;
            this.txtNewPassword.WordWrap = true;
            this.txtNewPassword.TextChange += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtNewPassword.OnIconRightClick += new System.EventHandler(this.txtNewPassword_OnIconRightClick);
            // 
            // btnClose2
            // 
            this.btnClose2.AllowAnimations = true;
            this.btnClose2.AllowMouseEffects = true;
            this.btnClose2.AllowToggling = false;
            this.btnClose2.AnimationSpeed = 200;
            this.btnClose2.AutoGenerateColors = false;
            this.btnClose2.AutoRoundBorders = true;
            this.btnClose2.AutoSizeLeftIcon = true;
            this.btnClose2.AutoSizeRightIcon = true;
            this.btnClose2.BackColor = System.Drawing.Color.Transparent;
            this.btnClose2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClose2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose2.BackgroundImage")));
            this.btnClose2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose2.ButtonText = "Close";
            this.btnClose2.ButtonTextMarginLeft = 0;
            this.btnClose2.ColorContrastOnClick = 45;
            this.btnClose2.ColorContrastOnHover = 45;
            this.btnClose2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose2.CustomizableEdges = borderEdges1;
            this.btnClose2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose2.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClose2.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClose2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.Color.White;
            this.btnClose2.IconLeft = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose2.IconMarginLeft = 11;
            this.btnClose2.IconPadding = 7;
            this.btnClose2.IconRight = null;
            this.btnClose2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose2.IconSize = 25;
            this.btnClose2.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClose2.IdleBorderRadius = 0;
            this.btnClose2.IdleBorderThickness = 0;
            this.btnClose2.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClose2.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose2.IdleIconRightImage = null;
            this.btnClose2.IndicateFocus = false;
            this.btnClose2.Location = new System.Drawing.Point(114, 617);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose2.OnDisabledState.BorderRadius = 47;
            this.btnClose2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose2.OnDisabledState.BorderThickness = 1;
            this.btnClose2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose2.OnDisabledState.IconLeftImage = null;
            this.btnClose2.OnDisabledState.IconRightImage = null;
            this.btnClose2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose2.onHoverState.BorderRadius = 47;
            this.btnClose2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose2.onHoverState.BorderThickness = 1;
            this.btnClose2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose2.onHoverState.IconLeftImage = null;
            this.btnClose2.onHoverState.IconRightImage = null;
            this.btnClose2.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.btnClose2.OnIdleState.BorderRadius = 47;
            this.btnClose2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose2.OnIdleState.BorderThickness = 1;
            this.btnClose2.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnClose2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose2.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose2.OnIdleState.IconRightImage = null;
            this.btnClose2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose2.OnPressedState.BorderRadius = 47;
            this.btnClose2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose2.OnPressedState.BorderThickness = 1;
            this.btnClose2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose2.OnPressedState.IconLeftImage = null;
            this.btnClose2.OnPressedState.IconRightImage = null;
            this.btnClose2.Size = new System.Drawing.Size(150, 47);
            this.btnClose2.TabIndex = 20;
            this.btnClose2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose2.TextMarginLeft = 0;
            this.btnClose2.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose2.UseDefaultRadiusAndThickness = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = true;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges2;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSave.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeft = global::DVLD_Project.Properties.Resources.icons8_save_32;
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 8;
            this.btnSave.IconRight = null;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 25;
            this.btnSave.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSave.IdleBorderRadius = 0;
            this.btnSave.IdleBorderThickness = 0;
            this.btnSave.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSave.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.icons8_save_32;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(442, 617);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 47;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSave.onHoverState.BorderRadius = 47;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnSave.OnIdleState.BorderRadius = 47;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.Green;
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.icons8_save_32;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSave.OnPressedState.BorderRadius = 47;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(150, 47);
            this.btnSave.TabIndex = 19;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucUserInfo1
            // 
            this.ucUserInfo1.BackColor = System.Drawing.Color.White;
            this.ucUserInfo1.Location = new System.Drawing.Point(0, 10);
            this.ucUserInfo1.Name = "ucUserInfo1";
            this.ucUserInfo1.Size = new System.Drawing.Size(710, 423);
            this.ucUserInfo1.TabIndex = 0;
            this.ucUserInfo1.Load += new System.EventHandler(this.ucUserInfo1_Load);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 688);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.ucUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(10, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucUserInfo ucUserInfo1;
        private Bunifu.UI.WinForms.BunifuTextBox txtCurrentPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtConfirmPassword;
        private Bunifu.UI.WinForms.BunifuTextBox txtNewPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
    }
}