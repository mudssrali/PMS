using System;
using System.Windows.Forms;
using System.Drawing;
using Project_Management_System.Properties;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.IO;
using System.Diagnostics;
using static System.Environment;

namespace Project_Management_System
{
    public partial class ManagerDashboard : Form
    {
        string UserNameShow = "";
        public ManagerDashboard(string str)
        {
            InitializeComponent();
            UserNameShow = str.ToUpper();
            lbMangerName.Text = "Hi " + UserNameShow;
            _PanelSettings.Hide();
            _PanelViewProjectStatus.Hide();
            _PanelViewComments.Hide();
            _PanelReport.Hide();

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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        /*
         * Showing login form
        */
        private void PMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        /*
         * Flag variables
        */
        int btnProjectWasClicked = 0;
        int btnEMPWasClicked = 0;
        int btnTaskWasClicked = 0;
        int btnTeamWasClicked = 0;
        int btnCustomerWasClicked = 0;
        /*
         * Menu
        */
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (btnSet == 1)
            {
                Util.Animate(_PanelSettings, Util.Effect.Slide, 100, 360);
                btnSet = 0;
            }
            Util.Animate(_PanelMenu, Util.Effect.Roll, 100, 360);
            Util.Animate(_PanelSubMenu, Util.Effect.Roll, 100, 360);
        }
        /*
         * Back button Home to Menu 
        */
        private void _btnCancel_Click(object sender, EventArgs e)
        {

            /*
            * Calling return to state function 
            */
            _ReturnToState();
            /*
             * Returning to Menu Button 
            */
            Util.Animate(_PanelSubMenu, Util.Effect.Slide, 100, 360);
            Util.Animate(_PanelMenu, Util.Effect.Slide, 100, 360);
        }
        /*
         *  Sub Menu for project
        */


        private void btnProject_Click(object sender, EventArgs e)
        {
            /*
             * Closing Employee Sub menu if open 
            */
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 100, 0);
                btnEMPWasClicked = 0;
            }
            /*
             * Closing Tasks Sub menu 
            */
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 100, 360);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }

            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }
            /*
             * To close View project progress 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 200, 360);
                btnVPS = 0;
            }
            /*
             * Btn comments close 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 250, 360);
                btnVR = 0;
            }
            /*
             * Showing project sub menu
            */

            Util.Animate(_Panel_SubProj, Util.Effect.Slide, 100, 360);
            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                btnProjectWasClicked = 0;
            }
            else
            {
                btnProject.BackColor = Color.Silver;
                btnProjectWasClicked = 1;
            }
        }
        /*
         * Sub Menu for Employee 
        */
        private void btnEMP_Click(object sender, EventArgs e)
        {
            /*
             * Closing Project Sub menu if open 
            */
            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 100, 0);
                btnProjectWasClicked = 0;
            }
            /*
             * Closing Tasks Sub menu 
            */
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 100, 360);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }
            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }
            /*
             * To close View project progress 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 250, 360);
                btnVPS = 0;
            }
            /*
             * Btn comments close 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 250, 360);
                btnVR = 0;
            }
            /*
             *  Showing emp sub menu
            */
            Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 100, 360);
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                btnEMPWasClicked = 0;
            }
            else
            {
                btnEMP.BackColor = Color.Silver;
                btnEMPWasClicked = 1;
            }

        }

        /*
         * Sub menu for Task
        */
        private void btnTasks_Click(object sender, EventArgs e)
        {
            /*
             * Closing Project Sub menu if open 
            */

            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 100, 0);
                btnProjectWasClicked = 0;
            }
            /*
             * Closing Employee Sub menu if open 
            */
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 100, 0);
                btnEMPWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }

            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }
            /*
             * To close View project progress 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 250, 360);
                btnVPS = 0;
            }
            /*
             * Btn comments close 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 250, 360);
                btnVR = 0;
            }
            /*
             * Showing Sub Task Menu 
            */

            Util.Animate(_PanelSubTask, Util.Effect.Slide, 100, 360);
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                btnTaskWasClicked = 0;
            }
            else
            {
                btnTask.BackColor = Color.Silver;
                btnTaskWasClicked = 1;
            }
        }
        /*
         *  Team Menu
        */
        private void btnTeam_Click(object sender, EventArgs e)
        {

            /*
           * Closing Project Sub Menu 
          */
            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 50, 0);
                btnProjectWasClicked = 0;
            }
            /*
             * Closing Employee Sub Menu 
            */
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 50, 0);
                btnEMPWasClicked = 0;
            }
            /*
             * Closing Task Sub Menu 
            */
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 50, 0);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }
            /*
             * To close View project progress 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 250, 360);
                btnVPS = 0;
            }
            /*
             * Btn comments close 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 100, 360);
                btnVR = 0;
            }
            /*
             * Showing team sub menu 
            */
            Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                btnTeamWasClicked = 0;
            }
            else
            {
                btnTeam.BackColor = Color.Silver;
                btnTeamWasClicked = 1;
            }
        }
        /*
         * Customer  
        */
        private void btnCustomer_Click(object sender, EventArgs e)
        {

            /*
             * Closing Project Sub Menu 
            */
            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 50, 0);
                btnProjectWasClicked = 0;
            }
            /*
             * Closing Employee Sub Menu 
            */
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 50, 0);
                btnEMPWasClicked = 0;
            }
            /*
             * Closing Task Sub Menu 
            */
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 50, 0);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }
            /*
             * To close View project progress 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 250, 360);
                btnVPS = 0;
            }
            /*
             * Btn comments close 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 250, 360);
                btnVR = 0;
            }
            /*
             * Showing customer sub menu 
            */

            Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                btnCustomerWasClicked = 0;
            }
            else
            {
                btnCustomer.BackColor = Color.Silver;
                btnCustomerWasClicked = 1;
            }
        }

        /*
         * ALL SUB MENU FUNCTIONALITIES (Projects,Employees, Tasks, Teams and Customers)
        */


        /*
         * Show All projects
        */
        private void btnViewProj_Click(object sender, EventArgs e)
        {
            ViewProject newForm = new ViewProject();
            newForm.Owner = this;
            newForm.Show();
            _ReturnToState();      // To return initial states of menu
            this.Hide();
        }
        /*
         * Add project
        */
        private void btnAddProj_Click(object sender, EventArgs e)
        {
            Add_Project _AddProj = new Add_Project();
            _AddProj.Owner = this;
            _AddProj.Show();

            _ReturnToState();      // To return initial states of menu

            this.Hide();
        }
        /*
         * View All employee
        */
        private void btnViewEmp_Click(object sender, EventArgs e)
        {

            ViewEMP newForm = new ViewEMP();
            newForm.Owner = this;
            newForm.Show();
            _ReturnToState();      // To return initial states of menu
            this.Hide();

        }
        /*
         * Add employee
        */
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployee _AddEMP = new AddEmployee();
            _AddEMP.Owner = this;
            _AddEMP.Show();

            _ReturnToState();      // To return initial states of menu

            this.Hide();

        }
        /*
         * Showing All Tasks 
        */
        private void btnViewTask_Click_1(object sender, EventArgs e)
        {
            ViewTask newForm = new ViewTask();
            newForm.Owner = this;
            newForm.Show();
            _ReturnToState();      // To return initial states of menu
            this.Hide();
        }
        /*
         * Add task
        */
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Add_Task _AddTask = new Add_Task();
            _AddTask.Owner = this;
            _AddTask.Show();

            _ReturnToState();      // To return initial states of menu

            this.Hide();
        }

        /*
         * View all teams  button
        */
        private void btnViewTeam_Click(object sender, EventArgs e)
        {
            ViewTeam newForm = new ViewTeam();
            newForm.Owner = this;
            newForm.Show();
            _ReturnToState();      // To return initial states of menu
            this.Hide();
        }
        /*
         * Add a team button 
        */
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            AddTeam newForm = new AddTeam();
            newForm.Owner = this;
            newForm.Show();
            _ReturnToState();      // To return initial states of menu
            this.Hide();
        }
        /*
         *  View customer button
        */
        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            ViewCustomer newForm = new ViewCustomer();
            newForm.Owner = this;
            newForm.Show();
            _ReturnToState();      // To return initial states of menu
            this.Hide();
        }
        /*
         * Add customer button
        */
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCust = new AddCustomer();
            addCust.Owner = this;
            addCust.Show();
            _ReturnToState(); // Closing current open sub menu
            this.Hide();
        }


        /*
         * CLosing other sub menu before going to next form
        */

        private void _ReturnToState()
        {
            btnProject.BackColor = Color.Transparent;
            btnEMP.BackColor = Color.Transparent;
            btnCustomer.BackColor = Color.Transparent;
            btnTask.BackColor = Color.Transparent;
            btnTeam.BackColor = Color.Transparent;

            /*
            * Closing Project Sub Menu 
           */
            if (btnProjectWasClicked == 1)
            {
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 50, 0);
                btnProjectWasClicked = 0;
            }
            /*
             * Closing Employee Sub Menu 
            */
            if (btnEMPWasClicked == 1)
            {
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 50, 0);
                btnEMPWasClicked = 0;
            }
            /*
             * Closing Task Sub Menu 
            */
            if (btnTaskWasClicked == 1)
            {
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 50, 0);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }

            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }
            /*
             * Btn project progress close 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 250, 360);
                btnVPS = 0;
            }
            /*
             * Btn comments close 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 250, 360);
                btnVR = 0;
            }
        }
        /*
         * Manager Settings 
        */
        int btnSet = 0;
        private void btnSettings_Click(object sender, EventArgs e)
        {
            _PanelSettings.Height = 675;
            _PanelSettings.Width = 1184;
            if (btnSet == 0)
            {
                Util.Animate(_PanelSettings, Util.Effect.Slide, 200, 360);
                btnSet = 1;
            }
            else
            {
                Util.Animate(_PanelSettings, Util.Effect.Slide, 200, 360);
                btnSet = 0;
            }
        }
        /*
         * Methods for form button 
        */
        private void btnBackToLogWin_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                using (var waitForm = new LogoutWait(Save))
                {
                    waitForm.ShowDialog(this);
                }
                this.Close();
            }
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Exit application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /*
         * To make moveable form 
        */
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
        /*
         * Form load event 
        */
        private void ManagerDashboard_Load(object sender, EventArgs e)
        {

            dg1.BorderStyle = BorderStyle.None;
            dg1.EnableHeadersVisualStyles = false;
            dg1.GridColor = Color.Black;
            dg1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dg1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
        }

        /*
         * Mehtod to update password 
        */
        //sleep Thread
        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);
            }
        }

        private void btnSavePasswordChanges_Click(object sender, EventArgs e)
        {
            if (oldPasswordFlag == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter correct old password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbPassword.Clear();
                tbConfirmPassword.Clear();
            }
            else if (tbPassword.Text.Length < 6)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password at least 6 character long!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbPassword.Clear();
                tbConfirmPassword.Clear();
            }
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password doesn't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbPassword.Clear();
                tbConfirmPassword.Clear();
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to change password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    adap.UpdateCommand = new SqlCommand("Update Login SET PASSWORD = @PASSWORD where username ='" + UserNameShow + "'", con);
                    adap.UpdateCommand.Parameters.AddWithValue("@Password", Cryptor.Encrypt(tbPassword.Text, true, "manz"));
                    con.Open();
                    int queryResult = adap.UpdateCommand.ExecuteNonQuery();
                    con.Close();
                    using (var waitForm = new UpdatingWait(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                    if (queryResult == 1)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Your password has been changed successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            using (var waitForm = new LogoutWait(Save))
                            {
                                waitForm.ShowDialog(this);
                            }
                            this.Close();
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Updation failed, Try again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    tbOldPassword.Clear();
                    tbOldPassword.Clear();
                    tbConfirmPassword.Clear();
                }
            }
        }
        /*
         * Cancel changes 
        */
        private void btnCancelPasswordChanges_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                tbOldPassword.Clear();
                tbOldPassword.Clear();
                tbConfirmPassword.Clear();
                if (btnSet == 1)
                {
                    Util.Animate(_PanelSettings, Util.Effect.Centre, 300, 360);
                    btnSet = 0;
                }
            }
        }
        /*
         * Validating password fields 
        */
        bool oldPasswordFlag = false;

        private void tbOldPassword_Leave(object sender, EventArgs e)
        {
            adap.SelectCommand = new SqlCommand("Select password from login where username='" + UserNameShow + "'", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (Cryptor.Decrypt(dt.Rows[0][0].ToString(), true, "manz") != tbOldPassword.Text)
            {
                lbOldPassword.ForeColor = Color.Red;
                lbError.Visible = true;
            }
            else
            {
                lbOldPassword.ForeColor = Color.Black;
                oldPasswordFlag = true;
                lbError.Visible = false;
            }
            if (tbOldPassword.Text.Length == 0)
            {
                lbOldPassword.ForeColor = Color.Black;
                lbError.Visible = false;
                oldPasswordFlag = false;
            }

        }

        private void tbOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbOldPassword.Text.Length == 0)
            {
                lbOldPassword.ForeColor = Color.Black;
                lbError.Visible = false;
                oldPasswordFlag = false;
            }
        }

        /*
         * Method to fill Project Combo box 
        */
        void fillProjectCB()
        {
            cbSelectProject.Items.Clear();
            cbSelectProject1.Items.Clear();
            string query = "SELECT *FROM PROJECT";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            string sName1 = "";
            string sName2 = "";
            try
            {
                while (dr.Read())
                {
                    sName1 = Convert.ToString(dr.GetValue(0));
                    sName2 = dr.GetString(1);
                    cbSelectProject.Items.Add(sName1 + " " + sName2);
                    cbSelectProject1.Items.Add(sName1 + " " + sName2);
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        /*
         * Filling commentonEMP combo box 
        */
        void fillCBEMP(string Id)
        {
            cbCommentOnEMP.Items.Clear();
            string query = "SELECT e.EmpID, e.EmpfirstName+' '+e.EmplastName FROM EMPLOYEE e, Project p,TeamMember tm where p.teamID = tm.teamID and e.empId=tm.empid and p.projectid='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            string sName1 = "";
            string sName2 = "";
            try
            {
                while (dr.Read())
                {
                    sName1 = Convert.ToString(dr.GetValue(0));
                    sName2 = dr.GetString(1);
                    cbCommentOnEMP.Items.Add(sName1 + " " + sName2);

                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }

        /*
         * Method to select project for comments
        */
        int btn = 0;
        private void cbSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ProjectSelected = true;
            if (btn == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
            }
            else
            {
                btn = 1;
            }
            string Id = cbSelectProject.Text.Substring(0, cbSelectProject.Text.IndexOf(' '));
            fillCBEMP(Id);
            SqlCommand cmd = new SqlCommand("SELECT e.EMPFirstName+' '+e.EMPLastName, t.Progress FROM PROJECT p, TASK t,EMPLOYEE e where Convert(Varchar,p.projectid) = '" + Id + "' and p.projectid = t.projectid and t.empid = e.empid", con);
            adap.SelectCommand = new SqlCommand("SELECT t.TeamID,t.TeamName, p.projectName, p.Status FROM TEAM t,PROJECT p where p.TeamID =t.TeamID and  Convert(Varchar,p.projectid)='" + Id + "'", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            int _TProgress = 0;
            int projProgress = 0;
            int count = 0;
            string _EmpName = "";
            string _TeamName = dt.Rows[0][1].ToString();
            string _TeamID = dt.Rows[0][0].ToString();
            string _ProjID = Id;
            string _ProjName = dt.Rows[0][2].ToString();
            string _ProjStatus = dt.Rows[0][3].ToString();

            string dir =  Environment.GetFolderPath(SpecialFolder.ApplicationData);
            string file = dir + @"\\tempReport.txt";
            if (Directory.Exists(Path.GetDirectoryName(file)))
            {
                File.Delete(file);
            }
            using (StreamWriter _CWrite = File.AppendText(file))
            {
                _CWrite.WriteLine("********************** PROJECT REPORT **********************");
                _CWrite.WriteLine();
                _CWrite.WriteLine("              " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                _CWrite.WriteLine();
                _CWrite.WriteLine("              ****** Project Information *******    ");
                _CWrite.WriteLine(" Project ID     : " + _ProjID);
                _CWrite.WriteLine(" Project Name   : " + _ProjName);
                _CWrite.WriteLine(" Project Status : " + _ProjStatus);
                _CWrite.WriteLine();
                _CWrite.WriteLine("              ****** Team Information *******    ");
                _CWrite.WriteLine(" Team ID  : " + _TeamID);
                _CWrite.WriteLine(" Team Name: " + _TeamName);
                _CWrite.WriteLine();
                _CWrite.WriteLine(" Team Members:");
            }
            try
            {
                while (dr.Read())
                {

                    _EmpName = dr.GetString(0);
                    _TProgress = Convert.ToInt32(dr.GetValue(1));
                    chartProjectProgress.Series["Task"].Points.AddXY(_EmpName, _TProgress);
                    projProgress += _TProgress;
                    count++;
                    using (StreamWriter _CWrite = File.AppendText(file))
                    {
                        _CWrite.WriteLine(String.Format(" {0,-30}{1:0}%", _EmpName, _TProgress));
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            con.Close();
            try
            {
                CharProjectProgress.Series["Project"].Points.AddXY("Completion", (projProgress / count));
                CharProjectProgress.Series["Project"].Points.AddXY("Remaining", (100 - projProgress / count));
                using (StreamWriter _CWrite = File.AppendText(file))
                {
                    _CWrite.WriteLine();
                    _CWrite.WriteLine("              ****** Project Progress *******    ");
                    _CWrite.WriteLine("Completed: " + (projProgress / count).ToString() + "%");
                    _CWrite.WriteLine("Remaining: " + (100 - (projProgress / count)).ToString() + "%");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Project is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        /*
         * Method to view project preogress 
        */
        int btnVPS = 0;
        private void btnViewProjectStatus_Click(object sender, EventArgs e)
        {
            /*
             * Closing Project Sub menu if open 
            */

            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 50, 0);
                btnProjectWasClicked = 0;
            }
            /*
             * Closing Employee Sub menu if open 
            */
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 50, 0);
                btnEMPWasClicked = 0;
            }
            /*
            * Closing Task Sub Menu 
            */
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 50, 0);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }
            /*
             * To close view comment 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 100, 360);
                btnVR = 0;
            }

            CommentTools();
            fillProjectCB();
            _PanelViewProjectStatus.Height = 685;
            _PanelViewProjectStatus.Width = 1186;

            if (btnVPS == 0)
            {
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Slide, 200, 360);
                btnVPS = 1;
            }
            else
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Slide, 200, 360);
                btnVPS = 0;
            }

        }
        /*
         * Methods related to comments 
        */
        private void CommentTools()
        {
            lbSelectEMP.Visible = false;
            cbCommentOnEMP.Visible = false;
            lbWriteComment.Visible = false;
            tbComment.Clear();
            tbComment.Visible = false;
            btnSaveComment.Visible = false;
            btnCancelComment.Visible = false;
        }
        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)
            {
                lbSelectEMP.Visible = true;
                cbCommentOnEMP.Visible = true;
            }
            else
            {
                CommentTools();
            }
        }

        private void cbCommentOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbComment.Clear();
            lbWriteComment.Visible = true;
            tbComment.Visible = true;
            btnSaveComment.Visible = true;
            btnCancelComment.Visible = true;
        }

        private void btnSaveComment_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to comment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int j = 0;
                string pID = cbSelectProject.Text.Substring(0, cbSelectProject.Text.IndexOf(' '));
                string empID = cbCommentOnEMP.Text.Substring(0, cbCommentOnEMP.Text.IndexOf(' '));
                string tID = string.Empty;
                adap.SelectCommand = new SqlCommand("Select t.taskid from task t, project p, employee e where p.projectid ='" + pID + "' and e.empid='" + empID + "' and t.projectid = p.projectid and t.empid = e.empid", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                tID = dt.Rows[0][0].ToString();
                string data = "INSERT Comment values(@TaskID,@CommentDate,@Description)";
                SqlCommand insertData = new SqlCommand(data, con);
                insertData.Parameters.AddWithValue("@TaskID", Convert.ToInt32(tID));
                insertData.Parameters.Add("@CommentDate", SqlDbType.Date).Value = DateTime.Now.Date;
                insertData.Parameters.AddWithValue("@Description", "Manager:" + tbComment.Text);
                try
                {
                    con.Open();
                    j = insertData.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
                con.Close();
                using (var waitForm = new SendingWait(Save))
                {
                    waitForm.ShowDialog(this);
                }
                if (j == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Comment has been sent successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelComment_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                rbtnYes.Checked = false;
                CommentTools();
            }
        }
        /*
         * Button View Comment methods 
        */
        int btnVC = 0;
        private void btnViewComments_Click(object sender, EventArgs e)
        {
            /*
             * Closing Project Sub menu if open 
            */

            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 50, 0);
                btnProjectWasClicked = 0;
            }
            /*
             * Closing Employee Sub menu if open 
            */
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 50, 0);
                btnEMPWasClicked = 0;
            }
            /*
            * Closing Task Sub Menu 
            */
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 50, 0);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }

            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }
            /*
             * To close View project progress 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 250, 360);
                btnVPS = 0;
            }
            /*
             * To close view Report 
            */
            if (btnVR == 1)
            {
                _TbReportContainer.Clear();
                btnReport.BackColor = Color.Transparent;
                Util.Animate(_PanelReport, Util.Effect.Slide, 100, 360);
                btnVR = 0;
            }
            /*
             * Showing comments 
            */
            _PanelViewComments.Height = 685;
            _PanelViewComments.Width = 1186;
            fillProjectCB();
            if (btnVC == 0)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Slide, 200, 360);
                btnVC = 1;
            }
            else
            {
                Util.Animate(_PanelViewComments, Util.Effect.Slide, 200, 360);
                btnVC = 0;
            }
        }
        string Id = "";
        private void cbSelectProject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = cbSelectProject1.Text.Substring(0, cbSelectProject1.Text.IndexOf(' '));
            adap.SelectCommand = new SqlCommand("SELECT c.Commentid as COMMENT_ID,e.EMPID as EMPLOYEE_ID, e.EMPFIRSTNAME +' '+e.EMPLASTNAME As EMPLOYEE_NAME , t.taskid as TASK_ID, t.taskname as TASK_NAME,c.CommentDate as COMMENT_DATE, c.Description as COMMENT_DESCRIPTION from comment c,project p , EMPloyee e, task t  where p.projectId = '" + Id + "' and t.EMPID=e.EMPID and c.taskid = t.taskid and t.projectID = p.projectID", con);
            ds.Clear();
            adap.Fill(ds);
            dg1.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            if (bs.Count > 0)
            {
                bs.MoveFirst();
                updateGrid();
            }
        }
        /*
         *  Previous Record button
        */
        private void btnPreviousC_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.MovePrevious();
            updateGrid();
            rowCount();
        }

        /*
         *  First Record button
        */
        private void btnFirstC_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.MoveFirst();
            updateGrid();
            rowCount();
        }

        /*
         *  Next Record button
        */
        private void btnNextC_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.MoveNext();
            updateGrid();
            rowCount();
        }

        /*
         *  Last Record button
        */
        private void btnLastC_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.MoveLast();
            updateGrid();
            rowCount();
        }

        /*
         *  Upgrade data grid Records selection 
        */
        private void updateGrid()
        {
            dg1.FirstDisplayedScrollingRowIndex = bs.Position;
            dg1.ClearSelection();
            if (bs.Count > 0)
                dg1.Rows[bs.Position].Selected = true;
            rowCount();
        }
        /*
         * Counting records in data grid 
        */
        private void rowCount()
        {
            int count = (bs.Position) + 1;
            lbCount.Text = "Record " + count + " of" + (bs.Count);
        }
        /*
         * Method to delete comment 
        */
        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure delete comment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (dg1.Rows[bs.Position].Selected == true)
                {
                    string Id1 = (ds.Tables[0].Rows[bs.Position][0]).ToString();
                    adap.DeleteCommand = new SqlCommand("Delete From Comment WHERE Convert(Varchar,CommentID)='" + Id1 + "'", con);
                    con.Open();
                    adap.DeleteCommand.ExecuteNonQuery();
                    con.Close();
                    using (var waitForm = new DeleteWait(Save))
                    {
                        waitForm.ShowDialog(this);

                    }
                    if (MetroFramework.MetroMessageBox.Show(this, "Record has been Deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        adap.SelectCommand = new SqlCommand("SELECT c.Commentid as COMMENT_ID,e.EMPID as EMPLOYEE_ID, e.EMPFIRSTNAME +' '+e.EMPLASTNAME As EMPLOYEE_NAME , t.taskid as TASK_ID, t.taskname as TASK_NAME,c.CommentDate as COMMENT_DATE, c.Description as COMMENT_DESCRIPTION from comment c,project p , EMPloyee e, task t  where p.projectId = '" + Id + "' and t.EMPID=e.EMPID and c.taskid = t.taskid and t.projectID = p.projectID", con);
                        ds.Clear();
                        adap.Fill(ds);
                        dg1.DataSource = ds.Tables[0];
                        bs.DataSource = ds.Tables[0];
                        rowCount();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please select the record first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        /*
         * Method for clock 
        */
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("MM-dd-yyyy  hh:mm:ss tt");
        }
        /*
         * Method for creating report 
        */
        bool _ProjectSelected = false;
        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if (_ProjectSelected)
            {
                string dir = Environment.GetFolderPath(SpecialFolder.ApplicationData);
                adap.SelectCommand = new SqlCommand("SELECT MAX(ReportID) from Report", con);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                string id = dt.Rows[0][0].ToString();
                string rN = "Report_" + (Convert.ToInt32(id) + 1);
                string file1 = dir + @"\\tempReport.txt";
                string file2 = dir + @"\\" + rN + ".txt";
                SqlCommand cmd = new SqlCommand("Insert Report Values(@ReportID,@ReportName,@ReportCreationDate)", con);
                cmd.Parameters.AddWithValue("@ReportID", Convert.ToInt32(id) + 1);
                cmd.Parameters.AddWithValue("@ReportName", rN);
                cmd.Parameters.AddWithValue("@ReportCreationDate", DateTime.Now.Date);
                try
                {
                    using (var waitForm = new Waitform(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    File.Copy(file1, file2);
                    if (MetroFramework.MetroMessageBox.Show(this, "Report has been created with following name " + rN, "Information", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                    }
                }
                catch (SqlException ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
            
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select project first", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /*
         * Method to view reports 
        */
        int btnVR = 0;
        private void btnReport_Click(object sender, EventArgs e)
        {
            _FillReportComboBox();
            /*
            * Closing Project Sub menu if open 
           */
            if (btnProjectWasClicked == 1)
            {
                btnProject.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubProj, Util.Effect.Slide, 100, 0);
                btnProjectWasClicked = 0;
            }
            /*
            * Closing Employee Sub menu if open 
           */
            if (btnEMPWasClicked == 1)
            {
                btnEMP.BackColor = Color.Transparent;
                Util.Animate(_Panel_SubEMP, Util.Effect.Slide, 100, 0);
                btnEMPWasClicked = 0;
            }
            /*
             * Closing Tasks Sub menu 
            */
            if (btnTaskWasClicked == 1)
            {
                btnTask.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTask, Util.Effect.Slide, 100, 360);
                btnTaskWasClicked = 0;
            }
            /*
             * Closing Team sub menu
            */
            if (btnTeamWasClicked == 1)
            {
                btnTeam.BackColor = Color.Transparent;
                Util.Animate(_PanelSubTeam, Util.Effect.Slide, 100, 360);
                btnTeamWasClicked = 0;
            }

            /*
             * Closing Customer Sub menu 
            */
            if (btnCustomerWasClicked == 1)
            {
                btnCustomer.BackColor = Color.Transparent;
                Util.Animate(_PanelSubCustomer, Util.Effect.Slide, 100, 360);
                btnCustomerWasClicked = 0;
            }

            /*
             * To close View project progress 
            */
            if (btnVPS == 1)
            {
                chartProjectProgress.Series["Task"].Points.Clear();
                CharProjectProgress.Series["Project"].Points.Clear();
                cbSelectProject.Items.Clear();
                _ProjectSelected = false;
                Util.Animate(_PanelViewProjectStatus, Util.Effect.Centre, 200, 360);
                btnVPS = 0;
            }
            /*
             * Btn comments close 
            */
            if (btnVC == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 200, 360);
                btnVC = 0;
                ds.Clear();
                lbCount.Text = string.Empty;
            }
            /*
             * Showing View Report Panel
            */
            Util.Animate(_PanelReport, Util.Effect.Slide, 100, 360);
            if (btnVR == 1)
            {
                btnReport.BackColor = Color.Transparent;
                btnVR = 0;
            }
            else
            {
                btnReport.BackColor = Color.SkyBlue;
                btnVR= 1;
            }

        }
        /*
         * Method to open report 
        */
        private void _BtnOpenReport_Click(object sender, EventArgs e)
        {
            if (_TbReportContainer.TextLength > 0)
            {
                string dir = Environment.GetFolderPath(SpecialFolder.ApplicationData);
                string file = dir + @"\\" + _TbReportContainer.Text + ".txt";
                Process.Start("NotePad.exe", file);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select the report first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        /*
         * Adding items to _SelectReport combo box 
        */
        void _FillReportComboBox()
        {
            _SelectReport.Items.Clear();
            string query = "SELECT ReportName FROM Report where ReportID>0";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    _SelectReport.Items.Add(dr.GetString(0));
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }

        private void _SelectReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            _TbReportContainer.Clear();
            _TbReportContainer.Text = _SelectReport.Text;
        }

        private void _TbReportContainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
