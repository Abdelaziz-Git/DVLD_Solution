namespace DVLD_Project.People.Controls
{
    partial class ucPersonInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPersonInfoWithFilter));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.ucPersonInfo1 = new DVLD_Project.UserControls.ucPersonInfo();
            this.gbFilter = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.txtFindValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnAddPerson = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.ddFindBy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblFindBy = new Bunifu.UI.WinForms.BunifuLabel();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ucPersonInfo1.Location = new System.Drawing.Point(3, 107);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(703, 285);
            this.ucPersonInfo1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.LightGray;
            this.gbFilter.BorderRadius = 10;
            this.gbFilter.BorderThickness = 1;
            this.gbFilter.Controls.Add(this.txtFindValue);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.ddFindBy);
            this.gbFilter.Controls.Add(this.lblFindBy);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gbFilter.LabelIndent = 10;
            this.gbFilter.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(703, 100);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtFindValue
            // 
            this.txtFindValue.AcceptsReturn = false;
            this.txtFindValue.AcceptsTab = false;
            this.txtFindValue.AnimationSpeed = 200;
            this.txtFindValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFindValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFindValue.AutoSizeHeight = true;
            this.txtFindValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFindValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFindValue.BackgroundImage")));
            this.txtFindValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFindValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFindValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFindValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFindValue.BorderRadius = 5;
            this.txtFindValue.BorderThickness = 1;
            this.txtFindValue.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtFindValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFindValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindValue.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFindValue.DefaultText = "";
            this.txtFindValue.FillColor = System.Drawing.Color.White;
            this.txtFindValue.HideSelection = true;
            this.txtFindValue.IconLeft = null;
            this.txtFindValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindValue.IconPadding = 10;
            this.txtFindValue.IconRight = null;
            this.txtFindValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindValue.Lines = new string[0];
            this.txtFindValue.Location = new System.Drawing.Point(283, 36);
            this.txtFindValue.MaxLength = 32767;
            this.txtFindValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFindValue.Modified = false;
            this.txtFindValue.Multiline = false;
            this.txtFindValue.Name = "txtFindValue";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindValue.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFindValue.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindValue.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFindValue.OnIdleState = stateProperties4;
            this.txtFindValue.Padding = new System.Windows.Forms.Padding(3);
            this.txtFindValue.PasswordChar = '\0';
            this.txtFindValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFindValue.PlaceholderText = "Enter text";
            this.txtFindValue.ReadOnly = false;
            this.txtFindValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFindValue.SelectedText = "";
            this.txtFindValue.SelectionLength = 0;
            this.txtFindValue.SelectionStart = 0;
            this.txtFindValue.ShortcutsEnabled = true;
            this.txtFindValue.Size = new System.Drawing.Size(221, 39);
            this.txtFindValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFindValue.TabIndex = 5;
            this.txtFindValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFindValue.TextMarginBottom = 0;
            this.txtFindValue.TextMarginLeft = 3;
            this.txtFindValue.TextMarginTop = 1;
            this.txtFindValue.TextPlaceholder = "Enter text";
            this.txtFindValue.UseSystemPasswordChar = false;
            this.txtFindValue.WordWrap = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowBorderColorChanges = true;
            this.btnSearch.AllowMouseEffects = true;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.ColorContrastOnClick = 30;
            this.btnSearch.ColorContrastOnHover = 30;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges1;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.Image = global::DVLD_Project.Properties.Resources.icons8_find_user_male_96;
            this.btnSearch.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Location = new System.Drawing.Point(521, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RoundBorders = false;
            this.btnSearch.ShowBorders = true;
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.AllowAnimations = true;
            this.btnAddPerson.AllowBorderColorChanges = true;
            this.btnAddPerson.AllowMouseEffects = true;
            this.btnAddPerson.AnimationSpeed = 200;
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddPerson.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPerson.BorderRadius = 5;
            this.btnAddPerson.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnAddPerson.BorderThickness = 1;
            this.btnAddPerson.ColorContrastOnClick = 30;
            this.btnAddPerson.ColorContrastOnHover = 30;
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddPerson.CustomizableEdges = borderEdges2;
            this.btnAddPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPerson.Image = global::DVLD_Project.Properties.Resources.Add_Person_Icon8_96;
            this.btnAddPerson.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnAddPerson.Location = new System.Drawing.Point(614, 30);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.RoundBorders = false;
            this.btnAddPerson.ShowBorders = true;
            this.btnAddPerson.Size = new System.Drawing.Size(50, 50);
            this.btnAddPerson.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ddFindBy
            // 
            this.ddFindBy.BackColor = System.Drawing.Color.Transparent;
            this.ddFindBy.BackgroundColor = System.Drawing.Color.White;
            this.ddFindBy.BorderColor = System.Drawing.Color.Silver;
            this.ddFindBy.BorderRadius = 5;
            this.ddFindBy.Color = System.Drawing.Color.Silver;
            this.ddFindBy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddFindBy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddFindBy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddFindBy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddFindBy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddFindBy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddFindBy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddFindBy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddFindBy.FillDropDown = true;
            this.ddFindBy.FillIndicator = false;
            this.ddFindBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddFindBy.ForeColor = System.Drawing.Color.Black;
            this.ddFindBy.FormattingEnabled = true;
            this.ddFindBy.Icon = null;
            this.ddFindBy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddFindBy.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddFindBy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddFindBy.IndicatorThickness = 1;
            this.ddFindBy.IsDropdownOpened = false;
            this.ddFindBy.ItemBackColor = System.Drawing.Color.White;
            this.ddFindBy.ItemBorderColor = System.Drawing.Color.White;
            this.ddFindBy.ItemForeColor = System.Drawing.Color.Black;
            this.ddFindBy.ItemHeight = 26;
            this.ddFindBy.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddFindBy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddFindBy.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.ddFindBy.ItemTopMargin = 3;
            this.ddFindBy.Location = new System.Drawing.Point(66, 39);
            this.ddFindBy.Name = "ddFindBy";
            this.ddFindBy.Size = new System.Drawing.Size(211, 32);
            this.ddFindBy.TabIndex = 1;
            this.ddFindBy.Text = "National No";
            this.ddFindBy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddFindBy.TextLeftMargin = 5;
            this.ddFindBy.SelectedIndexChanged += new System.EventHandler(this.ddFindBy_SelectedIndexChanged);
            // 
            // lblFindBy
            // 
            this.lblFindBy.AllowParentOverrides = false;
            this.lblFindBy.AutoEllipsis = false;
            this.lblFindBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFindBy.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFindBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.Location = new System.Drawing.Point(11, 47);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFindBy.Size = new System.Drawing.Size(50, 17);
            this.lblFindBy.TabIndex = 0;
            this.lblFindBy.Text = "Find By:";
            this.lblFindBy.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFindBy.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ucPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ucPersonInfo1);
            this.Name = "ucPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(710, 395);
            this.Load += new System.EventHandler(this.ucPersonInfoWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucPersonInfo ucPersonInfo1;
        private Bunifu.UI.WinForms.BunifuGroupBox gbFilter;
        private Bunifu.UI.WinForms.BunifuDropdown ddFindBy;
        private Bunifu.UI.WinForms.BunifuLabel lblFindBy;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnAddPerson;
        private Bunifu.UI.WinForms.BunifuTextBox txtFindValue;
    }
}
