using Project_Management_System.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace
 Project_Management_System
{
    public partial class Add_Project : Form
    {
        
        public Add_Project()
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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        void fillCBTeam()
        {

            string query = "SELECT *FROM Team";
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
                    cbTeam.Items.Add(sName1 + " " + sName2);


                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        void fillCBCustomer()
        {

            string query = "SELECT *FROM Customer";
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
                    cbCustomer.Items.Add(sName1 + " " + sName2);

                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length == 0)
            {

                MetroFramework.MetroMessageBox.Show(this, "Name field is empty!\nPlease enter Project name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (tbName.Text.Contains("@") || tbName.Text.Contains("?") || tbName.Text.Contains("$") || tbName.Text.Contains("#") || tbName.Text.Contains("~") || tbName.Text.Contains("`") || tbName.Text.Contains("!") || tbName.Text.Contains("^") || tbName.Text.Contains("%") || tbName.Text.Contains("*") || tbName.Text.Contains("&") || tbName.Text.Contains("(") || tbName.Text.Contains(")") || tbName.Text.Contains("-") || tbName.Text.Contains("=") || tbName.Text.Contains("+") || tbName.Text.Contains("?") || tbName.Text.Contains("<") || tbName.Text.Contains(">") || tbName.Text.Contains("/") || tbName.Text.Contains("|") || tbName.Text.Contains("[") || tbName.Text.Contains("]") || tbName.Text.Contains("{") || tbName.Text.Contains("}") || tbName.Text.Contains(",") || tbName.Text.Contains(";") || tbName.Text.Contains(":"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid Project Name (~,!,@,#,$,%,...) are not allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbPrice.Text.Length == 0)
                tbPrice.Text = "0";
            else
            {
                /*
                 * Inserting required field's data into database table (Login Table)
                */
                try
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to add this Project?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        string data = "INSERT Project values(@ProjectName,@Type,@TeamID,@price,@Status,@CustomerID,@Description)";
                        SqlCommand insertData = new SqlCommand(data, con);
                        insertData.Parameters.AddWithValue("@projectName", tbName.Text);
                        insertData.Parameters.AddWithValue("@Type", cbType.Text);
                        insertData.Parameters.AddWithValue("@TeamID", Convert.ToInt32(cbTeam.Text.Substring(0, cbTeam.Text.IndexOf(' '))));
                        insertData.Parameters.AddWithValue("@price", Convert.ToInt32(tbPrice.Text));
                        insertData.Parameters.AddWithValue("@Status", cbStatus.Text);
                        insertData.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(cbCustomer.Text.Substring(0, cbCustomer.Text.IndexOf(' '))));
                        insertData.Parameters.AddWithValue("@Description", tbDescription.Text);
                        con.Open();
                        insertData.ExecuteNonQuery();
                        con.Close();
                        using (var waitForm = new Waitform(Save))
                        {
                            waitForm.ShowDialog(this);
                        }
                    }
                    if (MetroFramework.MetroMessageBox.Show(this, "New project has been added successfully!\nDo you want to add more?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        tbName.Clear();
                        tbPrice.Clear();
                        tbDescription.Clear();
                        cbCustomer.Text = "";
                        cbStatus.Text = "";
                        cbTeam.Text = "";
                        cbType.Text = "";
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
                    if (ex.Number == 547)
                        MetroFramework.MetroMessageBox.Show(this, "Customer  OR Team does not exits ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /*
         * Close button 
        */
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to close?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /*
         * Returning to main 
        */
        private void Add_Project_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Add_Project_Load(object sender, EventArgs e)
        {
            fillCBCustomer();
            fillCBTeam();
        }

        private void cbTeam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
