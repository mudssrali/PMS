namespace Project_Management_System
{
    partial class LoginWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindows));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnBacktoWindow = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this._PanelRecoveryOption = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPasswordRecover = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbResponseMSG = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.tbRecoveryUserName = new System.Windows.Forms.TextBox();
            this.lbEnterEmail = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbForgetPass = new System.Windows.Forms.Label();
            this._PanelLogin = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this._PanelLoginForm = new MetroFramework.Controls.MetroPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCopyRight = new System.Windows.Forms.Label();
            this._SendingMailPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.panel3.SuspendLayout();
            this._PanelRecoveryOption.SuspendLayout();
            this.panel2.SuspendLayout();
            this._PanelLogin.SuspendLayout();
            this._PanelLoginForm.SuspendLayout();
            this.panel4.SuspendLayout();
            this._SendingMailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnMaximize);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnBacktoWindow);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1368, 45);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindows_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "";
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Project_Management_System.Properties.Resources._1495289974_icon_close;
            this.btnClose.Location = new System.Drawing.Point(1314, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.AccessibleName = "";
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.Image = global::Project_Management_System.Properties.Resources.Restore;
            this.btnMaximize.Location = new System.Drawing.Point(1273, 8);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 29);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnMaximize, "Maximize");
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccessibleName = "";
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Image = global::Project_Management_System.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(1231, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 29);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.metroToolTip.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnBacktoWindow
            // 
            this.btnBacktoWindow.AccessibleName = "";
            this.btnBacktoWindow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBacktoWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBacktoWindow.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBacktoWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBacktoWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBacktoWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacktoWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoWindow.ForeColor = System.Drawing.Color.Black;
            this.btnBacktoWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBacktoWindow.ImageIndex = 28;
            this.btnBacktoWindow.ImageList = this.imageList;
            this.btnBacktoWindow.Location = new System.Drawing.Point(1, -2);
            this.btnBacktoWindow.Name = "btnBacktoWindow";
            this.btnBacktoWindow.Size = new System.Drawing.Size(86, 46);
            this.btnBacktoWindow.TabIndex = 5;
            this.btnBacktoWindow.TabStop = false;
            this.btnBacktoWindow.Text = "Back";
            this.btnBacktoWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroToolTip.SetToolTip(this.btnBacktoWindow, "Back Welcome Window");
            this.btnBacktoWindow.UseVisualStyleBackColor = false;
            this.btnBacktoWindow.Click += new System.EventHandler(this.btnBacktoWindow_Click);
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
            this.imageList.Images.SetKeyName(27, "Arrow-Back-2-icon.png");
            this.imageList.Images.SetKeyName(28, "back.png");
            // 
            // _PanelRecoveryOption
            // 
            this._PanelRecoveryOption.BackColor = System.Drawing.Color.DodgerBlue;
            this._PanelRecoveryOption.Controls.Add(this._SendingMailPanel);
            this._PanelRecoveryOption.Controls.Add(this.panel2);
            this._PanelRecoveryOption.Controls.Add(this.btnCancel);
            this._PanelRecoveryOption.Controls.Add(this.lbResponseMSG);
            this._PanelRecoveryOption.Controls.Add(this.btnSendMail);
            this._PanelRecoveryOption.Controls.Add(this.tbRecoveryUserName);
            this._PanelRecoveryOption.Controls.Add(this.lbEnterEmail);
            this._PanelRecoveryOption.Location = new System.Drawing.Point(752, 90);
            this._PanelRecoveryOption.Name = "_PanelRecoveryOption";
            this._PanelRecoveryOption.Size = new System.Drawing.Size(498, 309);
            this._PanelRecoveryOption.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lbPasswordRecover);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 44);
            this.panel2.TabIndex = 7;
            // 
            // lbPasswordRecover
            // 
            this.lbPasswordRecover.AutoSize = true;
            this.lbPasswordRecover.BackColor = System.Drawing.Color.Transparent;
            this.lbPasswordRecover.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordRecover.ForeColor = System.Drawing.Color.White;
            this.lbPasswordRecover.Location = new System.Drawing.Point(151, 6);
            this.lbPasswordRecover.Name = "lbPasswordRecover";
            this.lbPasswordRecover.Size = new System.Drawing.Size(213, 30);
            this.lbPasswordRecover.TabIndex = 3;
            this.lbPasswordRecover.Text = "Password Recovery";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(186, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbResponseMSG
            // 
            this.lbResponseMSG.AutoSize = true;
            this.lbResponseMSG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponseMSG.ForeColor = System.Drawing.Color.Black;
            this.lbResponseMSG.Location = new System.Drawing.Point(53, 217);
            this.lbResponseMSG.Name = "lbResponseMSG";
            this.lbResponseMSG.Size = new System.Drawing.Size(0, 21);
            this.lbResponseMSG.TabIndex = 6;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMail.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnSendMail.FlatAppearance.BorderSize = 0;
            this.btnSendMail.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSendMail.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(36, 169);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(129, 34);
            this.btnSendMail.TabIndex = 2;
            this.btnSendMail.Text = "Send";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // tbRecoveryUserName
            // 
            this.tbRecoveryUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRecoveryUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecoveryUserName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbRecoveryUserName.Location = new System.Drawing.Point(35, 118);
            this.tbRecoveryUserName.Name = "tbRecoveryUserName";
            this.tbRecoveryUserName.Size = new System.Drawing.Size(380, 29);
            this.tbRecoveryUserName.TabIndex = 1;
            // 
            // lbEnterEmail
            // 
            this.lbEnterEmail.AutoSize = true;
            this.lbEnterEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEnterEmail.Location = new System.Drawing.Point(32, 88);
            this.lbEnterEmail.Name = "lbEnterEmail";
            this.lbEnterEmail.Size = new System.Drawing.Size(131, 21);
            this.lbEnterEmail.TabIndex = 1;
            this.lbEnterEmail.Text = "Enter Username";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(567, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(222, 42);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "WELCOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(74, 195);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(111, 43);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Username";
            // 
            // lbForgetPass
            // 
            this.lbForgetPass.AutoSize = true;
            this.lbForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgetPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgetPass.ForeColor = System.Drawing.Color.White;
            this.lbForgetPass.Location = new System.Drawing.Point(71, 252);
            this.lbForgetPass.Name = "lbForgetPass";
            this.lbForgetPass.Size = new System.Drawing.Size(143, 21);
            this.lbForgetPass.TabIndex = 5;
            this.lbForgetPass.Text = "Forgot password?";
            this.lbForgetPass.Click += new System.EventHandler(this.lbForgetPass_Click);
            this.lbForgetPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbForgetPass_MouseDown);
            this.lbForgetPass.MouseEnter += new System.EventHandler(this.lbForgetPass_MouseEnter);
            this.lbForgetPass.MouseLeave += new System.EventHandler(this.lbForgetPass_MouseLeave);
            // 
            // _PanelLogin
            // 
            this._PanelLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this._PanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._PanelLogin.Controls.Add(this.panel5);
            this._PanelLogin.Controls.Add(this.btnShowHide);
            this._PanelLogin.Controls.Add(this.tbPassword);
            this._PanelLogin.Controls.Add(this.tbUserName);
            this._PanelLogin.Controls.Add(this.lbForgetPass);
            this._PanelLogin.Controls.Add(this.label2);
            this._PanelLogin.Controls.Add(this.loginButton);
            this._PanelLogin.Controls.Add(this.label3);
            this._PanelLogin.ForeColor = System.Drawing.Color.White;
            this._PanelLogin.Location = new System.Drawing.Point(752, 90);
            this._PanelLogin.Name = "_PanelLogin";
            this._PanelLogin.Size = new System.Drawing.Size(498, 309);
            this._PanelLogin.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(418, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 100);
            this.panel5.TabIndex = 46;
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnShowHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.Image = global::Project_Management_System.Properties.Resources.bit;
            this.btnShowHide.Location = new System.Drawing.Point(390, 135);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(27, 25);
            this.btnShowHide.TabIndex = 5;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Visible = false;
            this.btnShowHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowHide_MouseDown);
            this.btnShowHide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowHide_MouseUp);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.AccessibleName = "btnShowHide";
            this.tbPassword.CustomButton.BackColor = System.Drawing.Color.Blue;
            this.tbPassword.CustomButton.BackgroundImage = global::Project_Management_System.Properties.Resources.bit;
            this.tbPassword.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPassword.CustomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPassword.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tbPassword.CustomButton.FlatAppearance.BorderSize = 0;
            this.tbPassword.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbPassword.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.CustomButton.ForeColor = System.Drawing.Color.White;
            this.tbPassword.CustomButton.Image = global::Project_Management_System.Properties.Resources.bit;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.White;
            this.tbPassword.CustomButton.TabIndex = 5;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.UseVisualStyleBackColor = false;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(73, 132);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PromptText = "Password";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(347, 31);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WaterMark = "Password";
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUserName
            // 
            // 
            // 
            // 
            this.tbUserName.CustomButton.Image = null;
            this.tbUserName.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.tbUserName.CustomButton.Name = "";
            this.tbUserName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUserName.CustomButton.TabIndex = 1;
            this.tbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUserName.CustomButton.UseSelectable = true;
            this.tbUserName.CustomButton.Visible = false;
            this.tbUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbUserName.Lines = new string[0];
            this.tbUserName.Location = new System.Drawing.Point(73, 64);
            this.tbUserName.MaxLength = 32767;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PromptText = "Username";
            this.tbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserName.SelectedText = "";
            this.tbUserName.SelectionLength = 0;
            this.tbUserName.SelectionStart = 0;
            this.tbUserName.ShortcutsEnabled = true;
            this.tbUserName.Size = new System.Drawing.Size(347, 31);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.UseSelectable = true;
            this.tbUserName.WaterMark = "Username";
            this.tbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // metroToolTip
            // 
            this.metroToolTip.AutomaticDelay = 200;
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // _PanelLoginForm
            // 
            this._PanelLoginForm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._PanelLoginForm.Controls.Add(this.panel4);
            this._PanelLoginForm.Controls.Add(this.panel1);
            this._PanelLoginForm.Controls.Add(this._PanelLogin);
            this._PanelLoginForm.Controls.Add(this._PanelRecoveryOption);
            this._PanelLoginForm.HorizontalScrollbarBarColor = true;
            this._PanelLoginForm.HorizontalScrollbarHighlightOnWheel = false;
            this._PanelLoginForm.HorizontalScrollbarSize = 10;
            this._PanelLoginForm.Location = new System.Drawing.Point(1, 150);
            this._PanelLoginForm.Name = "_PanelLoginForm";
            this._PanelLoginForm.Size = new System.Drawing.Size(1367, 499);
            this._PanelLoginForm.Style = MetroFramework.MetroColorStyle.Silver;
            this._PanelLoginForm.TabIndex = 4;
            this._PanelLoginForm.Theme = MetroFramework.MetroThemeStyle.Light;
            this._PanelLoginForm.VerticalScrollbarBarColor = true;
            this._PanelLoginForm.VerticalScrollbarHighlightOnWheel = false;
            this._PanelLoginForm.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Project_Management_System.Properties.Resources.logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(113, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 309);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROJECT MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(667, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 367);
            this.panel1.TabIndex = 4;
            // 
            // lbCopyRight
            // 
            this.lbCopyRight.AutoSize = true;
            this.lbCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lbCopyRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCopyRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyRight.ForeColor = System.Drawing.Color.White;
            this.lbCopyRight.Location = new System.Drawing.Point(546, 698);
            this.lbCopyRight.Name = "lbCopyRight";
            this.lbCopyRight.Size = new System.Drawing.Size(228, 21);
            this.lbCopyRight.TabIndex = 5;
            this.lbCopyRight.Text = "© 2017 Project Management";
            this.lbCopyRight.Click += new System.EventHandler(this.lbForgetPass_Click);
            this.lbCopyRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbForgetPass_MouseDown);
            this.lbCopyRight.MouseEnter += new System.EventHandler(this.lbForgetPass_MouseEnter);
            this.lbCopyRight.MouseLeave += new System.EventHandler(this.lbForgetPass_MouseLeave);
            // 
            // _SendingMailPanel
            // 
            this._SendingMailPanel.BackColor = System.Drawing.Color.White;
            this._SendingMailPanel.Controls.Add(this.metroProgressSpinner1);
            this._SendingMailPanel.Controls.Add(this.label4);
            this._SendingMailPanel.Location = new System.Drawing.Point(0, 138);
            this._SendingMailPanel.Name = "_SendingMailPanel";
            this._SendingMailPanel.Size = new System.Drawing.Size(498, 57);
            this._SendingMailPanel.TabIndex = 13;
            this._SendingMailPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sending email...";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(231, 9);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(38, 37);
            this.metroProgressSpinner1.TabIndex = 14;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // LoginWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Project_Management_System.Properties.Resources.softwareBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.ControlBox = false;
            this.Controls.Add(this._PanelLoginForm);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbCopyRight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWindows";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindows_MouseDown);
            this.panel3.ResumeLayout(false);
            this._PanelRecoveryOption.ResumeLayout(false);
            this._PanelRecoveryOption.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._PanelLogin.ResumeLayout(false);
            this._PanelLogin.PerformLayout();
            this._PanelLoginForm.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this._SendingMailPanel.ResumeLayout(false);
            this._SendingMailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBacktoWindow;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lbEnterEmail;
        private System.Windows.Forms.TextBox tbRecoveryUserName;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label lbResponseMSG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPasswordRecover;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel _PanelRecoveryOption;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbForgetPass;
        private System.Windows.Forms.Panel _PanelLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroTextBox tbUserName;
        private MetroFramework.Controls.MetroPanel _PanelLoginForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lbCopyRight;
        private System.Windows.Forms.Panel _SendingMailPanel;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}