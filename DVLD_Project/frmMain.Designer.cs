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
            this.tcPagesMain = new Bunifu.UI.WinForms.BunifuPages();
            this.tpPeopleList = new System.Windows.Forms.TabPage();
            this.ctrTpPeople1 = new DVLD_Project.ctrTpPeople();
            this.pnlMainLeft = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblUsername = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnManagePeople = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pbCurrentUser = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.tcPagesMain.SuspendLayout();
            this.tpPeopleList.SuspendLayout();
            this.pnlMainLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPagesMain
            // 
            this.tcPagesMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcPagesMain.AllowTransitions = false;
            this.tcPagesMain.Controls.Add(this.tpPeopleList);
            this.tcPagesMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPagesMain.Location = new System.Drawing.Point(217, 0);
            this.tcPagesMain.Multiline = true;
            this.tcPagesMain.Name = "tcPagesMain";
            this.tcPagesMain.Page = this.tpPeopleList;
            this.tcPagesMain.PageIndex = 0;
            this.tcPagesMain.PageName = "tpPeopleList";
            this.tcPagesMain.PageTitle = "People";
            this.tcPagesMain.SelectedIndex = 0;
            this.tcPagesMain.Size = new System.Drawing.Size(1081, 741);
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
            this.tpPeopleList.Size = new System.Drawing.Size(1073, 715);
            this.tpPeopleList.TabIndex = 0;
            this.tpPeopleList.Text = "People";
            this.tpPeopleList.UseVisualStyleBackColor = true;
            // 
            // ctrTpPeople1
            // 
            this.ctrTpPeople1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrTpPeople1.Location = new System.Drawing.Point(3, 3);
            this.ctrTpPeople1.Name = "ctrTpPeople1";
            this.ctrTpPeople1.Size = new System.Drawing.Size(1067, 709);
            this.ctrTpPeople1.TabIndex = 0;
            // 
            // pnlMainLeft
            // 
            this.pnlMainLeft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.pnlMainLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMainLeft.BackgroundImage")));
            this.pnlMainLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(123)))));
            this.pnlMainLeft.BorderRadius = 0;
            this.pnlMainLeft.BorderThickness = 0;
            this.pnlMainLeft.Controls.Add(this.lblUsername);
            this.pnlMainLeft.Controls.Add(this.bunifuSeparator1);
            this.pnlMainLeft.Controls.Add(this.btnManagePeople);
            this.pnlMainLeft.Controls.Add(this.pbCurrentUser);
            this.pnlMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLeft.Name = "pnlMainLeft";
            this.pnlMainLeft.ShowBorders = true;
            this.pnlMainLeft.Size = new System.Drawing.Size(217, 741);
            this.pnlMainLeft.TabIndex = 0;
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
            this.btnManagePeople.AutoRoundBorders = false;
            this.btnManagePeople.AutoSizeLeftIcon = true;
            this.btnManagePeople.AutoSizeRightIcon = true;
            this.btnManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.btnManagePeople.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnManagePeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManagePeople.BackgroundImage")));
            this.btnManagePeople.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.ButtonText = "Manage People";
            this.btnManagePeople.ButtonTextMarginLeft = 0;
            this.btnManagePeople.ColorContrastOnClick = 45;
            this.btnManagePeople.ColorContrastOnHover = 45;
            this.btnManagePeople.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnManagePeople.CustomizableEdges = borderEdges1;
            this.btnManagePeople.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManagePeople.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManagePeople.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnManagePeople.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnManagePeople.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnManagePeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManagePeople.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.IconLeft = global::DVLD_Project.Properties.Resources.Manage_People_Icon_48;
            this.btnManagePeople.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePeople.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnManagePeople.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnManagePeople.IconMarginLeft = 11;
            this.btnManagePeople.IconPadding = 10;
            this.btnManagePeople.IconRight = null;
            this.btnManagePeople.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManagePeople.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnManagePeople.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnManagePeople.IconSize = 25;
            this.btnManagePeople.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnManagePeople.IdleBorderRadius = 0;
            this.btnManagePeople.IdleBorderThickness = 0;
            this.btnManagePeople.IdleFillColor = System.Drawing.Color.Empty;
            this.btnManagePeople.IdleIconLeftImage = global::DVLD_Project.Properties.Resources.Manage_People_Icon_48;
            this.btnManagePeople.IdleIconRightImage = null;
            this.btnManagePeople.IndicateFocus = false;
            this.btnManagePeople.Location = new System.Drawing.Point(0, 120);
            this.btnManagePeople.Name = "btnManagePeople";
            this.btnManagePeople.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnManagePeople.OnDisabledState.BorderRadius = 1;
            this.btnManagePeople.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.OnDisabledState.BorderThickness = 1;
            this.btnManagePeople.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnManagePeople.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnManagePeople.OnDisabledState.IconLeftImage = null;
            this.btnManagePeople.OnDisabledState.IconRightImage = null;
            this.btnManagePeople.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnManagePeople.onHoverState.BorderRadius = 1;
            this.btnManagePeople.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.onHoverState.BorderThickness = 1;
            this.btnManagePeople.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnManagePeople.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.onHoverState.IconLeftImage = null;
            this.btnManagePeople.onHoverState.IconRightImage = null;
            this.btnManagePeople.OnIdleState.BorderColor = System.Drawing.Color.Gray;
            this.btnManagePeople.OnIdleState.BorderRadius = 1;
            this.btnManagePeople.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnManagePeople.OnIdleState.BorderThickness = 1;
            this.btnManagePeople.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnManagePeople.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnManagePeople.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.Manage_People_Icon_48;
            this.btnManagePeople.OnIdleState.IconRightImage = null;
            this.btnManagePeople.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnManagePeople.OnPressedState.BorderRadius = 1;
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
            this.ClientSize = new System.Drawing.Size(1298, 741);
            this.Controls.Add(this.tcPagesMain);
            this.Controls.Add(this.pnlMainLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tcPagesMain.ResumeLayout(false);
            this.tpPeopleList.ResumeLayout(false);
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
    }
}

