using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using Project_Management_System.Properties;
using Project_Management_System;
using System.Threading;

namespace Project
{
    public partial class Register : Form
    {
        public Register()
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


        /*
         * Connecting database SQL Server
        */

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|datadirectory|\projectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter insertData = new SqlDataAdapter();


        /*
       * Sleep thread 
       */
        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);
            }
        }
        /*
         * Enable/Disable controls 
        */
        private void _ControlDisable()
        {
            tbConfirmPassword.Enabled = false;
            tbContact.Enabled = false;
            tbEmail.Enabled = false;
            tbFirstName.Enabled = false;
            tbLastName.Enabled = false;
            tbPassword.Enabled = false;
            tbUserName.Enabled = false;
            cbGender.Enabled = false;
            btnSave.Enabled = false;
        }
        private void _ControlEnable()
        {
            tbConfirmPassword.Enabled = true;
            tbContact.Enabled = true;
            tbEmail.Enabled = true;
            tbFirstName.Enabled = true;
            tbLastName.Enabled = true;
            tbPassword.Enabled = true;
            tbUserName.Enabled = true;
            cbGender.Enabled = true;
            btnSave.Enabled = true;
        }
        private void _InsertData()
        {
            
            if (tbFirstName.Text.Length == 0)
            {

                MetroFramework.MetroMessageBox.Show(this, "Name field is empty. Please enter first name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (tbFirstName.Text.Contains("@") || tbFirstName.Text.Contains("?") || tbFirstName.Text.Contains("$") || tbFirstName.Text.Contains("#") || tbFirstName.Text.Contains("~") || tbFirstName.Text.Contains("`") || tbFirstName.Text.Contains("!") || tbFirstName.Text.Contains("^") || tbFirstName.Text.Contains("%") || tbFirstName.Text.Contains("*") || tbFirstName.Text.Contains("&") || tbFirstName.Text.Contains("(") || tbFirstName.Text.Contains(")") || tbFirstName.Text.Contains("-") || tbFirstName.Text.Contains("=") || tbFirstName.Text.Contains("+") || tbFirstName.Text.Contains("?") || tbFirstName.Text.Contains("<") || tbFirstName.Text.Contains(">") || tbFirstName.Text.Contains("/") || tbFirstName.Text.Contains("|") || tbFirstName.Text.Contains("[") || tbFirstName.Text.Contains("]") || tbFirstName.Text.Contains("{") || tbFirstName.Text.Contains("}") || tbFirstName.Text.Contains(","))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid First Name! (~,!,@,#,$,%,...) are not allowed", "Warning");
            }
            else if (tbLastName.Text.Contains("@") || tbLastName.Text.Contains("?") || tbLastName.Text.Contains("$") || tbLastName.Text.Contains("#") || tbLastName.Text.Contains("~") || tbLastName.Text.Contains("`") || tbLastName.Text.Contains("!") || tbLastName.Text.Contains("^") || tbLastName.Text.Contains("%") || tbLastName.Text.Contains("*") || tbLastName.Text.Contains("&") || tbLastName.Text.Contains("(") || tbLastName.Text.Contains(")") || tbLastName.Text.Contains("-") || tbLastName.Text.Contains("=") || tbLastName.Text.Contains("+") || tbLastName.Text.Contains("?") || tbLastName.Text.Contains("<") || tbLastName.Text.Contains(">") || tbLastName.Text.Contains("/") || tbLastName.Text.Contains("|") || tbLastName.Text.Contains("[") || tbLastName.Text.Contains("]") || tbLastName.Text.Contains("{") || tbLastName.Text.Contains("}") || tbLastName.Text.Contains(","))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid Last Name! (~,!,@,#,$,%,...) are not allowed", "Warning");
            }
            if (tbPassword.Text.Length < 6)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password must contains 6 characters or digits", "Warning");
                tbPassword.Clear();
                tbConfirmPassword.Clear();
            }
            else if (tbPassword.Text.Length == 0 || tbConfirmPassword.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password field must be filled", "Warning");
            }

            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Password Doesn't match", "Warning") == DialogResult.OK)
                {
                    tbPassword.Clear(); // To clear confirm password field
                    tbConfirmPassword.Clear();
                }
            }

            /*
             * Inserting required field's data into database table (Login Table)
            */
            else
            {
                insertData.InsertCommand = new SqlCommand("Insert login values (@UserName,@FirstName,@Lastname,@Gender,@EMail,@Password,@Status)", con);
                insertData.InsertCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = tbUserName.Text;
                insertData.InsertCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = tbFirstName.Text;
                insertData.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = tbLastName.Text;
                insertData.InsertCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbGender.Text;
                insertData.InsertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbEmail.Text;
                insertData.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Cryptor.Encrypt(tbPassword.Text, true, "manz");
                insertData.InsertCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "manager";
                con.Open();  // Openning connection
                using (var waitForm = new Waitform(Save))
                {
                    waitForm.ShowDialog(this);
                }
                insertData.InsertCommand.ExecuteNonQuery();
                con.Close(); // Closing connection
                MetroFramework.MetroMessageBox.Show(this, "Your account has been created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
        /*
        *Inserting data into login table
        */
        bool f = true;
        bool _IsAdminPanelActive = false;
        private void SubmitBT(object sender, EventArgs e)
        {
            insertData.SelectCommand = new SqlCommand("select username from login", con);
            DataTable dt = new DataTable();
            insertData.Fill(dt);
            if (dt.Rows.Count>0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Manager already exit!\nDo you really want to add new manager?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    _PanelAdmin.Visible = true;
                    tbAdminUserName.WaterMark = "username";
                    tbAdminUserName.Focus();
                    tbAdminPassword.WaterMark = "password";
                    _ControlDisable();
                    _IsAdminPanelActive = true;
                    f = true;
                }
                else
                {
                    f = false;
                }
            }
            else
            {
                con.Close();
                _InsertData();
            }
        }

      /*
      *  Showing the owner of this form (Welcome window)
     */
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();      
        }
        private void Register_Load(object sender, EventArgs e)
        {
        }
        private void btnBacktoWindow_Click(object sender, EventArgs e)
        {
            if (_IsAdminPanelActive)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void _RegisterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((tbAdminPassword.Text == "17192245" || tbAdminPassword.Text =="manzpms") && tbAdminUserName.Text.ToLower() == "admin")
            {
                f = true;
                _PanelAdmin.Visible = false;
                _ControlEnable();
                SqlDataAdapter adap = new SqlDataAdapter();
                try
                {
                    adap.DeleteCommand = new SqlCommand("Delete from Login where status='manager'", con);
                    con.Open();
                    adap.DeleteCommand.ExecuteNonQuery();
                    con.Close();
                    _InsertData();
                }
                catch (SqlException ex)
                {
                    f = false;
                    con.Close();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid admin credidentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbAdminPassword.Clear();
            tbAdminUserName.Clear();
            _PanelAdmin.Visible = false;
            _ControlEnable();
        }
    }
}
