namespace Project_Management_System
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.projectProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.logoPicPanel = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectProgressBar
            // 
            this.projectProgressBar.Location = new System.Drawing.Point(23, 154);
            this.projectProgressBar.MarqueeAnimationSpeed = 50;
            this.projectProgressBar.Name = "projectProgressBar";
            this.projectProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.projectProgressBar.Size = new System.Drawing.Size(434, 18);
            this.projectProgressBar.TabIndex = 0;
            // 
            // logoPicPanel
            // 
            this.logoPicPanel.BackgroundImage = global::Project_Management_System.Properties.Resources.logo;
            this.logoPicPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPicPanel.HorizontalScrollbarBarColor = true;
            this.logoPicPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.logoPicPanel.HorizontalScrollbarSize = 10;
            this.logoPicPanel.Location = new System.Drawing.Point(83, 37);
            this.logoPicPanel.Name = "logoPicPanel";
            this.logoPicPanel.Size = new System.Drawing.Size(295, 100);
            this.logoPicPanel.TabIndex = 1;
            this.logoPicPanel.VerticalScrollbarBarColor = true;
            this.logoPicPanel.VerticalScrollbarHighlightOnWheel = false;
            this.logoPicPanel.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading...";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPicPanel);
            this.Controls.Add(this.projectProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplashScreen";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar projectProgressBar;
        private MetroFramework.Controls.MetroPanel logoPicPanel;
        private System.Windows.Forms.Label label1;
    }
}