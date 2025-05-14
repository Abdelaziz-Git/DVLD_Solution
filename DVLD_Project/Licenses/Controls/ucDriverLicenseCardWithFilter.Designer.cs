namespace DVLD_Project.Licenses.Controls
{
    partial class ucDriverLicenseCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDriverLicenseCardWithFilter));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.gpFilter = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.btnFind = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtLicenseID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucDriverLicenseCard1 = new DVLD_Project.Licenses.Controls.ucDriverLicenseCard();
            this.gpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFilter
            // 
            this.gpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFilter.BorderColor = System.Drawing.SystemColors.Highlight;
            this.gpFilter.BorderRadius = 10;
            this.gpFilter.BorderThickness = 1;
            this.gpFilter.Controls.Add(this.btnFind);
            this.gpFilter.Controls.Add(this.txtLicenseID);
            this.gpFilter.Controls.Add(this.label1);
            this.gpFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFilter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gpFilter.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gpFilter.LabelIndent = 10;
            this.gpFilter.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.gpFilter.Location = new System.Drawing.Point(3, 3);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(858, 100);
            this.gpFilter.TabIndex = 0;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.ActiveImage = null;
            this.btnFind.AllowAnimations = true;
            this.btnFind.AllowBuffering = false;
            this.btnFind.AllowToggling = false;
            this.btnFind.AllowZooming = true;
            this.btnFind.AllowZoomingOnFocus = false;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFind.ErrorImage")));
            this.btnFind.FadeWhenInactive = false;
            this.btnFind.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFind.Image = global::DVLD_Project.Properties.Resources.icons8_search_32;
            this.btnFind.ImageActive = null;
            this.btnFind.ImageLocation = null;
            this.btnFind.ImageMargin = 20;
            this.btnFind.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFind.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnFind.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFind.InitialImage")));
            this.btnFind.Location = new System.Drawing.Point(625, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Rotation = 0;
            this.btnFind.ShowActiveImage = true;
            this.btnFind.ShowCursorChanges = true;
            this.btnFind.ShowImageBorders = true;
            this.btnFind.ShowSizeMarkers = false;
            this.btnFind.Size = new System.Drawing.Size(50, 50);
            this.btnFind.TabIndex = 2;
            this.btnFind.ToolTipText = "";
            this.btnFind.WaitOnLoad = false;
            this.btnFind.Zoom = 20;
            this.btnFind.ZoomSpeed = 10;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.AcceptsReturn = false;
            this.txtLicenseID.AcceptsTab = false;
            this.txtLicenseID.AnimationSpeed = 200;
            this.txtLicenseID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLicenseID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLicenseID.AutoSizeHeight = true;
            this.txtLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.txtLicenseID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLicenseID.BackgroundImage")));
            this.txtLicenseID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtLicenseID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLicenseID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtLicenseID.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtLicenseID.BorderRadius = 10;
            this.txtLicenseID.BorderThickness = 1;
            this.txtLicenseID.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtLicenseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseID.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtLicenseID.DefaultText = "";
            this.txtLicenseID.FillColor = System.Drawing.Color.White;
            this.txtLicenseID.HideSelection = true;
            this.txtLicenseID.IconLeft = null;
            this.txtLicenseID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseID.IconPadding = 8;
            this.txtLicenseID.IconRight = null;
            this.txtLicenseID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseID.Lines = new string[0];
            this.txtLicenseID.Location = new System.Drawing.Point(168, 36);
            this.txtLicenseID.MaxLength = 32767;
            this.txtLicenseID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLicenseID.Modified = false;
            this.txtLicenseID.Multiline = false;
            this.txtLicenseID.Name = "txtLicenseID";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLicenseID.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLicenseID.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLicenseID.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLicenseID.OnIdleState = stateProperties4;
            this.txtLicenseID.Padding = new System.Windows.Forms.Padding(3);
            this.txtLicenseID.PasswordChar = '\0';
            this.txtLicenseID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLicenseID.PlaceholderText = "Enter License ID...";
            this.txtLicenseID.ReadOnly = false;
            this.txtLicenseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLicenseID.SelectedText = "";
            this.txtLicenseID.SelectionLength = 0;
            this.txtLicenseID.SelectionStart = 0;
            this.txtLicenseID.ShortcutsEnabled = true;
            this.txtLicenseID.Size = new System.Drawing.Size(451, 39);
            this.txtLicenseID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtLicenseID.TabIndex = 1;
            this.txtLicenseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLicenseID.TextMarginBottom = 0;
            this.txtLicenseID.TextMarginLeft = 3;
            this.txtLicenseID.TextMarginTop = 1;
            this.txtLicenseID.TextPlaceholder = "Enter License ID...";
            this.txtLicenseID.UseSystemPasswordChar = false;
            this.txtLicenseID.WordWrap = true;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(75, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            // 
            // ucDriverLicenseCard1
            // 
            this.ucDriverLicenseCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDriverLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ucDriverLicenseCard1.Location = new System.Drawing.Point(3, 109);
            this.ucDriverLicenseCard1.Name = "ucDriverLicenseCard1";
            this.ucDriverLicenseCard1.Size = new System.Drawing.Size(858, 387);
            this.ucDriverLicenseCard1.TabIndex = 1;
            // 
            // ucDriverLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucDriverLicenseCard1);
            this.Controls.Add(this.gpFilter);
            this.Name = "ucDriverLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(865, 499);
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox gpFilter;
        private ucDriverLicenseCard ucDriverLicenseCard1;
        private Bunifu.UI.WinForms.BunifuTextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton btnFind;
    }
}
