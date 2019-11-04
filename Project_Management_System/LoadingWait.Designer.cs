namespace Project_Management_System
{
    partial class LoadingWait
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
            this.metroProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // metroProgress
            // 
            this.metroProgress.Location = new System.Drawing.Point(668, 63);
            this.metroProgress.Maximum = 100;
            this.metroProgress.Name = "metroProgress";
            this.metroProgress.Size = new System.Drawing.Size(64, 50);
            this.metroProgress.TabIndex = 0;
            this.metroProgress.UseSelectable = true;
            // 
            // LoadingWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 177);
            this.ControlBox = false;
            this.Controls.Add(this.metroProgress);
            this.Movable = false;
            this.Name = "LoadingWait";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Loading...";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgress;
    }
}