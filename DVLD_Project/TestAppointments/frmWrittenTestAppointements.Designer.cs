namespace DVLD_Project.Tests
{
    partial class frmWrittenTestAppointements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWrittenTestAppointements));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucLocalDrivingLicenseApplicationCard1 = new DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls.ucLocalDrivingLicenseApplicationCard();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.dgvWrittenTestAppointments = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.clmnAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAddWrittenTestAppointment = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.cmsWrittenTestAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTestAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWrittenTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.cmsWrittenTestAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucLocalDrivingLicenseApplicationCard1
            // 
            this.ucLocalDrivingLicenseApplicationCard1.BackColor = System.Drawing.Color.White;
            this.ucLocalDrivingLicenseApplicationCard1.Location = new System.Drawing.Point(16, 136);
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
            this.btnClose.Location = new System.Drawing.Point(495, 672);
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
            // dgvWrittenTestAppointments
            // 
            this.dgvWrittenTestAppointments.AllowCustomTheming = true;
            this.dgvWrittenTestAppointments.AllowUserToAddRows = false;
            this.dgvWrittenTestAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvWrittenTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWrittenTestAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvWrittenTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvWrittenTestAppointments.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvWrittenTestAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWrittenTestAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvWrittenTestAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWrittenTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWrittenTestAppointments.ColumnHeadersHeight = 40;
            this.dgvWrittenTestAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnAppointmentID,
            this.clmnAppointmentDate,
            this.clmnPaidFees,
            this.clmnIsLocked});
            this.dgvWrittenTestAppointments.ContextMenuStrip = this.cmsWrittenTestAppointments;
            this.dgvWrittenTestAppointments.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvWrittenTestAppointments.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvWrittenTestAppointments.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWrittenTestAppointments.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvWrittenTestAppointments.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvWrittenTestAppointments.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvWrittenTestAppointments.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvWrittenTestAppointments.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.MidnightBlue;
            this.dgvWrittenTestAppointments.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvWrittenTestAppointments.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvWrittenTestAppointments.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvWrittenTestAppointments.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvWrittenTestAppointments.CurrentTheme.Name = null;
            this.dgvWrittenTestAppointments.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvWrittenTestAppointments.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvWrittenTestAppointments.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvWrittenTestAppointments.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvWrittenTestAppointments.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWrittenTestAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWrittenTestAppointments.EnableHeadersVisualStyles = false;
            this.dgvWrittenTestAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvWrittenTestAppointments.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgvWrittenTestAppointments.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvWrittenTestAppointments.HeaderForeColor = System.Drawing.Color.White;
            this.dgvWrittenTestAppointments.Location = new System.Drawing.Point(321, 481);
            this.dgvWrittenTestAppointments.Name = "dgvWrittenTestAppointments";
            this.dgvWrittenTestAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWrittenTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWrittenTestAppointments.RowHeadersVisible = false;
            this.dgvWrittenTestAppointments.RowTemplate.Height = 40;
            this.dgvWrittenTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWrittenTestAppointments.Size = new System.Drawing.Size(503, 175);
            this.dgvWrittenTestAppointments.TabIndex = 44;
            this.dgvWrittenTestAppointments.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            // BtnAddWrittenTestAppointment
            // 
            this.BtnAddWrittenTestAppointment.ActiveImage = null;
            this.BtnAddWrittenTestAppointment.AllowAnimations = true;
            this.BtnAddWrittenTestAppointment.AllowBuffering = false;
            this.BtnAddWrittenTestAppointment.AllowToggling = false;
            this.BtnAddWrittenTestAppointment.AllowZooming = true;
            this.BtnAddWrittenTestAppointment.AllowZoomingOnFocus = false;
            this.BtnAddWrittenTestAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddWrittenTestAppointment.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddWrittenTestAppointment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAddWrittenTestAppointment.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnAddWrittenTestAppointment.ErrorImage")));
            this.BtnAddWrittenTestAppointment.FadeWhenInactive = false;
            this.BtnAddWrittenTestAppointment.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnAddWrittenTestAppointment.Image = global::DVLD_Project.Properties.Resources.appointment_64;
            this.BtnAddWrittenTestAppointment.ImageActive = null;
            this.BtnAddWrittenTestAppointment.ImageLocation = null;
            this.BtnAddWrittenTestAppointment.ImageMargin = 20;
            this.BtnAddWrittenTestAppointment.ImageSize = new System.Drawing.Size(44, 44);
            this.BtnAddWrittenTestAppointment.ImageZoomSize = new System.Drawing.Size(64, 64);
            this.BtnAddWrittenTestAppointment.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnAddWrittenTestAppointment.InitialImage")));
            this.BtnAddWrittenTestAppointment.Location = new System.Drawing.Point(761, 412);
            this.BtnAddWrittenTestAppointment.Name = "BtnAddWrittenTestAppointment";
            this.BtnAddWrittenTestAppointment.Rotation = 0;
            this.BtnAddWrittenTestAppointment.ShowActiveImage = true;
            this.BtnAddWrittenTestAppointment.ShowCursorChanges = true;
            this.BtnAddWrittenTestAppointment.ShowImageBorders = true;
            this.BtnAddWrittenTestAppointment.ShowSizeMarkers = false;
            this.BtnAddWrittenTestAppointment.Size = new System.Drawing.Size(64, 64);
            this.BtnAddWrittenTestAppointment.TabIndex = 43;
            this.BtnAddWrittenTestAppointment.ToolTipText = "Click to add vision test appointment.";
            this.BtnAddWrittenTestAppointment.WaitOnLoad = false;
            this.BtnAddWrittenTestAppointment.Zoom = 20;
            this.BtnAddWrittenTestAppointment.ZoomSpeed = 10;
            this.BtnAddWrittenTestAppointment.Click += new System.EventHandler(this.BtnAddWrittenTestAppointment_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(318, 434);
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
            this.label1.Location = new System.Drawing.Point(469, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Written Test Appointments";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::DVLD_Project.Properties.Resources.Written_test_128;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(555, 20);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(57, 57);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 40;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // cmsWrittenTestAppointments
            // 
            this.cmsWrittenTestAppointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsWrittenTestAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.AddTestAppointmentToolStripMenuItem,
            this.editAppointmentToolStripMenuItem,
            this.toolStripSeparator2,
            this.takeTestToolStripMenuItem});
            this.cmsWrittenTestAppointments.Name = "cmsListPeople";
            this.cmsWrittenTestAppointments.Size = new System.Drawing.Size(252, 130);
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
            this.AddTestAppointmentToolStripMenuItem.Click += new System.EventHandler(this.BtnAddWrittenTestAppointment_Click);
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
            // frmWrittenTestAppointements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 716);
            this.Controls.Add(this.ucLocalDrivingLicenseApplicationCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvWrittenTestAppointments);
            this.Controls.Add(this.BtnAddWrittenTestAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Name = "frmWrittenTestAppointements";
            this.Text = "frmWrittenTestAppointements";
            this.Shown += new System.EventHandler(this.frmWrittenTestAppointements_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWrittenTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.cmsWrittenTestAppointments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.LocalDrivingLicenseApplications.Controls.ucLocalDrivingLicenseApplicationCard ucLocalDrivingLicenseApplicationCard1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnClose;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvWrittenTestAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnIsLocked;
        private Bunifu.UI.WinForms.BunifuImageButton BtnAddWrittenTestAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsWrittenTestAppointments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddTestAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}