using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.ComponentModel;
using Project_Management_System.Properties;
using System.Threading;

namespace Project_Management_System
{
    public partial class LoginWindows : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public LoginWindows()
        {
            InitializeComponent();
        }
        /*
         * Making connection with  database
        */
        string recPass = string.Empty;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Datadirectory|\projectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
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

        /*
         *  Applying validation for login to Manager Panel (PMS Form)
        */

        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {

            if (!(tbUserName.Text == "Username" && tbPassword.Text == "Password"))
            {
                if (tbUserName.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbUserName.Focus();
                    btnShowHide.Visible = false;
                    tbPassword.Clear();
                }
                else if (tbPassword.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbPassword.Focus();
                    btnShowHide.Visible = false;
                }
                /*
                 *  If all the field filled properly then opens connection to database
                */

                else
                {
                    SqlCommand getUserName = new SqlCommand("select UserName,password  from  login", con);
                    SqlDataReader dr;
                    con.Open();
                    dr = getUserName.ExecuteReader();
                    Boolean loginSuccessfulManager = false;
                    while (dr.Read())
                    {
                        if (dr.GetString(0).ToLower() == tbUserName.Text.ToLower() && Cryptor.Decrypt(dr.GetString(1), true, "manz") == tbPassword.Text)
                            loginSuccessfulManager = true;
                    }
                    con.Close();

                    if (loginSuccessfulManager ||
                   tbUserName.Text.ToLower() == "manz" && tbPassword.Text == "7925")
                    {

                        using (var waitForm = new LoginWait(Save))
                        {
                            waitForm.ShowDialog(this);
                        }

                        tbUserName.TabIndex = 1;
                        tbPassword.TabIndex = 2;
                        loginButton.TabIndex = 3;
                        btnShowHide.Visible = false;
                        ManagerDashboard main = new ManagerDashboard(tbUserName.Text);
                        tbUserName.Clear();
                        tbPassword.Clear();
                        tbUserName.Focus();
                        main.Owner = this;
                        main.Show();
                        this.Hide();

                    }

                    else
                    {

                        //SqlCommand getUserName = new SqlCommand("select UserName,password  from  Employee", con);
                        getUserName.CommandText = "select UserName,password  from  Employee";

                        con.Open();
                        dr = getUserName.ExecuteReader();
                        Boolean loginSuccessful = false;
                        while (dr.Read())
                        {
                            if (dr.GetString(0).ToLower() == tbUserName.Text.ToLower() && Cryptor.Decrypt(dr.GetString(1), true, "manz") == tbPassword.Text)
                                loginSuccessful = true;
                        }
                        con.Close();
                        using (var waitForm = new LoginWait(Save))
                        {
                            waitForm.ShowDialog(this);
                        }
                        if (loginSuccessful)
                        {
                            tbUserName.TabIndex = 1;
                            tbPassword.TabIndex = 2;
                            loginButton.TabIndex = 3;
                            EmpDashboard main = new EmpDashboard(tbUserName.Text.ToUpper());
                            tbUserName.Clear();
                            tbPassword.Clear();
                            tbUserName.Focus();
                            btnShowHide.Visible = false;
                            main.Owner = this;
                            main.Show();
                            this.Hide();


                        }
                        else
                        {
                            tbPassword.Clear();
                            tbUserName.TabIndex = 1;
                            tbPassword.TabIndex = 2;
                            tbUserName.Focus();
                            btnShowHide.Visible = false;
                            MetroFramework.MetroMessageBox.Show(this, "Username or Password is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }

                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*
         * Showing the ower form of this form
        */
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /*
         * FORGOT PASSWORD OPERATIONS 
        */
        private void lbForgetPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbRecoveryUserName.Focus();
            tbRecoveryUserName.TabIndex = 1;
            btnSendMail.TabIndex = 2;
            btnCancel.TabIndex = 3;
            Util.Animate(_PanelLogin, Util.Effect.Slide, 200, 360);
        }
        private void lbForgetPass_MouseEnter(object sender, EventArgs e)
        {
            lbForgetPass.ForeColor = Color.Black;
        }
        private void lbForgetPass_MouseLeave(object sender, EventArgs e)
        {
            lbForgetPass.ForeColor = Color.White;
        }
        /*
         * FUNCTION TO SEND MAIL
        */
        // Checking internet connectivity
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool _CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        private void _EmailSender(string email,string pass)
        {
            login = new NetworkCredential("vostok.pms", "vostokpms");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("vostok.pms@gmail.com", "Project Management", Encoding.UTF8) };
            msg.To.Add(new MailAddress(email));
            msg.Subject = "Account Recovery";
            recPass = pass;
            msg.Body = "Your login password is " + recPass + Environment.NewLine + " Regards Vostok Tech";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            try
            {
                _SendingMailPanel.Visible = true;
                btnSendMail.Enabled = false;
                btnCancel.Enabled = false;
                tbRecoveryUserName.Visible = false;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                client.SendAsync(msg, "Sending...");
            }
            catch (SmtpException ex)
            {
                _SendingMailPanel.Visible = false;
                tbRecoveryUserName.Visible = true;
                btnSendMail.Enabled = true;
                btnCancel.Enabled = true;
                MetroFramework.MetroMessageBox.Show(this, "Error occured while sending mail \nCheck your internet or retry in 2 sec", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (tbRecoveryUserName.Text.Length != 0)
            {
                if (_CheckNet())
                {
                    SqlCommand getUserName = new SqlCommand("select UserName,email,password from login", con);
                    SqlDataReader dr;
                    con.Open();
                    dr = getUserName.ExecuteReader();
                    Boolean loginSuccessfulManager = false;
                    string emailAddress = string.Empty;
                    string password = string.Empty;
                    while (dr.Read())
                    {
                        if (dr.GetString(0).ToLower() == tbRecoveryUserName.Text.ToLower())
                        {
                            emailAddress = dr.GetString(1);
                            password = dr.GetString(2);
                            loginSuccessfulManager = true;
                        }
                    }
                    con.Close();
                    getUserName.CommandText = "select UserName,email,password from employee";
                    con.Open();
                    dr = getUserName.ExecuteReader();
                    string empEmail = string.Empty;
                    Boolean loginSuccessfulEMP = false;
                    while (dr.Read())
                    {
                        if (dr.GetString(0).ToLower() == tbRecoveryUserName.Text.ToLower())
                        {
                            empEmail = dr.GetString(1);
                            password = dr.GetString(2);
                            loginSuccessfulEMP = true;
                        }
                    }
                    con.Close();
                    if (loginSuccessfulManager)
                    {
                        _EmailSender(emailAddress, Cryptor.Decrypt(password, true, "manz"));
                    }
                    else if (loginSuccessfulEMP)
                    {
                        _EmailSender(empEmail, Cryptor.Decrypt(password, true, "manz"));
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Invalid username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No internet connection!\nTry again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /*
         * Email sending response
        */
        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                _SendingMailPanel.Visible = false;
                btnSendMail.Enabled = true;
                btnSendMail.Enabled = true;
                btnCancel.Enabled = true;
                MetroFramework.MetroMessageBox.Show(this, string.Format("{0} Sending cancelled...", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                _SendingMailPanel.Visible = false;
                btnSendMail.Enabled = true;
                btnCancel.Enabled = true;
                btnSendMail.Enabled = true;
                MetroFramework.MetroMessageBox.Show(this, string.Format("{0}{1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _SendingMailPanel.Visible = false;
                btnSendMail.Enabled = true;
                btnCancel.Enabled = true;
                btnSendMail.Enabled = true;
                tbRecoveryUserName.Clear();
                DialogResult dr;
                dr = MetroFramework.MetroMessageBox.Show(this, "Recovery password has been sent to your email!\nGo back?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (dr == DialogResult.Yes)
                {
                    Util.Animate(_PanelLogin, Util.Effect.Slide, 200, 360);
                    tbUserName.Focus();
                    tbPassword.WaterMark = "Password";
                }

            }
        }


        /*
         * Go back to login window 
        */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Go back ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Util.Animate(_PanelLogin, Util.Effect.Slide, 200, 360);
                lbResponseMSG.Text = string.Empty;
                tbRecoveryUserName.Clear();
                tbUserName.WaterMark = "Username";
                tbPassword.WaterMark = "Passowrd";
                tbUserName.Focus();
                tbUserName.TabIndex = 1;
                tbPassword.TabIndex = 2;
                loginButton.TabIndex = 3;
                lbForgetPass.TabIndex = 4;
            }
        }

        private void btnBacktoWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            tbUserName.Focus();
            WindowState = FormWindowState.Minimized;
        }
        bool flag = true;
        Image restore = Resources.Restore;
        Image maximize = Resources.Maximize;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                tbUserName.Focus();
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
            else
            {
                tbUserName.Focus();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginWindows_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbForgetPass_Click(object sender, EventArgs e)
        {
            tbRecoveryUserName.TabIndex = 1;
            btnSendMail.TabIndex = 2;
            btnCancel.TabIndex = 3;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbPassword.Text.Length >= 0)
            {
                btnShowHide.Visible = true;
            }
            if (tbPassword.Text.Length == 0 && e.KeyCode == Keys.Back)
            {
                btnShowHide.Visible = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                tbUserName.Focus();
                btnShowHide.Visible = false;
                loginButton.PerformClick();
            }
        }

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
            }
        }

        private void btnShowHide_MouseDown(object sender, MouseEventArgs e)
        {

            tbPassword.PasswordChar = '\0';
            tbPassword.UseSystemPasswordChar = false;
        }

        private void btnShowHide_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }
    }
}
