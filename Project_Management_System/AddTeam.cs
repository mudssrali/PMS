using Project_Management_System.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Project_Management_System
{
    public partial class AddTeam : Form
    {
        public AddTeam()
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
        private void AddTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void AddTeam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to add new team?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)

            {
                string data = "INSERT Team values(@TeamName,@Creationdate)";
                SqlCommand insertData = new SqlCommand(data, con);
                insertData.Parameters.AddWithValue("@TeamName", tbTeamName.Text);
                insertData.Parameters.Add("@CreationDate", SqlDbType.Date).Value = CreationDate.Value.Date;
                try
                {
                    con.Open();
                    using (var waitForm = new Waitform(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                    insertData.ExecuteNonQuery();
                    con.Close();
                    if (MetroFramework.MetroMessageBox.Show(this, "New team has been added successfully!\nDo you want to add more?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        tbTeamName.Clear();
                        CreationDate.Refresh();
                    }
                    else
                    {
                        this.Close();
                    }
                }

                catch (SqlException ex)
                {
                    // the exception alone won't tell you why it failed...
                    if (ex.Number == 2627) // <-- but this will
                    {
                        //Violation of primary key. Handle Exception
                        MetroFramework.MetroMessageBox.Show(this, "Team already exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
