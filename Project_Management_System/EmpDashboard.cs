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
    public partial class EmpDashboard : Form
    {
        string userNameShow = "";
        int index = 0;
        int index1 = 0;
        public EmpDashboard(string userName)
        {
            InitializeComponent();
            userNameShow = userName;
            lbCurrentUser.Text = "Hi " + userNameShow;
            _PanelViewDetails.Hide();
            _PanelUpdateTaskStatus.Hide();
            _PanelSettings.Hide();
            _PanelViewComments.Hide();

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
        DataSet ds1 = new DataSet();
        BindingSource bs1 = new BindingSource();
        string[] str = new string[15];
        int btn1 = 0;
        int btn2 = 0;
        int btn3 = 0;
        int btn4 = 0;
        /*
         * Form load event 
        */
        private void EmpDashboard_Load(object sender, EventArgs e)
        {
            dg.BorderStyle = BorderStyle.None;
            dg.EnableHeadersVisualStyles = false;
            dg.GridColor = Color.Black;
            dg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);

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
         * Method to change emp settings
        */
        private void btnEMPSettings_Click(object sender, EventArgs e)
        {
            if (btn1 == 1)
            {
                Util.Animate(_PanelViewDetails, Util.Effect.Centre, 500, 360);
                btn1 = 0;
            }
            if (btn2 == 1)
            {
                Util.Animate(_PanelUpdateTaskStatus, Util.Effect.Centre, 500, 360);
                btn2 = 0;
            }
            if (btn3 == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 500, 360);
                btn3 = 0;
            }

            FieldCleaner();
            _PanelSettings.Height = 675;
            _PanelSettings.Width = 1185;
            if (btn4 == 0)
            {
                Util.Animate(_PanelSettings, Util.Effect.Slide, 200, 360);
                btn4 = 1;
            }
            else
            {
                Util.Animate(_PanelSettings, Util.Effect.Slide, 200, 360);
                btn4 = 0;
            }
        }
        /*
         * Form closed event 
        */
        private void EmpDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        /*
         * Method to fill emp combo box 
        */

        void fillTaskCB()
        {
            cbShowTask.Items.Clear();
            string query = "SELECT t.TaskID, t.TaskName from task t, employee e where t.empid=e.empid and e.username='" + userNameShow + "'";
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
                    cbShowTask.Items.Add(sName1 + " " + sName2);

                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        /*
         * Method to fill task information field based on selected task 
        */
        private void fillTaskInformation(string taskID)
        {
            SqlCommand getData = new SqlCommand("SELECT *FROM TASK WHERE TASKID='" + taskID + "'", con);
            SqlDataReader dataReader;
            con.Open();
            dataReader = getData.ExecuteReader();

            int i = 0;
            dataReader.Read();
            while (i < 14)
            {
                if (i == 0 || i == 6 || i == 11 || i == 12)
                {

                    str[i] = dataReader.GetValue(i).ToString();

                }
                else if (i == 7 || i == 8 || i == 9 || i == 10)
                {
                    str[i] = dataReader.GetDateTime(i).ToString();
                }
                else
                {
                    str[i] = dataReader.GetString(i);
                }

                i++;
            }
            con.Close();
            tbType.Text = str[2];
            tbStatus.Text = str[3];
            tbPriority.Text = str[4];
            tbLabel.Text = str[5];
            tbExpectedDate.Text = Convert.ToDateTime(str[7]).ToString("MM,dd,yyyy");
            tbStartDate.Text = Convert.ToDateTime(str[8]).ToString("MM,dd,yyyy");
            tbDueDate.Text = Convert.ToDateTime(str[9]).ToString("MM,dd,yyyy");
            tbEndDate.Text = Convert.ToDateTime(str[10]).ToString("MM,dd,yyyy");
            tbProject.Text = str[11];
            cbProgress.Text = str[12];
            tbDescription.Text = str[13];
        }

        /*
         * Logging out  
        */
        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are your sure to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
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
        /*
         * Closing application 
        */
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Exit application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /*
         * Field cleaner 
        */
        private void FieldCleaner()
        {
            lbCount1.Text = "";
            lbTotalRecords.Text = "";
            lbCount.Text = "";
            lbTotalRecords1.Text = "";
            cbShowTask.Items.Clear();
            tbComment.Clear();
            tbDescription.Clear();
            tbDueDate.Clear();
            tbEndDate.Clear();
            tbExpectedDate.Clear();
            tbLabel.Clear();
            tbLabel.Clear();
            tbProject.Clear();
            tbPriority.Clear();
            tbStartDate.Clear();
            tbStatus.Clear();
            tbOldPassword.Clear();
            tbOldPassword.Clear();
            tbConfirmPassword.Clear();
            cbProgress.Text = "";
            tbType.Clear();
            cbSelectProject.Items.Clear();
            cbSelectProject1.Items.Clear();
            dg1.Hide();
            _PanelBTNProj.Hide();
            dg.Hide();
            _PanelBTNView.Hide();
            lbProject.Visible = false;
            tbProject.Visible = false;
            lbType.Visible = false;
            tbType.Visible = false;
            lbStatus.Visible = false;
            tbStatus.Visible = false;
            lbPriority.Visible = false;
            tbPriority.Visible = false;
            lbLabel.Visible = false;
            tbLabel.Visible = false;
            lbSD.Visible = false;
            tbStartDate.Visible = false;
            lbEndDate.Visible = false;
            tbEndDate.Visible = false;
            lbExpectTime.Visible = false;
            tbExpectedDate.Visible = false;
            lbDD.Visible = false;
            tbDueDate.Visible = false;
            lbProgress.Visible = false;
            cbProgress.Visible = false;
            lbDescription.Visible = false;
            tbDescription.Visible = false;
            lbComment.Visible = false;
            tbComment.Visible = false;
            btnUpdateConfirm.Visible = false;
            btnCancel.Visible = false;
        }
        /*
         *  TO make moveable form
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
         * Digital Clock 
        */
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("MM-dd-yyyy  hh:mm:ss tt");
        }
        /*
         * View employee details 
        */
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (btn4 == 1)
            {
                Util.Animate(_PanelSettings, Util.Effect.Centre, 500, 360);
                btn4 = 0;
            }
            if (btn2 == 1)
            {
                Util.Animate(_PanelUpdateTaskStatus, Util.Effect.Centre, 500, 360);
                btn2 = 0;
            }
            if (btn3 == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 500, 360);
                btn3 = 0;
            }

            FieldCleaner();
            fillProjectCB();
            _PanelViewDetails.Height = 675;
            _PanelViewDetails.Width = 1185;
            if (btn1 == 0)
            {
                Util.Animate(_PanelViewDetails, Util.Effect.Slide, 200, 360);
                btn1 = 1;
            }
            else
            {
                Util.Animate(_PanelViewDetails, Util.Effect.Slide, 200, 360);
                btn1 = 0;
            }
        }
        /*
         * Method to update task progress  
        */
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (btn4 == 1)
            {
                Util.Animate(_PanelSettings, Util.Effect.Centre, 500, 360);
                btn4 = 0;
            }
            if (btn1 == 1)
            {
                Util.Animate(_PanelViewDetails, Util.Effect.Centre, 500, 360);
                btn1 = 0;
            }
            if (btn3 == 1)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Centre, 500, 360);
                btn3 = 0;
            }

            FieldCleaner();
            fillTaskCB();
            _PanelUpdateTaskStatus.Height = 675;
            _PanelUpdateTaskStatus.Width = 1185;
            if (btn2 == 0)
            {
                Util.Animate(_PanelUpdateTaskStatus, Util.Effect.Slide, 200, 360);
                btn2 = 1;
            }
            else
            {
                Util.Animate(_PanelUpdateTaskStatus, Util.Effect.Slide, 200, 360);
                btn2 = 0;
            }
        }
        /*
         * Method to select task from metrocombo box 
        */
        private void cbShowTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id = cbShowTask.Text.Substring(0, cbShowTask.Text.IndexOf(' '));

            lbProject.Visible = true;
            tbProject.Visible = true;
            lbType.Visible = true;
            tbType.Visible = true;
            lbStatus.Visible = true;
            tbStatus.Visible = true;
            lbPriority.Visible = true;
            tbPriority.Visible = true;
            lbLabel.Visible = true;
            tbLabel.Visible = true;
            lbSD.Visible = true;
            tbStartDate.Visible = true;
            lbEndDate.Visible = true;
            tbEndDate.Visible = true;
            lbExpectTime.Visible = true;
            tbExpectedDate.Visible = true;
            lbDD.Visible = true;
            tbDueDate.Visible = true;
            lbProgress.Visible = true;
            cbProgress.Visible = true;
            lbDescription.Visible = true;
            tbDescription.Visible = true;
            lbComment.Visible = true;
            tbComment.Visible = true;
            btnUpdateConfirm.Visible = true;
            btnCancel.Visible = true;
            fillTaskInformation(Id);
        }
        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (Convert.ToInt32(cbProgress.Text) < 100)
                {
                    adap.UpdateCommand = new SqlCommand("Update Task SET PROGRESS = @PROGRESS WHERE Convert(Varchar,TASKID)='" + str[0] + "'", con);
                    adap.UpdateCommand.Parameters.AddWithValue("@Progress", Convert.ToInt32(cbProgress.Text));

                    con.Open();
                    i = adap.UpdateCommand.ExecuteNonQuery();
                    con.Close();

                    string data = "INSERT Comment values(@TaskID,@CommentDate,@Description)";
                    SqlCommand insertData = new SqlCommand(data, con);
                    insertData.Parameters.AddWithValue("@TaskID", Convert.ToInt32(str[0]));
                    insertData.Parameters.Add("@CommentDate", SqlDbType.Date).Value = DateTime.Now.Date;
                    insertData.Parameters.AddWithValue("@Description", tbComment.Text);
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
                    using (var waitForm = new UpdatingWait(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                    if (i == 1 && j == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Progress and Comment has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Convert.ToInt32(cbProgress.Text) == 100)
                {
                    adap.UpdateCommand = new SqlCommand("Update Task SET PROGRESS = @PROGRESS, Status = @Status WHERE Convert(Varchar,TASKID)='" + str[0] + "'", con);
                    adap.UpdateCommand.Parameters.AddWithValue("@Progress", Convert.ToInt32(cbProgress.Text));
                    adap.UpdateCommand.Parameters.AddWithValue("@Status", "Done");
                    con.Open();
                    i = adap.UpdateCommand.ExecuteNonQuery();
                    con.Close();

                    string data = "INSERT Comment values(@TaskID,@CommentDate,@Description)";
                    SqlCommand insertData = new SqlCommand(data, con);
                    insertData.Parameters.AddWithValue("@TaskID", Convert.ToInt32(str[0]));
                    insertData.Parameters.Add("@CommentDate", SqlDbType.Date).Value = DateTime.Now.Date;
                    insertData.Parameters.AddWithValue("@Description", tbComment.Text);
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

                    using (var waitForm = new UpdatingWait(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                    if (i == 1 && j == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Progress and Comment has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
        /*
         * Method to calcel upates 
        */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel updation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cbProgress.Text = str[12];
                tbComment.Clear();
            }
        }
        /*
         * Method to View Comments 
        */

        private void loadComments(string Id)
        {
            adap.SelectCommand = new SqlCommand("SELECT c.Commentid as COMMENT_ID,e.EMPID as EMPLOYEE_ID, e.EMPFIRSTNAME +' '+e.EMPLASTNAME As EMPLOYEE_NAME , t.taskid as TASK_ID, t.taskname as TASK_NAME,c.CommentDate as COMMENT_DATE, c.Description as COMMENT_DESCRIPTION from comment c,project p , EMPloyee e, task t  where p.projectId = '" + Id + "' and t.EMPID=e.EMPID and c.taskid = t.taskid and t.projectID = p.projectID", con);
            ds1.Clear();
            adap.Fill(ds1);
            dg1.DataSource = ds1.Tables[0];
            bs1.DataSource = ds1.Tables[0];
            if (bs1.Count > 0)
            {
                bs1.MoveFirst();
                updateGridProj();
            }
            else
            {
                lbCount1.Text = "";
                int count = 0;
                lbCount1.Text = "Record " + count + " of 0";
                lbTotalRecords.Text = " |  Total Records: 0";
            }
        }
        /*
         * View project 
        */
        private void btnViewComments_Click(object sender, EventArgs e)
        {
            if (btn4 == 1)
            {
                Util.Animate(_PanelSettings, Util.Effect.Centre, 500, 360);
                btn4 = 0;
            }
            if (btn2 == 1)
            {
                Util.Animate(_PanelUpdateTaskStatus, Util.Effect.Centre, 500, 360);
                btn2 = 0;
            }
            if (btn1 == 1)
            {
                Util.Animate(_PanelViewDetails, Util.Effect.Centre, 500, 360);
                btn1 = 0;
            }

            FieldCleaner();
            fillProjectCB();
            _PanelViewComments.Height = 675;
            _PanelViewComments.Width = 1185;
            if (btn3 == 0)
            {
                Util.Animate(_PanelViewComments, Util.Effect.Slide, 200, 360);
                btn3 = 1;
            }
            else
            {
                Util.Animate(_PanelViewComments, Util.Effect.Slide, 200, 360);
                btn3 = 0;
            }
        }
        /*
         * Changing password 
        */
        private void btnSave_Click(object sender, EventArgs e)
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
                    adap.UpdateCommand = new SqlCommand("Update Employee SET PASSWORD = @PASSWORD where username ='" + userNameShow + "'", con);
                    adap.UpdateCommand.Parameters.AddWithValue("@Password", Cryptor.Encrypt(tbPassword.Text,true,"manz"));
                    con.Open();
                    int queryResult = adap.UpdateCommand.ExecuteNonQuery();
                    con.Close();
                    using (var waitForm = new UpdatingWait(Save))
                    {
                        waitForm.ShowDialog(this);
                    }
                    if (queryResult == 1)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Your password has been changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
         * Method to cancel password changes 
        */
        private void btnCancelChanges_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                tbOldPassword.Clear();
                tbOldPassword.Clear();
                tbConfirmPassword.Clear();
                if (btn4 == 1)
                {
                    Util.Animate(_PanelSettings, Util.Effect.Centre, 300, 360);
                    btn4 = 0;
                }
            }
        }
        /*
         * Validating password fields 
        */
        bool oldPasswordFlag = false;
        private void tbOldPassword_Leave(object sender, EventArgs e)
        {
            adap.SelectCommand = new SqlCommand("Select password from employee where username='" + userNameShow + "'", con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            if (Cryptor.Decrypt(dt.Rows[0][0].ToString(), true, "manz")!= tbOldPassword.Text)
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
            string query = "SELECT *FROM Project p, employee e, teammember tm where p.teamid = tm.teamid and tm.EMPID=e.EMPID and e.username='" + userNameShow + "'";
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
         * Method to select project for comments
        */
        private void cbSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id = cbSelectProject.Text.Substring(0, cbSelectProject.Text.IndexOf(' '));
            dg1.Show();
            _PanelBTNProj.Show();
            loadComments(Id);

        }
        /*
         * load project to View detail 
        */
        private void loadProjectData(string Id)
        {
            adap.SelectCommand = new SqlCommand("SELECT t.TaskId as TASK_ID, t.TaskName as TASK_NAME, e.empid as EMP_NO, e.EMPFirstName + ' '+e.EMPLastName as EMPLOYEE_NAME, t.TaskType as TASK_TYPE, t.status as TASK_STATUS, t.Priority as TASK_PRIORITY, t.Label as TASK_LABEL, t.EstimatedDate as TASK_ESTDATE, t.StartDate as TASK_STARTDATE, t.DueDate as TASK_DUEDATE, t.EndDate as TASK_ENDDATE, t.Progress as TASK_PROGRESS, T.description as TASK_DESCRIPTION FROM PROJECT p, TASK t, EMPLOYEE e where p.projectid = '" + Id + "' and p.projectid = t.projectid and t.empid = e.empid", con);
            ds.Clear();
            adap.Fill(ds);
            dg.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            if (bs.Count > 0)
            {
                bs.MoveFirst();
                updateGrid();
            }
            else
            {
                lbCount.Text = "";
                int count = 0;
                lbCount.Text = "Record " + count + " of 0";
                lbTotalRecords1.Text = " |  Total Records: 0";
            }
        }
        /*
         * Method to select project for view details 
        */
        private void cbSelectProject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id = cbSelectProject1.Text.Substring(0, cbSelectProject1.Text.IndexOf(' '));
            dg.Show();
            _PanelBTNView.Show();
            loadProjectData(Id);


        }

        private void cbProgress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*
         * View employee detials panel button 
        */
        /*
       *  Previous Record button
       */

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.MovePrevious();
            updateGrid();
            rowCount();
        }

        /*
         *  First Record button
        */
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.MoveFirst();
            updateGrid();
            rowCount();
        }

        /*
         *  Next Record button
        */
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
                bs.MoveNext();
            updateGrid();
            rowCount();
        }

        /*
         *  Last Record button
        */
        private void btnLast_Click(object sender, EventArgs e)
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
            dg.FirstDisplayedScrollingRowIndex = bs.Position;
            dg.ClearSelection();
            if (bs.Count > 0)
                dg.Rows[bs.Position].Selected = true;
            rowCount();
        }
        /*
         * Counting records in data grid 
        */
        private void rowCount()
        {
            lbCount.Text = "";
            int count = (bs.Position) + 1;
            lbCount.Text = "Record " + count + " of " + (bs.Count);
            lbTotalRecords1.Text = "|  Total Records: " + (bs.Count);
        }
        private void rowCountByHR(int i)
        {
            i += 1;
            lbCount.Text = "";
            lbCount.Text = "Record " + i + " of " + (bs.Count);
            lbTotalRecords1.Text = " |  Total Records: " + (bs.Count);
        }
        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowCountByHR(dg.CurrentRow.Index);
        }
        /*
         * View comments panel button 
        */
        /*
          *  Previous Record button
         */
        private void btnPreviousProj_Click(object sender, EventArgs e)
        {
            if (bs1.Count > 0)
                bs1.MovePrevious();
            updateGridProj();
            rowCountProj();
        }

        /*
         *  First Record button
        */
        private void btnFirstProj_Click(object sender, EventArgs e)
        {
            if (bs1.Count > 0)
                bs1.MoveFirst();
            updateGridProj();
            rowCountProj();
        }

        /*
         *  Next Record button
        */
        private void btnNextProj_Click(object sender, EventArgs e)
        {
            if (bs1.Count > 0)
                bs1.MoveNext();
            updateGridProj();
            rowCountProj();
        }

        /*
         *  Last Record button
        */
        private void btnLastProj_Click(object sender, EventArgs e)
        {
            if (bs1.Count > 0)
                bs1.MoveLast();
            updateGridProj();
            rowCountProj();
        }

        /*
         *  Upgrade data grid Records selection 
        */
        private void updateGridProj()
        {
            dg1.ClearSelection();
            dg1.FirstDisplayedScrollingRowIndex = bs1.Position;
            if (bs1.Count > 0)
                dg1.Rows[bs1.Position].Selected = true;
            rowCountProj();
        }
        /*
         * Counting records in data grid 
        */
        private void rowCountProj()
        {
            lbCount.Text = "";
            int count = (bs1.Position) + 1;
            lbCount1.Text = "Record " + count + " of " + (bs1.Count);
            lbTotalRecords.Text = " |  Total Records: " + (bs1.Count);
        }
        private void rowCountByHRP(int i)
        {
            i += 1;
            lbCount1.Text = "";
            lbCount1.Text = "Record " + i + " of " + (bs1.Count);
            lbTotalRecords.Text = " |  Total Records: " + (bs1.Count);
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowCountByHRP(dg1.CurrentRow.Index);
        }

        private void btnProjectDiscussion_Click(object sender, EventArgs e)
        {

        }
    }
}
