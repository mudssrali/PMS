
using Project_Management_System.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30");

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
         *  Inserting data into login table
        */
        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (tbSalary.Text.Length == 0)
                tbSalary.Text = "0";
            if (tbExperience.Text.Length == 0)
                tbExperience.Text = "0";

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to add new employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                string data = "INSERT Employee values(@EMPFirstName,@EMPLastName,@UserName,@Gender,@Password,@CNIC,@Contact,@Email,@Job,@Salary,@Experience,@HireDate,@HouseNo,@Street,@Area,@City,@Country,@AddressType)";
                SqlCommand insertData = new SqlCommand(data, con);
                insertData.Parameters.AddWithValue("@EMPFirstName", tbFirstName.Text);
                insertData.Parameters.AddWithValue("@EMPLastName", tbLastName.Text);
                insertData.Parameters.AddWithValue("@UserName", tbUserName.Text);
                insertData.Parameters.AddWithValue("@Gender", cbGender.Text);
                insertData.Parameters.AddWithValue("@Password", Cryptor.Encrypt(tbPassword.Text,true,"manz"));
                insertData.Parameters.AddWithValue("@CNIC", tbCNIC.Text);
                insertData.Parameters.AddWithValue("@Contact", tbContact.Text);
                insertData.Parameters.AddWithValue("@Email", tbEmail.Text);
                insertData.Parameters.AddWithValue("@Job", cbJob.Text);
                insertData.Parameters.AddWithValue("@Salary", Convert.ToInt32(tbSalary.Text));
                insertData.Parameters.AddWithValue("@Experience", Convert.ToInt32(tbExperience.Text));
                insertData.Parameters.Add("@HireDate", SqlDbType.Date).Value = tbHireDate.Value.Date;
                insertData.Parameters.AddWithValue("@HouseNo", tbHouseNo.Text);
                insertData.Parameters.AddWithValue("@Street", tbStreetNo.Text);
                insertData.Parameters.AddWithValue("@Area", tbArea.Text);
                insertData.Parameters.AddWithValue("@City", tbCity.Text);
                insertData.Parameters.AddWithValue("@Country", cbCountry.Text);
                insertData.Parameters.AddWithValue("@AddressType", cbHomeAdd.Text);
                try
                {
                    using (var waitForm = new Waitform(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                    con.Open();
                    insertData.ExecuteNonQuery();
                    con.Close();
                    if (MetroFramework.MetroMessageBox.Show(this, "New employee has been added successfully\nDo you want to add more?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Util.Animate(_PanelNewEMP, Util.Effect.Slide, 100, 360);
                        tbFirstName.Clear();
                        tbLastName.Clear();
                        tbUserName.Clear();
                        tbContact.Clear();
                        tbConfirmPassword.Clear();
                        tbPassword.Clear();
                        tbSalary.Clear();
                        tbExperience.Clear();
                        cbJob.PromptText = "example: DBA";
                        cbJob.Style = MetroFramework.MetroColorStyle.Green;
                        tbEmail.Clear();
                        tbCNIC.Clear();
                        cbCountry.PromptText = "example: Pakistan";
                        cbCountry.Style = MetroFramework.MetroColorStyle.Green;
                        cbHomeAdd.PromptText = "example: Local";
                        cbHomeAdd.Style = MetroFramework.MetroColorStyle.Green;
                        cbGender.PromptText = "example: Male";
                        cbGender.Style = MetroFramework.MetroColorStyle.Green;
                        tbHouseNo.Clear();
                        tbStreetNo.Clear();
                        tbArea.Clear();
                        tbCity.PromptText = "example: Lahore";
                        tbHireDate.Refresh();

                    }
                    else
                    {
                        /*
						 * CLosing register account form and openning welcome form

						*/
                        this.Close();
                    }
                }

                catch (SqlException ex)
                {
                    // the exception alone won't tell you why it failed...
                    if (ex.Number == 2627) // <-- but this will
                    {
                        //Violation of primary key. Handle Exception
                        MetroFramework.MetroMessageBox.Show(this, "User Name already exits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Data entry violations!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

        }


        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
        }
        
        /*
         * Close this form and do not save the recored 
        */

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /*
         * Next button to show address panel 
        */
        private void btnNext_Click(object sender, EventArgs e)
        {
            string query = "select UserName from  Employee where userName= '" + tbUserName.Text + "'";
            SqlCommand getUserName = new SqlCommand(query, con);
            SqlCommand getUser = new SqlCommand("select UserName from  login where userName= '" + tbUserName.Text + "'", con);
            SqlDataReader druser, dr;
            Boolean userNameexists = false;
            con.Open();
            druser = getUserName.ExecuteReader();
            if (druser.HasRows)
                userNameexists = true;
            con.Close();
            con.Open();
            dr = getUser.ExecuteReader();
            if (dr.HasRows)
                userNameexists = true;
            con.Close();



            if (tbFirstName.Text.Length == 0)
            {

                MetroFramework.MetroMessageBox.Show(this, "Name field is empty!\nPlease enter first name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

            else if (tbFirstName.Text.Contains(" ") || tbFirstName.Text.Contains("@") || tbFirstName.Text.Contains("?") || tbFirstName.Text.Contains("$") || tbFirstName.Text.Contains("#") || tbFirstName.Text.Contains("~") || tbFirstName.Text.Contains("`") || tbFirstName.Text.Contains("!") || tbFirstName.Text.Contains("^") || tbFirstName.Text.Contains("%") || tbFirstName.Text.Contains("*") || tbFirstName.Text.Contains("&") || tbFirstName.Text.Contains("(") || tbFirstName.Text.Contains(")") || tbFirstName.Text.Contains("-") || tbFirstName.Text.Contains("=") || tbFirstName.Text.Contains("+") || tbFirstName.Text.Contains("?") || tbFirstName.Text.Contains("<") || tbFirstName.Text.Contains(">") || tbFirstName.Text.Contains("/") || tbFirstName.Text.Contains("|") || tbFirstName.Text.Contains("[") || tbFirstName.Text.Contains("]") || tbFirstName.Text.Contains("{") || tbFirstName.Text.Contains("}") || tbFirstName.Text.Contains(",") || tbFirstName.Text.Contains(";") || tbFirstName.Text.Contains(":"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid First Name (~,!,@,#,$,%,...) are not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbLastName.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Last name field is empty\nPlease enter Last name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (tbLastName.Text.Contains(" ") || tbLastName.Text.Contains("@") || tbLastName.Text.Contains("?") || tbLastName.Text.Contains("$") || tbLastName.Text.Contains("#") || tbLastName.Text.Contains("~") || tbLastName.Text.Contains("`") || tbLastName.Text.Contains("!") || tbLastName.Text.Contains("^") || tbLastName.Text.Contains("%") || tbLastName.Text.Contains("*") || tbLastName.Text.Contains("&") || tbLastName.Text.Contains("(") || tbLastName.Text.Contains(")") || tbLastName.Text.Contains("-") || tbLastName.Text.Contains("=") || tbLastName.Text.Contains("+") || tbLastName.Text.Contains("?") || tbLastName.Text.Contains("<") || tbLastName.Text.Contains(">") || tbLastName.Text.Contains("/") || tbLastName.Text.Contains("|") || tbLastName.Text.Contains("[") || tbLastName.Text.Contains("]") || tbLastName.Text.Contains("{") || tbLastName.Text.Contains("}") || tbLastName.Text.Contains(",") || tbLastName.Text.Contains(":") || tbLastName.Text.Contains(";"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid Last Name (~,!,@,#,$,%,...) are not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbUserName.Text.Length == 0)
                MetroFramework.MetroMessageBox.Show(this, "Username field is empty\nPlease enter User name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (userNameexists)
                MetroFramework.MetroMessageBox.Show(this, "Username already exists ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (tbPassword.Text.Length < 6)
            {
                MetroFramework.MetroMessageBox.Show(this, "Passowrd at least 6 more characters long!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbPassword.Clear();
                tbConfirmPassword.Clear();
            }
            else if (tbPassword.Text.Length == 0 || tbConfirmPassword.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password field must be filled !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Password doesn't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    tbPassword.Clear(); // To clear confirm password field
                    tbConfirmPassword.Clear();
                }
            }
            else if (cbGender.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cbGender.Refresh();
            }

            else
            {

                Util.Animate(_PanelNewEMP, Util.Effect.Slide, 200, 360);
                tbHouseNo.Focus();
            }
            con.Close();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Util.Animate(_PanelNewEMP, Util.Effect.Slide, 200, 360);

        }

        private void btnBackToLogWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Exit application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.Exit();
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AddEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
