namespace Project_Management_System
{
    partial class Add_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Project));
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this._PanelGeneral = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTeam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this._PanelGeneral.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(572, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "NEW PROJECT";
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "";
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageIndex = 27;
            this.btnBack.ImageList = this.imageList;
            this.btnBack.Location = new System.Drawing.Point(1, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 44);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroToolTip.SetToolTip(this.btnBack, "Back to dashboard");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBack_KeyDown);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "menu.png");
            this.imageList.Images.SetKeyName(1, "Arrows-Left-icon.png");
            this.imageList.Images.SetKeyName(2, "menu.png");
            this.imageList.Images.SetKeyName(3, "settings-icon.png");
            this.imageList.Images.SetKeyName(4, "Actions-view-calendar-tasks-icon.png");
            this.imageList.Images.SetKeyName(5, "Actions-view-list-details-icon.png");
            this.imageList.Images.SetKeyName(6, "Actions-view-list-tree-icon.png");
            this.imageList.Images.SetKeyName(7, "Add-Male-User-icon.png");
            this.imageList.Images.SetKeyName(8, "Business.png");
            this.imageList.Images.SetKeyName(9, "Dj-View-icon.png");
            this.imageList.Images.SetKeyName(10, "man.png");
            this.imageList.Images.SetKeyName(11, "math-add-icon.png");
            this.imageList.Images.SetKeyName(12, "node-tree-icon.png");
            this.imageList.Images.SetKeyName(13, "Status-mail-task-icon.png");
            this.imageList.Images.SetKeyName(14, "team.png");
            this.imageList.Images.SetKeyName(15, "Trash-Delete-icon.png");
            this.imageList.Images.SetKeyName(16, "user.png");
            this.imageList.Images.SetKeyName(17, "users-icon.png");
            this.imageList.Images.SetKeyName(18, "Very-Basic-Cancel-icon.png");
            this.imageList.Images.SetKeyName(19, "Add Property-50.png");
            this.imageList.Images.SetKeyName(20, "Add User Male Filled-50.png");
            this.imageList.Images.SetKeyName(21, "Available Updates-26.png");
            this.imageList.Images.SetKeyName(22, "Delete-26.png");
            this.imageList.Images.SetKeyName(23, "Edit User Male Filled-50.png");
            this.imageList.Images.SetKeyName(24, "To Do-48.png");
            this.imageList.Images.SetKeyName(25, "View Details-50.png");
            this.imageList.Images.SetKeyName(26, "View File-26.png");
            this.imageList.Images.SetKeyName(27, "back.png");
            this.imageList.Images.SetKeyName(28, "forward.png");
            // 
            // btnClose1
            // 
            this.btnClose1.AccessibleName = "";
            this.btnClose1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose1.FlatAppearance.BorderSize = 0;
            this.btnClose1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.Color.Black;
            this.btnClose1.Image = global::Project_Management_System.Properties.Resources._1495289974_icon_close;
            this.btnClose1.Location = new System.Drawing.Point(1309, 11);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(36, 29);
            this.btnClose1.TabIndex = 13;
            this.btnClose1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnClose1, "Close");
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.AccessibleName = "";
            this.btnMaximize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.Image = global::Project_Management_System.Properties.Resources.Restore;
            this.btnMaximize.Location = new System.Drawing.Point(1268, 11);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 29);
            this.btnMaximize.TabIndex = 12;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnMaximize, "Maximize");
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccessibleName = "";
            this.btnMinimize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = global::Project_Management_System.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(1226, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 29);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // _PanelGeneral
            // 
            this._PanelGeneral.BackColor = System.Drawing.Color.SkyBlue;
            this._PanelGeneral.Controls.Add(this.btnClose);
            this._PanelGeneral.Controls.Add(this.tbDescription);
            this._PanelGeneral.Controls.Add(this.btnSave);
            this._PanelGeneral.Controls.Add(this.tbPrice);
            this._PanelGeneral.Controls.Add(this.tbName);
            this._PanelGeneral.Controls.Add(this.lbDescription);
            this._PanelGeneral.Controls.Add(this.label9);
            this._PanelGeneral.Controls.Add(this.lbTeam);
            this._PanelGeneral.Controls.Add(this.label10);
            this._PanelGeneral.Controls.Add(this.label11);
            this._PanelGeneral.Controls.Add(this.label12);
            this._PanelGeneral.Controls.Add(this.label13);
            this._PanelGeneral.Controls.Add(this.cbCustomer);
            this._PanelGeneral.Controls.Add(this.cbTeam);
            this._PanelGeneral.Controls.Add(this.cbStatus);
            this._PanelGeneral.Controls.Add(this.cbType);
            this._PanelGeneral.Location = new System.Drawing.Point(1, 119);
            this._PanelGeneral.Name = "_PanelGeneral";
            this._PanelGeneral.Size = new System.Drawing.Size(1368, 586);
            this._PanelGeneral.TabIndex = 2;
            this._PanelGeneral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPanel_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "";
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1002, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 31);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cancel";
            this.metroToolTip.SetToolTip(this.btnClose, "Cancel new project");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(265, 284);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(816, 224);
            this.tbDescription.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "";
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(905, 538);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save project";
            this.metroToolTip.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(720, 64);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(361, 29);
            this.tbPrice.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(265, 130);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(363, 29);
            this.tbName.TabIndex = 2;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(263, 259);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(125, 21);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Brief Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(716, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customer";
            // 
            // lbTeam
            // 
            this.lbTeam.AutoSize = true;
            this.lbTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeam.Location = new System.Drawing.Point(716, 107);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(48, 21);
            this.lbTeam.TabIndex = 0;
            this.lbTeam.Text = "Team";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(719, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 56;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(261, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 56;
            this.label11.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(261, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 55;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(261, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 21);
            this.label13.TabIndex = 54;
            this.label13.Text = "Type";
            // 
            // cbCustomer
            // 
            this.cbCustomer.BackColor = System.Drawing.Color.White;
            this.cbCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(720, 206);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(361, 29);
            this.cbCustomer.TabIndex = 6;
            this.metroToolTip.SetToolTip(this.cbCustomer, "Select customer");
            this.cbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTeam_KeyPress);
            // 
            // cbTeam
            // 
            this.cbTeam.BackColor = System.Drawing.Color.White;
            this.cbTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(720, 131);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(361, 29);
            this.cbTeam.TabIndex = 5;
            this.metroToolTip.SetToolTip(this.cbTeam, "Select team");
            this.cbTeam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTeam_KeyPress);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Open",
            "On Hold",
            "Closed",
            "Cancelled"});
            this.cbStatus.Location = new System.Drawing.Point(265, 206);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(363, 29);
            this.cbStatus.TabIndex = 3;
            this.metroToolTip.SetToolTip(this.cbStatus, "Select project status");
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Support",
            "New Site",
            "Internal"});
            this.cbType.Location = new System.Drawing.Point(265, 63);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(363, 29);
            this.cbType.TabIndex = 1;
            this.metroToolTip.SetToolTip(this.cbType, "Select project type");
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPanel.Controls.Add(this.btnClose1);
            this.btnPanel.Controls.Add(this.btnBack);
            this.btnPanel.Controls.Add(this.btnMaximize);
            this.btnPanel.Controls.Add(this.btnMinimize);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.Location = new System.Drawing.Point(0, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(1354, 49);
            this.btnPanel.TabIndex = 43;
            this.btnPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPanel_MouseDown);
            // 
            // metroToolTip
            // 
            this.metroToolTip.AutomaticDelay = 200;
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_Management_System.Properties.Resources.softwareBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 752);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this._PanelGeneral);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Project_FormClosed);
            this.Load += new System.EventHandler(this.Add_Project_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPanel_MouseDown);
            this._PanelGeneral.ResumeLayout(false);
            this._PanelGeneral.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel _PanelGeneral;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Label lbTeam;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageList;
        private MetroFramework.Components.MetroToolTip metroToolTip;
    }
}