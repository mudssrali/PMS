using Project_Management_System.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class ManagerSettings : Form
    {
        
        public ManagerSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ManagerSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        /*
         * To change username
        */

        private void btnChangeUserName_Click(object sender, EventArgs e)
        { 
            _PanelChangeUserName.BringToFront();

        }

        /*
         * To change userpassword
        */

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            _PanelChangePassword.BringToFront();
        }

        private void ManagerSettings_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
