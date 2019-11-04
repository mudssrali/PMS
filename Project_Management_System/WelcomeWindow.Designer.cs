namespace Project
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.SliderTime = new System.Windows.Forms.Timer(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.LoginWindow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCopyRight = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SliderTime
            // 
            this.SliderTime.Enabled = true;
            this.SliderTime.Interval = 2500;
            this.SliderTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(384, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(648, 42);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "PROJECT MANAGEMENT SYSTEM";
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.White;
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.FlatAppearance.BorderSize = 0;
            this.createAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.createAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.Black;
            this.createAccountButton.Location = new System.Drawing.Point(1269, 6);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(85, 33);
            this.createAccountButton.TabIndex = 1;
            this.createAccountButton.Text = "Register";
            this.metroToolTip.SetToolTip(this.createAccountButton, "Create Account");
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // LoginWindow
            // 
            this.LoginWindow.AccessibleName = "LoginWindow";
            this.LoginWindow.BackColor = System.Drawing.Color.White;
            this.LoginWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginWindow.FlatAppearance.BorderSize = 0;
            this.LoginWindow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.LoginWindow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.LoginWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginWindow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWindow.ForeColor = System.Drawing.Color.Black;
            this.LoginWindow.Location = new System.Drawing.Point(1177, 6);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(85, 33);
            this.LoginWindow.TabIndex = 0;
            this.LoginWindow.Text = "Login";
            this.metroToolTip.SetToolTip(this.LoginWindow, "Login");
            this.LoginWindow.UseVisualStyleBackColor = false;
            this.LoginWindow.Click += new System.EventHandler(this.LoginWindow_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.LoginWindow);
            this.panel3.Controls.Add(this.createAccountButton);
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 45);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // metroToolTip
            // 
            this.metroToolTip.AutomaticDelay = 200;
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 376);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // lbCopyRight
            // 
            this.lbCopyRight.AutoSize = true;
            this.lbCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lbCopyRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCopyRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyRight.ForeColor = System.Drawing.Color.White;
            this.lbCopyRight.Location = new System.Drawing.Point(572, 693);
            this.lbCopyRight.Name = "lbCopyRight";
            this.lbCopyRight.Size = new System.Drawing.Size(228, 21);
            this.lbCopyRight.TabIndex = 10;
            this.lbCopyRight.Text = "© 2017 Project Management";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.lbCopyRight);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Welcome_Load_1);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer SliderTime;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button LoginWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.Label lbCopyRight;
    }
}

