namespace Project_Management_System
{
    partial class Add_Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Task));
            this.lbAddTask = new System.Windows.Forms.Label();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.btnCloseTask = new System.Windows.Forms.Button();
            this.lbProject = new System.Windows.Forms.Label();
            this._PanelTime = new System.Windows.Forms.Panel();
            this.cbProgress = new MetroFramework.Controls.MetroComboBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnBackToGeneral = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbSD = new System.Windows.Forms.Label();
            this.lbDD = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.ExpectedDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbExpectTime = new System.Windows.Forms.Label();
            this._PanelGeneral = new System.Windows.Forms.Panel();
            this.cbStatus = new MetroFramework.Controls.MetroComboBox();
            this.cbAssignedTo = new MetroFramework.Controls.MetroComboBox();
            this.cbLabel = new MetroFramework.Controls.MetroComboBox();
            this.cbPriority = new MetroFramework.Controls.MetroComboBox();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSelectedProject = new MetroFramework.Controls.MetroComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbGeneral = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.lbAssignedTo = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this._PanelTime.SuspendLayout();
            this._PanelGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAddTask
            // 
            this.lbAddTask.AutoSize = true;
            this.lbAddTask.BackColor = System.Drawing.Color.Transparent;
            this.lbAddTask.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddTask.ForeColor = System.Drawing.Color.White;
            this.lbAddTask.Location = new System.Drawing.Point(601, 68);
            this.lbAddTask.Name = "lbAddTask";
            this.lbAddTask.Size = new System.Drawing.Size(163, 32);
            this.lbAddTask.TabIndex = 0;
            this.lbAddTask.Text = "NEW TASK";
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.AccessibleName = "";
            this.btnSaveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveTask.FlatAppearance.BorderSize = 0;
            this.btnSaveTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTask.ForeColor = System.Drawing.Color.White;
            this.btnSaveTask.Location = new System.Drawing.Point(925, 525);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(79, 31);
            this.btnSaveTask.TabIndex = 15;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = false;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // btnCloseTask
            // 
            this.btnCloseTask.AccessibleName = "";
            this.btnCloseTask.BackColor = System.Drawing.Color.White;
            this.btnCloseTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseTask.FlatAppearance.BorderSize = 0;
            this.btnCloseTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCloseTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCloseTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTask.ForeColor = System.Drawing.Color.Black;
            this.btnCloseTask.Location = new System.Drawing.Point(1027, 524);
            this.btnCloseTask.Name = "btnCloseTask";
            this.btnCloseTask.Size = new System.Drawing.Size(79, 31);
            this.btnCloseTask.TabIndex = 16;
            this.btnCloseTask.Text = "Close";
            this.btnCloseTask.UseVisualStyleBackColor = false;
            this.btnCloseTask.Click += new System.EventHandler(this.btnCloseTask_Click);
            // 
            // lbProject
            // 
            this.lbProject.AutoSize = true;
            this.lbProject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProject.ForeColor = System.Drawing.Color.White;
            this.lbProject.Location = new System.Drawing.Point(164, 14);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(64, 21);
            this.lbProject.TabIndex = 0;
            this.lbProject.Text = "Project";
            // 
            // _PanelTime
            // 
            this._PanelTime.BackColor = System.Drawing.Color.SkyBlue;
            this._PanelTime.Controls.Add(this.cbProgress);
            this._PanelTime.Controls.Add(this.lbTime);
            this._PanelTime.Controls.Add(this.btnBackToGeneral);
            this._PanelTime.Controls.Add(this.lbSD);
            this._PanelTime.Controls.Add(this.btnCloseTask);
            this._PanelTime.Controls.Add(this.btnSaveTask);
            this._PanelTime.Controls.Add(this.lbDD);
            this._PanelTime.Controls.Add(this.lbProgress);
            this._PanelTime.Controls.Add(this.DueDate);
            this._PanelTime.Controls.Add(this.ExpectedDate);
            this._PanelTime.Controls.Add(this.StartDate);
            this._PanelTime.Controls.Add(this.lbExpectTime);
            this._PanelTime.Location = new System.Drawing.Point(1, 119);
            this._PanelTime.Name = "_PanelTime";
            this._PanelTime.Size = new System.Drawing.Size(1368, 586);
            this._PanelTime.TabIndex = 0;
            // 
            // cbProgress
            // 
            this.cbProgress.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbProgress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProgress.ForeColor = System.Drawing.Color.Black;
            this.cbProgress.FormattingEnabled = true;
            this.cbProgress.ItemHeight = 23;
            this.cbProgress.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.cbProgress.Location = new System.Drawing.Point(734, 208);
            this.cbProgress.MaxDropDownItems = 4;
            this.cbProgress.Name = "cbProgress";
            this.cbProgress.Size = new System.Drawing.Size(361, 29);
            this.cbProgress.Style = MetroFramework.MetroColorStyle.Green;
            this.cbProgress.TabIndex = 66;
            this.metroToolTip.SetToolTip(this.cbProgress, "Select task progress");
            this.cbProgress.UseSelectable = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(554, 26);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(238, 25);
            this.lbTime.TabIndex = 65;
            this.lbTime.Text = "TIME INFORMATION";
            // 
            // btnBackToGeneral
            // 
            this.btnBackToGeneral.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackToGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToGeneral.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnBackToGeneral.FlatAppearance.BorderSize = 0;
            this.btnBackToGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnBackToGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnBackToGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToGeneral.ForeColor = System.Drawing.Color.Black;
            this.btnBackToGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToGeneral.ImageIndex = 27;
            this.btnBackToGeneral.ImageList = this.imageList;
            this.btnBackToGeneral.Location = new System.Drawing.Point(11, 521);
            this.btnBackToGeneral.Name = "btnBackToGeneral";
            this.btnBackToGeneral.Size = new System.Drawing.Size(104, 34);
            this.btnBackToGeneral.TabIndex = 64;
            this.btnBackToGeneral.Text = "Back";
            this.btnBackToGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroToolTip.SetToolTip(this.btnBackToGeneral, "Back to add employee");
            this.btnBackToGeneral.UseVisualStyleBackColor = false;
            this.btnBackToGeneral.Click += new System.EventHandler(this.btnBackToGeneral_Click);
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
            // lbSD
            // 
            this.lbSD.AutoSize = true;
            this.lbSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSD.Location = new System.Drawing.Point(251, 80);
            this.lbSD.Name = "lbSD";
            this.lbSD.Size = new System.Drawing.Size(79, 21);
            this.lbSD.TabIndex = 63;
            this.lbSD.Text = "Start Date";
            // 
            // lbDD
            // 
            this.lbDD.AutoSize = true;
            this.lbDD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDD.Location = new System.Drawing.Point(251, 186);
            this.lbDD.Name = "lbDD";
            this.lbDD.Size = new System.Drawing.Size(74, 21);
            this.lbDD.TabIndex = 62;
            this.lbDD.Text = "Due Date";
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgress.Location = new System.Drawing.Point(730, 184);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(71, 21);
            this.lbProgress.TabIndex = 60;
            this.lbProgress.Text = "Progress";
            // 
            // DueDate
            // 
            this.DueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DueDate.Location = new System.Drawing.Point(255, 210);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(352, 29);
            this.DueDate.TabIndex = 11;
            // 
            // ExpectedDate
            // 
            this.ExpectedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpectedDate.Location = new System.Drawing.Point(734, 107);
            this.ExpectedDate.Name = "ExpectedDate";
            this.ExpectedDate.Size = new System.Drawing.Size(361, 29);
            this.ExpectedDate.TabIndex = 14;
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(255, 104);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(352, 29);
            this.StartDate.TabIndex = 10;
            // 
            // lbExpectTime
            // 
            this.lbExpectTime.AutoSize = true;
            this.lbExpectTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpectTime.Location = new System.Drawing.Point(730, 83);
            this.lbExpectTime.Name = "lbExpectTime";
            this.lbExpectTime.Size = new System.Drawing.Size(107, 21);
            this.lbExpectTime.TabIndex = 59;
            this.lbExpectTime.Text = "Expected Date";
            // 
            // _PanelGeneral
            // 
            this._PanelGeneral.BackColor = System.Drawing.Color.SkyBlue;
            this._PanelGeneral.Controls.Add(this.cbStatus);
            this._PanelGeneral.Controls.Add(this.cbAssignedTo);
            this._PanelGeneral.Controls.Add(this.cbLabel);
            this._PanelGeneral.Controls.Add(this.cbPriority);
            this._PanelGeneral.Controls.Add(this.cbType);
            this._PanelGeneral.Controls.Add(this.panel2);
            this._PanelGeneral.Controls.Add(this.btnNext);
            this._PanelGeneral.Controls.Add(this.lbGeneral);
            this._PanelGeneral.Controls.Add(this.tbDescription);
            this._PanelGeneral.Controls.Add(this.lbDescription);
            this._PanelGeneral.Controls.Add(this.tbTaskName);
            this._PanelGeneral.Controls.Add(this.lbPriority);
            this._PanelGeneral.Controls.Add(this.lbAssignedTo);
            this._PanelGeneral.Controls.Add(this.lbLabel);
            this._PanelGeneral.Controls.Add(this.lbStatus);
            this._PanelGeneral.Controls.Add(this.lbName);
            this._PanelGeneral.Controls.Add(this.lbType);
            this._PanelGeneral.Location = new System.Drawing.Point(1, 119);
            this._PanelGeneral.Name = "_PanelGeneral";
            this._PanelGeneral.Size = new System.Drawing.Size(1368, 586);
            this._PanelGeneral.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.ItemHeight = 23;
            this.cbStatus.Items.AddRange(new object[] {
            "Closed",
            "Completed",
            "Done",
            "Lost",
            "Open",
            "Paid",
            "Re-open",
            "Suspended",
            "Waiting Assessment"});
            this.cbStatus.Location = new System.Drawing.Point(255, 278);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(375, 29);
            this.cbStatus.Style = MetroFramework.MetroColorStyle.Green;
            this.cbStatus.TabIndex = 4;
            this.cbStatus.UseSelectable = true;
            // 
            // cbAssignedTo
            // 
            this.cbAssignedTo.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbAssignedTo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAssignedTo.ForeColor = System.Drawing.Color.Black;
            this.cbAssignedTo.FormattingEnabled = true;
            this.cbAssignedTo.ItemHeight = 23;
            this.cbAssignedTo.Location = new System.Drawing.Point(770, 278);
            this.cbAssignedTo.Name = "cbAssignedTo";
            this.cbAssignedTo.Size = new System.Drawing.Size(375, 29);
            this.cbAssignedTo.Style = MetroFramework.MetroColorStyle.Green;
            this.cbAssignedTo.TabIndex = 7;
            this.cbAssignedTo.UseSelectable = true;
            // 
            // cbLabel
            // 
            this.cbLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLabel.ForeColor = System.Drawing.Color.Black;
            this.cbLabel.FormattingEnabled = true;
            this.cbLabel.ItemHeight = 23;
            this.cbLabel.Items.AddRange(new object[] {
            "Bug",
            "Change",
            "Idea",
            "Issue",
            "Plugin",
            "Qoute",
            "Task"});
            this.cbLabel.Location = new System.Drawing.Point(771, 208);
            this.cbLabel.Name = "cbLabel";
            this.cbLabel.Size = new System.Drawing.Size(375, 29);
            this.cbLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.cbLabel.TabIndex = 6;
            this.cbLabel.UseSelectable = true;
            // 
            // cbPriority
            // 
            this.cbPriority.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbPriority.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPriority.ForeColor = System.Drawing.Color.Black;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.ItemHeight = 23;
            this.cbPriority.Items.AddRange(new object[] {
            "High",
            "Low",
            "Medium",
            "Unknown",
            "Urget"});
            this.cbPriority.Location = new System.Drawing.Point(771, 137);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(375, 29);
            this.cbPriority.Style = MetroFramework.MetroColorStyle.Green;
            this.cbPriority.TabIndex = 5;
            this.cbPriority.UseSelectable = true;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbType.ForeColor = System.Drawing.Color.Black;
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Change Priority Rate (Hourly rate $25.00)",
            "Changes(Hourly rate $15.00)",
            "Defacts(Hourly rate $0.00)"});
            this.cbType.Location = new System.Drawing.Point(255, 139);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(375, 29);
            this.cbType.Style = MetroFramework.MetroColorStyle.Green;
            this.cbType.TabIndex = 2;
            this.cbType.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.cbSelectedProject);
            this.panel2.Controls.Add(this.lbProject);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 49);
            this.panel2.TabIndex = 60;
            // 
            // cbSelectedProject
            // 
            this.cbSelectedProject.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbSelectedProject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSelectedProject.ForeColor = System.Drawing.Color.Black;
            this.cbSelectedProject.FormattingEnabled = true;
            this.cbSelectedProject.ItemHeight = 23;
            this.cbSelectedProject.Location = new System.Drawing.Point(255, 10);
            this.cbSelectedProject.Name = "cbSelectedProject";
            this.cbSelectedProject.Size = new System.Drawing.Size(374, 29);
            this.cbSelectedProject.Style = MetroFramework.MetroColorStyle.Green;
            this.cbSelectedProject.TabIndex = 1;
            this.metroToolTip.SetToolTip(this.cbSelectedProject, "Select project");
            this.cbSelectedProject.UseSelectable = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.ImageIndex = 28;
            this.btnNext.ImageList = this.imageList;
            this.btnNext.Location = new System.Drawing.Point(1244, 525);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 35);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbGeneral
            // 
            this.lbGeneral.AutoSize = true;
            this.lbGeneral.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneral.Location = new System.Drawing.Point(556, 71);
            this.lbGeneral.Name = "lbGeneral";
            this.lbGeneral.Size = new System.Drawing.Size(286, 25);
            this.lbGeneral.TabIndex = 0;
            this.lbGeneral.Text = "GENERAL INFORMATION";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(255, 360);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(891, 154);
            this.tbDescription.TabIndex = 8;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(254, 334);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(125, 21);
            this.lbDescription.TabIndex = 59;
            this.lbDescription.Text = "Brief Description";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskName.Location = new System.Drawing.Point(255, 208);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(375, 29);
            this.tbTaskName.TabIndex = 3;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriority.Location = new System.Drawing.Point(766, 113);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(57, 21);
            this.lbPriority.TabIndex = 50;
            this.lbPriority.Text = "Priorty";
            // 
            // lbAssignedTo
            // 
            this.lbAssignedTo.AutoSize = true;
            this.lbAssignedTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssignedTo.Location = new System.Drawing.Point(766, 256);
            this.lbAssignedTo.Name = "lbAssignedTo";
            this.lbAssignedTo.Size = new System.Drawing.Size(91, 21);
            this.lbAssignedTo.TabIndex = 49;
            this.lbAssignedTo.Text = "Assigned to";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(766, 186);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(47, 21);
            this.lbLabel.TabIndex = 49;
            this.lbLabel.Text = "Label";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(251, 254);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 21);
            this.lbStatus.TabIndex = 48;
            this.lbStatus.Text = "Status";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(251, 184);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 21);
            this.lbName.TabIndex = 47;
            this.lbName.Text = "Name";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(251, 111);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(43, 21);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "Type";
            // 
            // metroToolTip
            // 
            this.metroToolTip.AutomaticDelay = 200;
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.btnClose1.Location = new System.Drawing.Point(1316, 8);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(36, 29);
            this.btnClose1.TabIndex = 44;
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
            this.btnMaximize.Location = new System.Drawing.Point(1275, 8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 29);
            this.btnMaximize.TabIndex = 43;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnMaximize, "Maximize");
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
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
            this.btnBack.Location = new System.Drawing.Point(1, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 44);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroToolTip.SetToolTip(this.btnBack, "Back to dashboard");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBack_KeyDown);
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
            this.btnMinimize.Location = new System.Drawing.Point(1233, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 29);
            this.btnMinimize.TabIndex = 42;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.btnClose1);
            this.panel3.Controls.Add(this.btnMaximize);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1369, 45);
            this.panel3.TabIndex = 35;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // Add_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project_Management_System.Properties.Resources.softwareBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 752);
            this.ControlBox = false;
            this.Controls.Add(this.lbAddTask);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this._PanelGeneral);
            this.Controls.Add(this._PanelTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Task";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Task_FormClosed);
            this.Load += new System.EventHandler(this.Add_Task_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this._PanelTime.ResumeLayout(false);
            this._PanelTime.PerformLayout();
            this._PanelGeneral.ResumeLayout(false);
            this._PanelGeneral.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAddTask;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.Button btnCloseTask;
        private System.Windows.Forms.Label lbProject;
        private System.Windows.Forms.Panel _PanelGeneral;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label lbAssignedTo;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Panel _PanelTime;
        private System.Windows.Forms.ImageList imageList;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSD;
        private System.Windows.Forms.Label lbDD;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.DateTimePicker ExpectedDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label lbExpectTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBackToGeneral;
        private MetroFramework.Controls.MetroComboBox cbSelectedProject;
        private System.Windows.Forms.Label lbGeneral;
        private System.Windows.Forms.Label lbTime;
        private MetroFramework.Controls.MetroComboBox cbStatus;
        private MetroFramework.Controls.MetroComboBox cbAssignedTo;
        private MetroFramework.Controls.MetroComboBox cbLabel;
        private MetroFramework.Controls.MetroComboBox cbPriority;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroComboBox cbProgress;
    }
}