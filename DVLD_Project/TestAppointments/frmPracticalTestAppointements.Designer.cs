namespace DVLD_Project.Tests
{
    partial class frmPracticalTestAppointements
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPracticalTestAppointements));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.dgvPracticalTestAppointments = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.clmnAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucLocalDrivingLicenseApplicationCard1 = new DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls.ucLocalDrivingLicenseApplicationCard();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.BtnAddPracticalTestAppointment = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.cmsPracticalTestAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTestAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticalTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.cmsPracticalTestAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPracticalTestAppointments
            // 
            this.dgvPracticalTestAppointments.AllowCustomTheming = true;
            this.dgvPracticalTestAppointments.AllowUserToAddRows = false;
            this.dgvPracticalTestAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPracticalTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPracticalTestAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvPracticalTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPracticalTestAppointments.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvPracticalTestAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPracticalTestAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPracticalTestAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPracticalTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPracticalTestAppointments.ColumnHeadersHeight = 40;
            this.dgvPracticalTestAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnAppointmentID,
            this.clmnAppointmentDate,
            this.clmnPaidFees,
            this.clmnIsLocked});
            this.dgvPracticalTestAppointments.ContextMenuStrip = this.cmsPracticalTestAppointments;
            this.dgvPracticalTestAppointments.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvPracticalTestAppointments.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPracticalTestAppointments.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPracticalTestAppointments.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPracticalTestAppointments.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPracticalTestAppointments.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvPracticalTestAppointments.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPracticalTestAppointments.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvPracticalTestAppointments.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPracticalTestAppointments.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPracticalTestAppointments.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvPracticalTestAppointments.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPracticalTestAppointments.CurrentTheme.Name = null;
            this.dgvPracticalTestAppointments.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPracticalTestAppointments.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPracticalTestAppointments.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPracticalTestAppointments.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPracticalTestAppointments.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPracticalTestAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPracticalTestAppointments.EnableHeadersVisualStyles = false;
            this.dgvPracticalTestAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPracticalTestAppointments.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvPracticalTestAppointments.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPracticalTestAppointments.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPracticalTestAppointments.Location = new System.Drawing.Point(305, 462);
            this.dgvPracticalTestAppointments.Name = "dgvPracticalTestAppointments";
            this.dgvPracticalTestAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPracticalTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPracticalTestAppointments.RowHeadersVisible = false;
            this.dgvPracticalTestAppointments.RowTemplate.Height = 40;
            this.dgvPracticalTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPracticalTestAppointments.Size = new System.Drawing.Size(503, 192);
            this.dgvPracticalTestAppointments.TabIndex = 44;
            this.dgvPracticalTestAppointments.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // clmnAppointmentID
            // 
            this.clmnAppointmentID.HeaderText = "Appointment ID";
            this.clmnAppointmentID.Name = "clmnAppointmentID";
            this.clmnAppointmentID.ReadOnly = true;
            this.clmnAppointmentID.Width = 151;
            // 
            // clmnAppointmentDate
            // 
            this.clmnAppointmentDate.HeaderText = "Appointment Date";
            this.clmnAppointmentDate.Name = "clmnAppointmentDate";
            this.clmnAppointmentDate.ReadOnly = true;
            this.clmnAppointmentDate.Width = 169;
            // 
            // clmnPaidFees
            // 
            this.clmnPaidFees.HeaderText = "Paid Fees";
            this.clmnPaidFees.Name = "clmnPaidFees";
            this.clmnPaidFees.ReadOnly = true;
            this.clmnPaidFees.Width = 101;
            // 
            // clmnIsLocked
            // 
            this.clmnIsLocked.HeaderText = "Is Locked";
            this.clmnIsLocked.Name = "clmnIsLocked";
            this.clmnIsLocked.ReadOnly = true;
            this.clmnIsLocked.Width = 83;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(302, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Appointments";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(453, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Practical Test Appointments";
            // 
            // ucLocalDrivingLicenseApplicationCard1
            // 
            this.ucLocalDrivingLicenseApplicationCard1.BackColor = System.Drawing.Color.White;
            this.ucLocalDrivingLicenseApplicationCard1.Location = new System.Drawing.Point(-5, 123);
            this.ucLocalDrivingLicenseApplicationCard1.Name = "ucLocalDrivingLicenseApplicationCard1";
            this.ucLocalDrivingLicenseApplicationCard1.Size = new System.Drawing.Size(1106, 265);
            this.ucLocalDrivingLicenseApplicationCard1.TabIndex = 46;
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = true;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
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
            this.btnClose.Location = new System.Drawing.Point(479, 670);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 39;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.BorderRadius = 39;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.BorderRadius = 39;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = global::DVLD_Project.Properties.Resources.icons8_cancel_32;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.BorderRadius = 39;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(150, 39);
            this.btnClose.TabIndex = 45;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnAddPracticalTestAppointment
            // 
            this.BtnAddPracticalTestAppointment.ActiveImage = null;
            this.BtnAddPracticalTestAppointment.AllowAnimations = true;
            this.BtnAddPracticalTestAppointment.AllowBuffering = false;
            this.BtnAddPracticalTestAppointment.AllowToggling = false;
            this.BtnAddPracticalTestAppointment.AllowZooming = true;
            this.BtnAddPracticalTestAppointment.AllowZoomingOnFocus = false;
            this.BtnAddPracticalTestAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddPracticalTestAppointment.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddPracticalTestAppointment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAddPracticalTestAppointment.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnAddPracticalTestAppointment.ErrorImage")));
            this.BtnAddPracticalTestAppointment.FadeWhenInactive = false;
            this.BtnAddPracticalTestAppointment.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnAddPracticalTestAppointment.Image = global::DVLD_Project.Properties.Resources.appointment_64;
            this.BtnAddPracticalTestAppointment.ImageActive = null;
            this.BtnAddPracticalTestAppointment.ImageLocation = null;
            this.BtnAddPracticalTestAppointment.ImageMargin = 20;
            this.BtnAddPracticalTestAppointment.ImageSize = new System.Drawing.Size(44, 44);
            this.BtnAddPracticalTestAppointment.ImageZoomSize = new System.Drawing.Size(64, 64);
            this.BtnAddPracticalTestAppointment.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnAddPracticalTestAppointment.InitialImage")));
            this.BtnAddPracticalTestAppointment.Location = new System.Drawing.Point(745, 393);
            this.BtnAddPracticalTestAppointment.Name = "BtnAddPracticalTestAppointment";
            this.BtnAddPracticalTestAppointment.Rotation = 0;
            this.BtnAddPracticalTestAppointment.ShowActiveImage = true;
            this.BtnAddPracticalTestAppointment.ShowCursorChanges = true;
            this.BtnAddPracticalTestAppointment.ShowImageBorders = true;
            this.BtnAddPracticalTestAppointment.ShowSizeMarkers = false;
            this.BtnAddPracticalTestAppointment.Size = new System.Drawing.Size(64, 64);
            this.BtnAddPracticalTestAppointment.TabIndex = 43;
            this.BtnAddPracticalTestAppointment.ToolTipText = "Click to add vision test appointment.";
            this.BtnAddPracticalTestAppointment.WaitOnLoad = false;
            this.BtnAddPracticalTestAppointment.Zoom = 20;
            this.BtnAddPracticalTestAppointment.ZoomSpeed = 10;
            this.BtnAddPracticalTestAppointment.Click += new System.EventHandler(this.BtnAddPracticalTestAppointment_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::DVLD_Project.Properties.Resources.test_drive_128;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(539, 7);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 40;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // cmsPracticalTestAppointments
            // 
            this.cmsPracticalTestAppointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsPracticalTestAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.AddTestAppointmentToolStripMenuItem,
            this.editAppointmentToolStripMenuItem,
            this.toolStripSeparator2,
            this.takeTestToolStripMenuItem});
            this.cmsPracticalTestAppointments.Name = "cmsListPeople";
            this.cmsPracticalTestAppointments.Size = new System.Drawing.Size(252, 130);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // AddTestAppointmentToolStripMenuItem
            // 
            this.AddTestAppointmentToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.add_32;
            this.AddTestAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddTestAppointmentToolStripMenuItem.Name = "AddTestAppointmentToolStripMenuItem";
            this.AddTestAppointmentToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.AddTestAppointmentToolStripMenuItem.Text = "Add Test Appointment";
            this.AddTestAppointmentToolStripMenuItem.Click += new System.EventHandler(this.BtnAddPracticalTestAppointment_Click);
            // 
            // editAppointmentToolStripMenuItem
            // 
            this.editAppointmentToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_text;
            this.editAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
            this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.editAppointmentToolStripMenuItem.Text = "Edit Appointment date";
            this.editAppointmentToolStripMenuItem.Click += new System.EventHandler(this.editAppointmentToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(248, 6);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Take_test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // frmPracticalTestAppointements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 715);
            this.Controls.Add(this.dgvPracticalTestAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucLocalDrivingLicenseApplicationCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnAddPracticalTestAppointment);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPracticalTestAppointements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPracticalTestAppointements";
            this.Shown += new System.EventHandler(this.frmPracticalTestAppointements_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticalTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.cmsPracticalTestAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvPracticalTestAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnIsLocked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Applications.LocalDrivingLicenseApplications.Controls.ucLocalDrivingLicenseApplicationCard ucLocalDrivingLicenseApplicationCard1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton BtnAddPracticalTestAppointment;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsPracticalTestAppointments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddTestAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}