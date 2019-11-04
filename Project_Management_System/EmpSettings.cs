using Project_Management_System.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class EmpSettings : Form
    {
        public EmpSettings()
        {
            InitializeComponent();
        }
        /*
         * Method to click on icon to show the form 
        */
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x20000;

                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                return cp;
            }
        }
        private void EmpSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);
            }
        }
        private void btnChangeUserName_Click(object sender, EventArgs e)
        {
            _PanelChangeUserName.BringToFront();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            _PanelChangePassword.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var waitForm = new Waitform(Save))
            {
                waitForm.ShowDialog(this);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
          if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes);
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        bool flag = true;
        Image restore = Resources.Restore;
        Image maximize = Resources.Maximize;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (flag)
            {

                btnMaximize.Image = maximize;
                WindowState = FormWindowState.Normal;
                flag = false;
            }
            else
            {
                btnMaximize.Image = restore;
                WindowState = FormWindowState.Maximized;
                flag = true;
            }

        }

        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           MetroFramework.MetroMessageBox.Show(this, "Please press logout button!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
