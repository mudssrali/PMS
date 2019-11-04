namespace Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnSave = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._PanelAdmin = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbAdminPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbAdminUserName = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new MetroFramework.Controls.MetroTextBox();
            this.cbGender = new MetroFramework.Controls.MetroComboBox();
            this.tbLastName = new MetroFramework.Controls.MetroTextBox();
            this.tbFirstName = new MetroFramework.Controls.MetroTextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbuserName = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lbEMPName = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnBacktoWindow = new System.Windows.Forms.Button();
            this._RegisterPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this._PanelAdmin.SuspendLayout();
            this._RegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1046, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SubmitBT);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(564, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(231, 32);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "NEW ACCOUNT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.tbContact);
            this.panel2.Controls.Add(this.tbEmail);
            this.panel2.Controls.Add(this.cbGender);
            this.panel2.Controls.Add(this.tbLastName);
            this.panel2.Controls.Add(this.tbFirstName);
            this.panel2.Controls.Add(this.tbUserName);
            this.panel2.Controls.Add(this.lbuserName);
            this.panel2.Controls.Add(this.lbContact);
            this.panel2.Controls.Add(this.genderlabel);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.lbEMPName);
            this.panel2.Controls.Add(this.tbConfirmPassword);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Controls.Add(this.confirmPassLabel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this._PanelAdmin);
            this.panel2.Location = new System.Drawing.Point(1, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 586);
            this.panel2.TabIndex = 35;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this._RegisterPanel_MouseDown);
            // 
            // _PanelAdmin
            // 
            this._PanelAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this._PanelAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._PanelAdmin.Controls.Add(this.panel5);
            this._PanelAdmin.Controls.Add(this.tbAdminPassword);
            this._PanelAdmin.Controls.Add(this.tbAdminUserName);
            this._PanelAdmin.Controls.Add(this.label2);
            this._PanelAdmin.Controls.Add(this.btnCancel);
            this._PanelAdmin.Controls.Add(this.btnSubmit);
            this._PanelAdmin.Controls.Add(this.label3);
            this._PanelAdmin.ForeColor = System.Drawing.Color.White;
            this._PanelAdmin.Location = new System.Drawing.Point(0, 167);
            this._PanelAdmin.Name = "_PanelAdmin";
            this._PanelAdmin.Size = new System.Drawing.Size(1368, 204);
            this._PanelAdmin.TabIndex = 55;
            this._PanelAdmin.TabStop = true;
            this._PanelAdmin.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(854, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 100);
            this.panel5.TabIndex = 46;
            // 
            // tbAdminPassword
            // 
            // 
            // 
            // 
            this.tbAdminPassword.CustomButton.AccessibleName = "btnShowHide";
            this.tbAdminPassword.CustomButton.BackColor = System.Drawing.Color.Blue;
            this.tbAdminPassword.CustomButton.BackgroundImage = global::Project_Management_System.Properties.Resources.bit;
            this.tbAdminPassword.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbAdminPassword.CustomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbAdminPassword.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tbAdminPassword.CustomButton.FlatAppearance.BorderSize = 0;
            this.tbAdminPassword.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAdminPassword.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdminPassword.CustomButton.ForeColor = System.Drawing.Color.White;
            this.tbAdminPassword.CustomButton.Image = global::Project_Management_System.Properties.Resources.bit;
            this.tbAdminPassword.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.tbAdminPassword.CustomButton.Name = "";
            this.tbAdminPassword.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tbAdminPassword.CustomButton.Style = MetroFramework.MetroColorStyle.White;
            this.tbAdminPassword.CustomButton.TabIndex = 5;
            this.tbAdminPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdminPassword.CustomButton.UseSelectable = true;
            this.tbAdminPassword.CustomButton.UseVisualStyleBackColor = false;
            this.tbAdminPassword.CustomButton.Visible = false;
            this.tbAdminPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbAdminPassword.Lines = new string[0];
            this.tbAdminPassword.Location = new System.Drawing.Point(509, 101);
            this.tbAdminPassword.MaxLength = 32767;
            this.tbAdminPassword.Name = "tbAdminPassword";
            this.tbAdminPassword.PasswordChar = '●';
            this.tbAdminPassword.PromptText = "Password";
            this.tbAdminPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAdminPassword.SelectedText = "";
            this.tbAdminPassword.SelectionLength = 0;
            this.tbAdminPassword.SelectionStart = 0;
            this.tbAdminPassword.ShortcutsEnabled = true;
            this.tbAdminPassword.Size = new System.Drawing.Size(347, 31);
            this.tbAdminPassword.TabIndex = 2;
            this.tbAdminPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdminPassword.UseSelectable = true;
            this.tbAdminPassword.UseSystemPasswordChar = true;
            this.tbAdminPassword.WaterMark = "Password";
            this.tbAdminPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAdminPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbAdminUserName
            // 
            // 
            // 
            // 
            this.tbAdminUserName.CustomButton.Image = null;
            this.tbAdminUserName.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.tbAdminUserName.CustomButton.Name = "";
            this.tbAdminUserName.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tbAdminUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAdminUserName.CustomButton.TabIndex = 1;
            this.tbAdminUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdminUserName.CustomButton.UseSelectable = true;
            this.tbAdminUserName.CustomButton.Visible = false;
            this.tbAdminUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbAdminUserName.Lines = new string[0];
            this.tbAdminUserName.Location = new System.Drawing.Point(509, 33);
            this.tbAdminUserName.MaxLength = 32767;
            this.tbAdminUserName.Name = "tbAdminUserName";
            this.tbAdminUserName.PasswordChar = '\0';
            this.tbAdminUserName.PromptText = "Username";
            this.tbAdminUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAdminUserName.SelectedText = "";
            this.tbAdminUserName.SelectionLength = 0;
            this.tbAdminUserName.SelectionStart = 0;
            this.tbAdminUserName.ShortcutsEnabled = true;
            this.tbAdminUserName.Size = new System.Drawing.Size(347, 31);
            this.tbAdminUserName.TabIndex = 1;
            this.tbAdminUserName.UseSelectable = true;
            this.tbAdminUserName.WaterMark = "Username";
            this.tbAdminUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAdminUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(505, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Username";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(605, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(509, 149);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 37);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(508, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // tbContact
            // 
            this.tbContact.BeepOnError = true;
            this.tbContact.Culture = new System.Globalization.CultureInfo("");
            this.tbContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(773, 177);
            this.tbContact.Mask = "000000000000";
            this.tbContact.Name = "tbContact";
            this.tbContact.PromptChar = ' ';
            this.tbContact.ResetOnSpace = false;
            this.tbContact.Size = new System.Drawing.Size(386, 29);
            this.tbContact.TabIndex = 4;
            this.tbContact.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbEmail
            // 
            // 
            // 
            // 
            this.tbEmail.CustomButton.Image = null;
            this.tbEmail.CustomButton.Location = new System.Drawing.Point(360, 1);
            this.tbEmail.CustomButton.Name = "";
            this.tbEmail.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEmail.CustomButton.TabIndex = 1;
            this.tbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEmail.CustomButton.UseSelectable = true;
            this.tbEmail.CustomButton.Visible = false;
            this.tbEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbEmail.Lines = new string[0];
            this.tbEmail.Location = new System.Drawing.Point(773, 385);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PromptText = "Mentor@example.com";
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.ShortcutsEnabled = true;
            this.tbEmail.Size = new System.Drawing.Size(388, 29);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.UseSelectable = true;
            this.tbEmail.WaterMark = "Mentor@example.com";
            this.tbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // cbGender
            // 
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.ItemHeight = 23;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Rather not say"});
            this.cbGender.Location = new System.Drawing.Point(773, 277);
            this.cbGender.Name = "cbGender";
            this.cbGender.PromptText = "example: Male";
            this.cbGender.Size = new System.Drawing.Size(387, 29);
            this.cbGender.Style = MetroFramework.MetroColorStyle.Green;
            this.cbGender.TabIndex = 7;
            this.metroToolTip.SetToolTip(this.cbGender, "Select gender");
            this.cbGender.UseSelectable = true;
            // 
            // tbLastName
            // 
            // 
            // 
            // 
            this.tbLastName.CustomButton.Image = null;
            this.tbLastName.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbLastName.CustomButton.Name = "";
            this.tbLastName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLastName.CustomButton.TabIndex = 1;
            this.tbLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLastName.CustomButton.UseSelectable = true;
            this.tbLastName.CustomButton.Visible = false;
            this.tbLastName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbLastName.Lines = new string[0];
            this.tbLastName.Location = new System.Drawing.Point(774, 71);
            this.tbLastName.MaxLength = 32767;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PromptText = "Last";
            this.tbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLastName.SelectedText = "";
            this.tbLastName.SelectionLength = 0;
            this.tbLastName.SelectionStart = 0;
            this.tbLastName.ShortcutsEnabled = true;
            this.tbLastName.Size = new System.Drawing.Size(387, 29);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.UseSelectable = true;
            this.tbLastName.WaterMark = "Last";
            this.tbLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // tbFirstName
            // 
            // 
            // 
            // 
            this.tbFirstName.CustomButton.Image = null;
            this.tbFirstName.CustomButton.Location = new System.Drawing.Point(359, 1);
            this.tbFirstName.CustomButton.Name = "";
            this.tbFirstName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirstName.CustomButton.TabIndex = 1;
            this.tbFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFirstName.CustomButton.UseSelectable = true;
            this.tbFirstName.CustomButton.Visible = false;
            this.tbFirstName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbFirstName.Lines = new string[0];
            this.tbFirstName.Location = new System.Drawing.Point(184, 71);
            this.tbFirstName.MaxLength = 32767;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PromptText = "First";
            this.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.SelectionLength = 0;
            this.tbFirstName.SelectionStart = 0;
            this.tbFirstName.ShortcutsEnabled = true;
            this.tbFirstName.Size = new System.Drawing.Size(387, 29);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.UseSelectable = true;
            this.tbFirstName.WaterMark = "First";
            this.tbFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.Black;
            this.tbUserName.Location = new System.Drawing.Point(183, 177);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(387, 29);
            this.tbUserName.TabIndex = 3;
            // 
            // lbuserName
            // 
            this.lbuserName.AutoSize = true;
            this.lbuserName.BackColor = System.Drawing.Color.Transparent;
            this.lbuserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserName.ForeColor = System.Drawing.Color.Black;
            this.lbuserName.Location = new System.Drawing.Point(179, 154);
            this.lbuserName.Name = "lbuserName";
            this.lbuserName.Size = new System.Drawing.Size(81, 21);
            this.lbuserName.TabIndex = 54;
            this.lbuserName.Text = "Username";
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.BackColor = System.Drawing.Color.Transparent;
            this.lbContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.ForeColor = System.Drawing.Color.Black;
            this.lbContact.Location = new System.Drawing.Point(769, 153);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(63, 21);
            this.lbContact.TabIndex = 52;
            this.lbContact.Text = "Contact";
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.BackColor = System.Drawing.Color.Transparent;
            this.genderlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.ForeColor = System.Drawing.Color.Black;
            this.genderlabel.Location = new System.Drawing.Point(769, 253);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(61, 21);
            this.genderlabel.TabIndex = 53;
            this.genderlabel.Text = "Gender";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(769, 361);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(163, 21);
            this.emailLabel.TabIndex = 49;
            this.emailLabel.Text = "Current email address";
            // 
            // lbEMPName
            // 
            this.lbEMPName.AutoSize = true;
            this.lbEMPName.BackColor = System.Drawing.Color.Transparent;
            this.lbEMPName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEMPName.ForeColor = System.Drawing.Color.Black;
            this.lbEMPName.Location = new System.Drawing.Point(179, 39);
            this.lbEMPName.Name = "lbEMPName";
            this.lbEMPName.Size = new System.Drawing.Size(52, 21);
            this.lbEMPName.TabIndex = 39;
            this.lbEMPName.Text = "Name";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.AllowDrop = true;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmPassword.Location = new System.Drawing.Point(184, 385);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(387, 29);
            this.tbConfirmPassword.TabIndex = 6;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // tbPassword
            // 
            this.tbPassword.AllowDrop = true;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HideSelection = false;
            this.tbPassword.Location = new System.Drawing.Point(183, 277);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(387, 29);
            this.tbPassword.TabIndex = 5;
            this.metroToolTip.SetToolTip(this.tbPassword, "Password at least 6 long");
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(180, 253);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(138, 21);
            this.passwordLabel.TabIndex = 51;
            this.passwordLabel.Text = "Create a password";
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassLabel.ForeColor = System.Drawing.Color.Black;
            this.confirmPassLabel.Location = new System.Drawing.Point(180, 361);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(142, 21);
            this.confirmPassLabel.TabIndex = 50;
            this.confirmPassLabel.Text = "Confirm  password";
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
            // metroToolTip
            // 
            this.metroToolTip.AutomaticDelay = 200;
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.btnBacktoWindow.Location = new System.Drawing.Point(1, -1);
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
            // _RegisterPanel
            // 
            this._RegisterPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._RegisterPanel.Controls.Add(this.btnClose);
            this._RegisterPanel.Controls.Add(this.btnMaximize);
            this._RegisterPanel.Controls.Add(this.btnMinimize);
            this._RegisterPanel.Controls.Add(this.btnBacktoWindow);
            this._RegisterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this._RegisterPanel.Name = "_RegisterPanel";
            this._RegisterPanel.Size = new System.Drawing.Size(1360, 45);
            this._RegisterPanel.TabIndex = 36;
            this._RegisterPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this._RegisterPanel_MouseDown);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Project_Management_System.Properties.Resources.softwareBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 752);
            this.Controls.Add(this._RegisterPanel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._RegisterPanel_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this._PanelAdmin.ResumeLayout(false);
            this._PanelAdmin.PerformLayout();
            this._RegisterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnBacktoWindow;
        private System.Windows.Forms.Panel _RegisterPanel;
        private System.Windows.Forms.MaskedTextBox tbContact;
        private MetroFramework.Controls.MetroTextBox tbEmail;
        private MetroFramework.Controls.MetroComboBox cbGender;
        private MetroFramework.Controls.MetroTextBox tbLastName;
        private MetroFramework.Controls.MetroTextBox tbFirstName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbuserName;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lbEMPName;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Panel _PanelAdmin;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroTextBox tbAdminPassword;
        private MetroFramework.Controls.MetroTextBox tbAdminUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}