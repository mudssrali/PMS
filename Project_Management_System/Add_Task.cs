using Project_Management_System.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Add_Task : Form
    {

        public Add_Task()
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
        /*
         *  START OF EFFECT CLASS
        */
        public static class Util
        {
            public enum Effect { Roll, Slide, Centre, Bend }
            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flag = effmap[(int)effect];
                if (ctl.Visible)
                {
                    flag |= 0x10000;
                    angle += 180;
                }
                else
                {
                    if (ctl.TopLevelControl == ctl)
                        flag |= 0x20000;
                    else if (effect == Effect.Bend)
                        throw new ArgumentException();

                }
                flag |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flag);
                if (!ok)
                    throw new Exception("Animation Failed");
                ctl.Visible = !ctl.Visible;
            }
        }
        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };
        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flag);

        /*
         * END OF EFFECTS CLASS
        */


        void fillCBEMP()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT EmpID, EmpfirstName, EmplastName   FROM EMPLOYEE";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();

            string sName1 = "";
            string sName2 = "";
            string sName3 = "";
            try
            {
                while (dr.Read())
                {
                    sName1 = Convert.ToString(dr.GetValue(0));
                    sName2 = dr.GetString(1);
                    sName3 = dr.GetString(2);
                    cbAssignedTo.Items.Add(sName1 + " " + sName2 + " " + sName3);

                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }


        void fillCBProject()

        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ProjectDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT *FROM Project";
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
                    cbSelectedProject.Items.Add(sName1 + " " + sName2);

                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        /*
         * Closing Add new Task Form 
        */
        private void btnCloseTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Add_Task_FormClosed(object sender, FormClosedEventArgs e)
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
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
        /*
         * Saving new Task Data
        */
        private void btnSaveTask_Click(object sender, EventArgs e)
        {

            if (tbTaskName.Text.Length == 0)
            {

                MetroFramework.MetroMessageBox.Show(this, "Name field is empty!\nPlease enter Task name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (tbTaskName.Text.Contains("@") || tbTaskName.Text.Contains("?") || tbTaskName.Text.Contains("$") || tbTaskName.Text.Contains("#") || tbTaskName.Text.Contains("~") || tbTaskName.Text.Contains("`") || tbTaskName.Text.Contains("!") || tbTaskName.Text.Contains("^") || tbTaskName.Text.Contains("%") || tbTaskName.Text.Contains("*") || tbTaskName.Text.Contains("&") || tbTaskName.Text.Contains("(") || tbTaskName.Text.Contains(")") || tbTaskName.Text.Contains("-") || tbTaskName.Text.Contains("=") || tbTaskName.Text.Contains("+") || tbTaskName.Text.Contains("?") || tbTaskName.Text.Contains("<") || tbTaskName.Text.Contains(">") || tbTaskName.Text.Contains("/") || tbTaskName.Text.Contains("|") || tbTaskName.Text.Contains("[") || tbTaskName.Text.Contains("]") || tbTaskName.Text.Contains("{") || tbTaskName.Text.Contains("}") || tbTaskName.Text.Contains(","))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inavlid Task Name (~,!,@,#,$,%,...) are not allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to add new task?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    Int32 s = -1;
                    string data = "INSERT Task values(@TaskName,@TaskType,@Status,@priority,@Label,@EmpID,@EstimatedDate,@StartDate,@DueDate,@EndDate,@projectId,@progress,@Description)";
                    SqlCommand insert = new SqlCommand("insert TeamMember values (@TeamId,@EmpID )", con);
                    SqlCommand insertData = new SqlCommand(data, con);
                    SqlCommand get = new SqlCommand("Select teamId from project where projectid ='" + Convert.ToInt32(cbSelectedProject.Text.Substring(0, cbSelectedProject.Text.IndexOf(' '))) + "'", con);
                    con.Open();
                    SqlDataReader readerid = get.ExecuteReader();

                    Int32 id = Convert.ToInt32(cbAssignedTo.Text.Substring(0, cbAssignedTo.Text.IndexOf(' ')));
                    if (readerid.HasRows)
                    {

                        readerid.Read();
                        s = readerid.GetInt32(0);
                        insert.Parameters.AddWithValue("@TeamId", s);
                        insert.Parameters.AddWithValue("@EMPID", id);
                    }
                    con.Close();
                    insertData.Parameters.AddWithValue("@TaskName", tbTaskName.Text);
                    insertData.Parameters.AddWithValue("@TaskType", cbType.Text);
                    insertData.Parameters.AddWithValue("@Status", cbStatus.Text);
                    insertData.Parameters.AddWithValue("@Priority", cbPriority.Text);
                    insertData.Parameters.AddWithValue("@Label", cbLabel.Text);
                    insertData.Parameters.AddWithValue("@EmpID", id);
                    insertData.Parameters.AddWithValue("@EstimatedDate", ExpectedDate.Value.Date);
                    insertData.Parameters.AddWithValue("@ProjectId", Convert.ToInt32(cbSelectedProject.Text.Substring(0, cbSelectedProject.Text.IndexOf(' '))));
                    insertData.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                    insertData.Parameters.AddWithValue("@DueDate", DueDate.Value.Date);
                    insertData.Parameters.AddWithValue("@EndDate",DateTime.Now.Date);
                    insertData.Parameters.AddWithValue("@Progress", cbProgress.Text);
                    insertData.Parameters.AddWithValue("@Description", tbDescription.Text);

                    get.CommandText = "select * from TeamMember";
                    con.Open();
                    SqlDataReader reader = get.ExecuteReader();

                    Boolean f = false;
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            Int32 getEMPID = reader.GetInt32(0);
                            Int32 getTeamId = reader.GetInt32(1);
                            if (getTeamId == s && getEMPID == id)
                                f = true;
                        }
                    }

                    con.Close();
                    con.Open();
                    insertData.ExecuteNonQuery();
                    if (!f)
                    {
                        insert.ExecuteNonQuery();
                        using (var waitForm = new Waitform(Save))
                        {
                            waitForm.ShowDialog(this);
                        }
                    }
                    con.Close();
                }

                if (MetroFramework.MetroMessageBox.Show(this, "New task has been added successfully!\nDo you want to add more?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbTaskName.Clear();
                    tbDescription.Clear();
                    cbAssignedTo.PromptText = " ";
                    cbLabel.PromptText = " ";
                    cbPriority.PromptText = " ";
                    cbProgress.PromptText = " ";
                    cbStatus.PromptText = " ";
                    cbType.PromptText = " ";
                    DueDate.Refresh();
                    ExpectedDate.Refresh();
                    StartDate.Refresh();
                    Util.Animate(_PanelGeneral, Util.Effect.Slide, 200, 360);
                }
                else
                {
                    this.Close();
                }
            }

        }
        private void Add_Task_Load(object sender, EventArgs e)
        {
            fillCBEMP();
            fillCBProject();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (cbSelectedProject.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Select the project first to add new task", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Util.Animate(_PanelGeneral, Util.Effect.Slide, 200, 360);
            }
        }

        private void btnBackToGeneral_Click(object sender, EventArgs e)
        {
            Util.Animate(_PanelGeneral, Util.Effect.Slide, 200, 360);
        }
    }
}
