using Project_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
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

        private void AddCustomer_Load(object sender, EventArgs e)
        {
        
        }
        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
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
         * save button to add customer
        */
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
           

            if (tbFirstName.Text.Length == 0 )
            {

                MetroFramework.MetroMessageBox.Show(this, "Name field is empty!\nPlease enter first name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (tbFirstName.Text.Contains(" ") || tbFirstName.Text.Contains("@") || tbFirstName.Text.Contains("?") || tbFirstName.Text.Contains("$") || tbFirstName.Text.Contains("#") || tbFirstName.Text.Contains("~") || tbFirstName.Text.Contains("`") || tbFirstName.Text.Contains("!") || tbFirstName.Text.Contains("^") || tbFirstName.Text.Contains("%") || tbFirstName.Text.Contains("*") || tbFirstName.Text.Contains("&") || tbFirstName.Text.Contains("(") || tbFirstName.Text.Contains(")") || tbFirstName.Text.Contains("-") || tbFirstName.Text.Contains("=") || tbFirstName.Text.Contains("+") || tbFirstName.Text.Contains("?") || tbFirstName.Text.Contains("<") || tbFirstName.Text.Contains(">") || tbFirstName.Text.Contains("/") || tbFirstName.Text.Contains("|") || tbFirstName.Text.Contains("[") || tbFirstName.Text.Contains("]") || tbFirstName.Text.Contains("{") || tbFirstName.Text.Contains("}") || tbFirstName.Text.Contains(","))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid First Name (~,!,@,#,$,%,...) are not allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbLastName.Text.Length == 0 )
            {
                MetroFramework.MetroMessageBox.Show(this, "Last name field is empty\nPlease enter first name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbLastName.Text.Contains(" ") || tbLastName.Text.Contains("@") || tbLastName.Text.Contains("?") || tbLastName.Text.Contains("$") || tbLastName.Text.Contains("#") || tbLastName.Text.Contains("~") || tbLastName.Text.Contains("`") || tbLastName.Text.Contains("!") || tbLastName.Text.Contains("^") || tbLastName.Text.Contains("%") || tbLastName.Text.Contains("*") || tbLastName.Text.Contains("&") || tbLastName.Text.Contains("(") || tbLastName.Text.Contains(")") || tbLastName.Text.Contains("-") || tbLastName.Text.Contains("=") || tbLastName.Text.Contains("+") || tbLastName.Text.Contains("?") || tbLastName.Text.Contains("<") || tbLastName.Text.Contains(">") || tbLastName.Text.Contains("/") || tbLastName.Text.Contains("|") || tbLastName.Text.Contains("[") || tbLastName.Text.Contains("]") || tbLastName.Text.Contains("{") || tbLastName.Text.Contains("}") || tbLastName.Text.Contains(","))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid Last Name (~,!,@,#,$,%,...) are not allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to add new customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    string data = "INSERT Customer values(@CustomerFName,@CustomerLName,@CNIC,@Contact,@Gender,@Email,@City,@Location)";
                    SqlCommand insertData = new SqlCommand(data, con);
                    insertData.Parameters.AddWithValue("@CustomerFName", tbFirstName.Text);
                    insertData.Parameters.AddWithValue("@CustomerLName", tbLastName.Text);
                    insertData.Parameters.AddWithValue("@CNIC", tbCNIC.Text);
                    insertData.Parameters.AddWithValue("@Contact", tbContact.Text);
                    insertData.Parameters.AddWithValue("@Gender", cbGender.Text);
                    insertData.Parameters.AddWithValue("@Email", tbEmail.Text);
                    insertData.Parameters.AddWithValue("@City", cbCity.Text);
                    insertData.Parameters.AddWithValue("@Location", cbLoc.Text);
                    con.Open();
                    insertData.ExecuteNonQuery();
                    con.Close();
                    using (var waitForm = new Waitform(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                }
                if (MetroFramework.MetroMessageBox.Show(this, "New customer has been added successfully!\nDo you want to add more?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    tbFirstName.Clear();
                    tbLastName.Clear();
                    tbCNIC.Clear();
                    tbContact.Clear();
                    cbGender.Text = "";
                    tbEmail.Clear();
                    cbLoc.Text = "";
                    cbCity.Text = "";
                }
                else
                {
                    this.Close();
                }
            }

        }

        /*
         * Close this form and do not save the recored 
        */
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.Close();
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

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tbContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
            
        }

        private void tbFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 48 && e.KeyValue <= 56))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
