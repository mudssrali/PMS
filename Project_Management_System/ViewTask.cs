using DGVPrinterHelper;
using Project_Management_System.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class ViewTask : Form
    {
        public ViewTask()
        {
            InitializeComponent();
        }

        /*
         * Menustrip color changer class
        */
        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.GreenYellow; }
            }

            public override Color MenuBorder  //added for changing the menu border
            {
                get { return Color.Blue; }
            }

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
        int index = 0;
        string[] str = new string[15];

       
        private void ViewTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        /*
         * Sleep Thread
        */
        void SaveLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }
        private void ViewTask_Load(object sender, EventArgs e)
        {
            dg.BorderStyle = BorderStyle.None;
            dg.EnableHeadersVisualStyles = false;
            dg.GridColor = Color.Black;
            dg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular);
            msFilter.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
            using (var waitForm = new LoadingWait(SaveLoading))
            {
                waitForm.ShowDialog(this);
            }
            loadTaskData();
        }

        private void loadTaskData()
        {
            adap.SelectCommand = new SqlCommand("SELECT t.TASKID AS TASK_ID, t.TASKNAME AS TASK_NAME,e.empfirstName + ' ' +e. empLastName AS EMPLOYEE_NAME, p.Projectid as PROJ_ID,t.PRIORITY AS TASK_PRIORITY,t.Status AS TASK_STATUS, t.LABEL AS TASK_LABEL, t.ESTIMATEDDATE AS ESTIMATED_DATE, t.STARTDATE AS START_DATE, t.DUEDATE AS DUE_DATE, t.ENDDATE AS END_DATE, t.PROGRESS AS TASK_PROGRESS, t.DESCRIPTION AS TASK_DISCRIPTION FROM Task t, Project p, Employee e where t.projectid=p.projectid AND t.empid=e.empid", con);
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
                lbTotalRecords.Text = " |  Total Records: 0";

            }
        }
        /*
         * button Back to manager panel
        */
        private void btnBackToMGRPanel_Click(object sender, EventArgs e)
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
            int count = (bs.Position) + 1;
            lbCount.Text = "Record " + count + " of " + (bs.Count);
            lbTotalRecords.Text = " |  Total Records: " + (bs.Count);
        }

        /*
         * Printing report 
        */

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Project Tasks Details"; // Header
            printer.SubTitle = DateTime.Now.ToString("MM-dd-yyyy  hh:mm:ss tt");
            printer.PageSettings.Landscape = true;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dg);
        }

        /*
         * Closing application event
        */
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Exit application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);
            }
        }
        /*
         * Updating records 
        */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                bool f1 = dg.Rows[bs.Position].Selected == true;
                bool f2 = dg.Rows[index].Selected == true;
                if (f1 || f2)
                {
                    int Id = Convert.ToInt32(ds.Tables[0].Rows[bs.Position][0]);
                    int Id1 = Convert.ToInt32(ds.Tables[0].Rows[index][0]);
                    if (Id == Id1)
                        Id = Id1;
                    else if (Id1 > Id || Id1 < Id && f2)
                        Id = Id1;
                    SqlCommand getData = new SqlCommand("SELECT *FROM TASK WHERE TASKID='" + Id + "'", con);
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
                    tbTaskName.Text = str[1];
                    cbType.Text = str[2];
                    cbStatus.Text = str[3];
                    cbPriority.Text = str[4];
                    cbLabel.Text = str[5];
                    fillCBEMP(str[6]);
                    ExpectedDate.Value = Convert.ToDateTime(str[7]);
                    StartDate.Value = Convert.ToDateTime(str[8]);
                    DueDate.Value = Convert.ToDateTime(str[9]);
                    EndDate.Value = Convert.ToDateTime(str[10]);
                    fillCBProject(str[11]);
                    cbProgress.Text = str[12];
                    tbDescription.Text = str[13];
                    lbCount.Visible = false;
                    lbTask.Text = "";
                    lbTask.Text = "TASK UPDATION";
                    lbCount.Visible = false;
                    tbSearchRecords.Visible = false;
                    btnSearch.Visible = false;
                    lbTotalRecords.Visible = false;
                    msFilter.Visible = false;
                    lbFilterStatus.Visible = false;
                    lbFilterState.Visible = false;
                    lbSearch.Visible = false;
                    lbSearchStae.Visible = false;
                    Util.Animate(_PanelView, Util.Effect.Slide, 200, 360);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please select the record first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "There is no record found to update!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /*
         * Method to fill emp combo box 
        */

        void fillCBEMP(string id)
        {
            cbAssignedTo.Items.Clear();
            string query = "SELECT EmpfirstName, EmplastName FROM EMPLOYEE where empid = '"+id+"'";
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
                    sName1 = dr.GetString(0);
                    sName2 = dr.GetString(1);
                    cbAssignedTo.Text = id + " " + sName1 + " " + sName2;
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        /*
         * Method to fill project combobox 
        */

        void fillCBProject(string Id)

        {
            string query = "SELECT projectname from Project where projectid ='" + Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            string sName1 = "";
            try
            {
                while (dr.Read())
                {
                    sName1 = dr.GetString(0);
                    cbSelectedProject.Text = Id + " " + sName1;
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        /*
         * Deleting selected record 
        */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                bool f1 = dg.Rows[bs.Position].Selected == true;
                bool f2 = dg.Rows[index].Selected == true;
                if (f1 || f2)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt32(ds.Tables[0].Rows[bs.Position][0]);
                        int Id1 = Convert.ToInt32(ds.Tables[0].Rows[index][0]);
                        if (Id == Id1)
                            Id = Id1;
                        else if (Id1 > Id || Id1 < Id && f2)
                            Id = Id1;
                        adap.DeleteCommand = new SqlCommand("Delete From Task WHERE Convert(Varchar,TASKID)='" + Id + "'", con);
                        con.Open();
                        adap.DeleteCommand.ExecuteNonQuery();
                        con.Close();
                        using (var waitForm = new DeleteWait(Save))
                        {
                            waitForm.ShowDialog(this);

                        }
                        if (MetroFramework.MetroMessageBox.Show(this, "Record has been Deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            lbFilterState.Text = "OFF";
                            lbFilterState.ForeColor = Color.White;
                            lbSearchStae.Text = "NONE";
                            loadTaskData();
                        }
                    }
                    else
                    {
                    
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "There is no record found to delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /*
         * Back buttton 
        */
        private void btnBackToMGRPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.Close();
            }
        }
        /*
         * Searching records 
        */
        private void tbSearchRecords_TextChanged(object sender, EventArgs e)
        {
            adap.SelectCommand = new SqlCommand("SELECT t.TASKID AS TASK_ID, t.TASKNAME AS TASK_NAME,e.empfirstName + ' ' +e. empLastName AS EMPLOYEE_NAME, p.Projectid as PROJ_ID,t.PRIORITY AS TASK_PRIORITY,t.Status AS TASK_STATUS, t.LABEL AS TASK_LABEL, t.ESTIMATEDDATE AS ESTIMATED_DATE, t.STARTDATE AS START_DATE, t.DUEDATE AS DUE_DATE, t.ENDDATE AS END_DATE, t.PROGRESS AS TASK_PROGRESS, t.DESCRIPTION AS TASK_DISCRIPTION FROM Task t, Project p, Employee e where t.projectid=p.projectid AND t.empid=e.empid AND (Convert(varchar,t.TASKID)='" + tbSearchRecords.Text + "' OR t.TASKNAME LIKE'%" + tbSearchRecords.Text + "%' OR t.TASKTYPE LIKE'%" + tbSearchRecords.Text + "%' OR t.PRIORITY LIKE'%" + tbSearchRecords.Text + "%' OR t.LABEL LIKE'%" + tbSearchRecords.Text + "%' OR t.DESCRIPTION LIKE'%" + tbSearchRecords.Text + "%')", con);
            ds.Clear();
            adap.Fill(ds);
            dg.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
            if (bs.Count > 0)
            {
                bs.MoveFirst();
                updateGrid();
                lbSearchStae.Text = "FOUND";
            }
            else
            {
                lbCount.Text = "";
                int count = 0;
                lbCount.Text = "Record " + count + " of 0";
                lbTotalRecords.Text = " |  Total Records: 0";
                lbSearchStae.Text = "NONE";
            }
            if (tbSearchRecords.Text.Length == 0)
                lbSearchStae.Text = "NONE";
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

        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*
         * Row counter by row header
         */
        private void rowCountByHR(int i)
        {
            i += 1;
            lbCount.Text = "";
            lbCount.Text = "Record " + i + " of " + (bs.Count);
            lbTotalRecords.Text = " |  Total Records: " + (bs.Count);
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dg.CurrentRow.Index;
            rowCountByHR(index);
        }
        /*
         * Updating record confirmation 
        */
        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                adap.UpdateCommand = new SqlCommand("Update Task SET TASKNAME = @TASKNAME, TASKTYPE = @TASKTYPE, STATUS = @STATUS, PRIORITY = @PRIORITY, LABEL = @LABEL, EMPID = @EMPID,ESTIMATEDDATE = @ESTIMATEDDATE,STARTDATE = @STARTDATE, DUEDATE = @DUEDATE,ENDDATE = @ENDDATE,PROJECTID = @PROJECTID,PROGRESS = @PROGRESS, DESCRIPTION = @DESCRIPTION WHERE Convert(Varchar,TASKID)='" + str[0] + "'", con);
                adap.UpdateCommand.Parameters.AddWithValue("@TaskName", tbTaskName.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@TaskType", cbType.Text);
                if (cbProgress.Text == "100")
                {
                    adap.UpdateCommand.Parameters.AddWithValue("@Status", "Done");
                }
                else
                {
                    adap.UpdateCommand.Parameters.AddWithValue("@Status", cbStatus.Text);
                }
                adap.UpdateCommand.Parameters.AddWithValue("@Priority", cbPriority.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Label", cbLabel.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@EmpID", Convert.ToInt32(cbAssignedTo.Text.Substring(0, cbAssignedTo.Text.IndexOf(' '))));
                adap.UpdateCommand.Parameters.AddWithValue("@EstimatedDate", ExpectedDate.Value.Date);
                adap.UpdateCommand.Parameters.AddWithValue("@ProjectId", Convert.ToInt32(cbSelectedProject.Text.Substring(0, cbSelectedProject.Text.IndexOf(' '))));
                adap.UpdateCommand.Parameters.AddWithValue("@StartDate", StartDate.Value.Date);
                adap.UpdateCommand.Parameters.AddWithValue("@DueDate", DueDate.Value.Date);
                if (cbProgress.Text == "100")
                {
                    adap.UpdateCommand.Parameters.AddWithValue("@EndDate", DateTime.Now.Date);
                }
                else
                {
                    adap.UpdateCommand.Parameters.AddWithValue("@EndDate", EndDate.Value.Date);
                }
                adap.UpdateCommand.Parameters.AddWithValue("@Progress", Convert.ToInt32(cbProgress.Text));
                adap.UpdateCommand.Parameters.AddWithValue("@Description", tbDescription.Text);

                con.Open();
                adap.UpdateCommand.ExecuteNonQuery();
                con.Close();
                using (var waitForm = new UpdatingWait(Save))
                {
                    waitForm.ShowDialog(this);
                }
                if (MetroFramework.MetroMessageBox.Show(this, "Record has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Util.Animate(_PanelView, Util.Effect.Slide, 200, 360);
                    lbTask.Text = "";
                    lbTask.Text = "TASK INFORMATION";
                    lbCount.Visible = true;
                    tbSearchRecords.Visible = true;
                    tbSearchRecords.Clear();
                    btnSearch.Visible = true;
                    lbTotalRecords.Visible = true;
                    msFilter.Visible = true;
                    lbFilterState.Text = "OFF";
                    lbFilterState.ForeColor = Color.White;
                    lbSearchStae.Text = "NONE";
                    lbFilterStatus.Visible = true;
                    lbFilterState.Visible = true;
                    lbSearch.Visible = true;
                    lbSearchStae.Visible = true;

                    loadTaskData();

                }
            }

        }
        /*
         * Cancel button on update panel 
        */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lbCount.Visible = true;
                tbSearchRecords.Visible = true;
                btnSearch.Visible = true;
                lbTotalRecords.Visible = true;
                msFilter.Visible = true;
                lbFilterStatus.Visible = true;
                lbFilterState.Visible = true;
                lbSearch.Visible = true;
                lbSearchStae.Visible = true;
                Util.Animate(_PanelView, Util.Effect.Slide, 200, 360);
            }
        }
        /*
         * Back button on update panel 
        */
        private void btnBack_Click(object sender, EventArgs e)
        {
            lbTask.Text = "";
            lbTask.Text = "TASK INFORMATION";
            lbCount.Visible = true;
            tbSearchRecords.Visible = true;
            btnSearch.Visible = true;
            lbTotalRecords.Visible = true;
            msFilter.Visible = true;
            lbFilterStatus.Visible = true;
            lbFilterState.Visible = true;
            lbSearch.Visible = true;
            lbSearchStae.Visible = true;
            Util.Animate(_PanelView, Util.Effect.Slide, 200, 360);
        }
        /*
         * To avoid enter key in multiline texbox 
        */
        private void tbSearchRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        /*
         * Updater function to select first record 
        */
        private void updaterFunc()
        {
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
            if (bs.Count > 0)
            {
                bs.MoveFirst();
                updateGrid();
            }
            else
            {
                lbCount.Text = "";
                lbCount.Text = "Record 0 of 0";
                lbTotalRecords.Text = " |  Total Records: 0";
            }
        }
        /*
         * Priority filter
        */

        private void recordFilterPriority(string f1)
        {
            adap.SelectCommand = new SqlCommand("SELECT t.TASKID AS TASK_ID, t.TASKNAME AS TASK_NAME,e.empfirstName + ' ' +e. empLastName AS EMPLOYEE_NAME, p.Projectid as PROJ_ID,t.PRIORITY AS TASK_PRIORITY,t.Status AS TASK_STATUS, t.LABEL AS TASK_LABEL, t.ESTIMATEDDATE AS ESTIMATED_DATE, t.STARTDATE AS START_DATE, t.DUEDATE AS DUE_DATE, t.ENDDATE AS END_DATE, t.PROGRESS AS TASK_PROGRESS, t.DESCRIPTION AS TASK_DISCRIPTION FROM Task t, Project p, Employee e where t.projectid=p.projectid AND t.empid=e.empid AND t.PRIORITY='" + f1 + "'", con);
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
                lbTotalRecords.Text = " |  Total Records: 0";

            }
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
        }
        /*
        * Status filter
       */
        private void recordFilterStatus(string f1)
        {
            adap.SelectCommand = new SqlCommand("SELECT t.TASKID AS TASK_ID, t.TASKNAME AS TASK_NAME,e.empfirstName + ' ' +e. empLastName AS EMPLOYEE_NAME, p.Projectid as PROJ_ID,t.PRIORITY AS TASK_PRIORITY,t.Status AS TASK_STATUS, t.LABEL AS TASK_LABEL, t.ESTIMATEDDATE AS ESTIMATED_DATE, t.STARTDATE AS START_DATE, t.DUEDATE AS DUE_DATE, t.ENDDATE AS END_DATE, t.PROGRESS AS TASK_PROGRESS, t.DESCRIPTION AS TASK_DISCRIPTION FROM Task t, Project p, Employee e where t.projectid=p.projectid AND t.empid=e.empid AND t.status='" + f1 + "'", con);
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
                lbTotalRecords.Text = " |  Total Records: 0";

            }
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
        }
        /*
         * Label filter
        */

        private void recordFilterLabel(string f1)
        {
            adap.SelectCommand = new SqlCommand("SELECT t.TASKID AS TASK_ID, t.TASKNAME AS TASK_NAME,e.empfirstName + ' ' +e. empLastName AS EMPLOYEE_NAME, p.Projectid as PROJ_ID,t.PRIORITY AS TASK_PRIORITY,t.Status AS TASK_STATUS, t.LABEL AS TASK_LABEL, t.ESTIMATEDDATE AS ESTIMATED_DATE, t.STARTDATE AS START_DATE, t.DUEDATE AS DUE_DATE, t.ENDDATE AS END_DATE, t.PROGRESS AS TASK_PROGRESS, t.DESCRIPTION AS TASK_DISCRIPTION FROM Task t, Project p, Employee e where t.projectid=p.projectid AND t.empid=e.empid AND t.label='" + f1 + "'", con);
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
                lbTotalRecords.Text = " |  Total Records: 0";

            }
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
        }
        /*
         * Project Status filter 
        */
        private void recordFilterProjectStatus(string f1)
        {
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
            adap.SelectCommand = new SqlCommand("SELECT t.TASKID AS TASK_ID, t.TASKNAME AS TASK_NAME,e.empfirstName + ' ' +e. empLastName AS EMPLOYEE_NAME, p.Projectid as PROJ_ID,t.PRIORITY AS TASK_PRIORITY,t.Status AS TASK_STATUS, t.LABEL AS TASK_LABEL, t.ESTIMATEDDATE AS ESTIMATED_DATE, t.STARTDATE AS START_DATE, t.DUEDATE AS DUE_DATE, t.ENDDATE AS END_DATE, t.PROGRESS AS TASK_PROGRESS, t.DESCRIPTION AS TASK_DISCRIPTION FROM Task t, Project p, Employee e where t.projectid=p.projectid AND t.empid=e.empid AND p.Status='" + f1 + "'", con);
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
                lbTotalRecords.Text = " |  Total Records: 0";
            }
        }
        /*
         * Project Type filter
        */
        private void recordFilterProjectType(string f1)
        {
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
            adap.SelectCommand = new SqlCommand("SELECT t.TASKID AS TASK_ID, t.TASKNAME AS TASK_NAME,e.empfirstName + ' ' +e. empLastName AS EMPLOYEE_NAME, p.Projectid as PROJ_ID,t.PRIORITY AS TASK_PRIORITY,t.Status AS TASK_STATUS, t.LABEL AS TASK_LABEL, t.ESTIMATEDDATE AS ESTIMATED_DATE, t.STARTDATE AS START_DATE, t.DUEDATE AS DUE_DATE, t.ENDDATE AS END_DATE, t.PROGRESS AS TASK_PROGRESS, t.DESCRIPTION AS TASK_DISCRIPTION FROM Task t, Project p, Employee e where t.projectid=p.projectid AND t.empid=e.empid AND p.type='" + f1 + "'", con);
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
                lbTotalRecords.Text = " |  Total Records: 0";
            }
        }

        /*
         * All Filter cleaner 
        */
        void clearFilter()
        {
            loadTaskData();
            CSF();
            CPF();
            CLF();
            CPSF();
            CPTF();
        }

        /*
         * Priority cleaner 
        */
        private void CPF()
        {
            f1 = f2 = f3 = f4 = f5 = 0;
            highToolStripMenuItem.Checked = false;
            lowToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            urgentToolStripMenuItem.Checked = false;
            unknownToolStripMenuItem.Checked = false;
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
        }
        /*
         * Status Cleaner 
        */
        private void CSF()
        {
            s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = 0;
            openToolStripMenuItem.Checked = false;
            closedToolStripMenuItem.Checked = false;
            paidToolStripMenuItem.Checked = false;
            lostToolStripMenuItem.Checked = false;
            suspendToolStripMenuItem.Checked = false;
            completedToolStripMenuItem.Checked = false;
            doneToolStripMenuItem.Checked = false;
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
        }
        /*
         * Label Cleaner 
        */
        private void CLF()
        {
            l1 = l2 = l3 = l4 = l5 = l6 = l7 = 0;
            bugToolStripMenuItem.Checked = false;
            taskToolStripMenuItem.Checked = false;
            issueToolStripMenuItem.Checked = false;
            qouteToolStripMenuItem.Checked = false;
            ideaToolStripMenuItem.Checked = false;
            plugInToolStripMenuItem.Checked = false;
            taskToolStripMenuItem.Checked = false;
            changeToolStripMenuItem.Checked = false;
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
        }
        /*
         * Project Status  
        */
        private void CPSF()
        {
            p1 = p2 = p3 = p4 = 0;
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
            openToolStripMenuItem1.Checked = false;
            closedToolStripMenuItem1.Checked = false;
            onHoldToolStripMenuItem.Checked = false;
            cancelledToolStripMenuItem.Checked = false;
        }
        /*
         * Project Type 
        */
        private void CPTF()
        {
            t1 = t2 = t3 = 0;
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
            newSiteToolStripMenuItem.Checked = false;
            supportToolStripMenuItem.Checked = false;
            internalToolStripMenuItem.Checked = false;
        }
        private void clearPriorityFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTaskData();
            CPF();
        }
        int f1, f2, f3, f4, f5;
        /*
        * Priority Submenu
        */
        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = 0;
            f2 = 0;
            f3 = 0;
            f4 = 0;
            f5 = 0;
            ds.Clear();
            CSF(); CLF(); CPSF(); CPTF();
            if (highToolStripMenuItem.Checked)
            {
                recordFilterPriority("high");
                f1 = 1;
            }
            if (lowToolStripMenuItem.Checked)
            {
                recordFilterPriority("low");
                f2 = 1;
            }
            if (urgentToolStripMenuItem.Checked)
            {
                recordFilterPriority("urgent");
                f3 = 1;
            }
            if (unknownToolStripMenuItem.Checked)
            {
                recordFilterPriority("unknown");
                f4 = 1;
            }
            if (mediumToolStripMenuItem.Checked)
            {
                recordFilterPriority("medium");
                f5 = 1;
            }
            if (f1 + f2 + f3 + f4 + f5 == 0)
            {
                loadTaskData();
                CPF();
                lbFilterState.Text = "OFF";
                lbFilterState.ForeColor = Color.White;
            }
        }
        /*
         *  Status cleaner
        */
        private void clearStatusFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTaskData();
            CSF();
        }
        /*
        * Status Submenu 
        */
        int s1, s2, s3, s4, s5, s6, s7, s8;
        /*
         * to prevent from inputting 
        */
        private void cbAssignedTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSelectedProject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;
        }

        /*
* Project Type Filter 
*/

        private void clearProjectTypeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPTF();
            loadTaskData();
        }
        int t1, t2, t3;
        private void projectTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLF();
            CPF();
            CSF();
            CPSF();
            ds.Clear();
            t1 = t2 = t3 = 0;
            if (supportToolStripMenuItem.Checked)
            {
                recordFilterProjectType("support");
                t1 = 1;
            }
            if (newSiteToolStripMenuItem.Checked)
            {
                recordFilterProjectType("New Site");
                t2 = 1;
            }
            if (internalToolStripMenuItem.Checked)
            {
                recordFilterProjectType("internal");
                t3 = 1;
            }
            if (t1 + t2 + t3 == 0)
            {
                CPTF();
                loadTaskData();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ds.Clear();
            CPF();
            CLF();
            CPTF();
            CPSF();
            s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = 0;
            if (openToolStripMenuItem.Checked)
            {
                recordFilterStatus("open");
                s1 = 1;
            }
            if (doneToolStripMenuItem.Checked)
            {
                recordFilterStatus("done");
                s2 = 1;
            }
            if (closedToolStripMenuItem.Checked)
            {
                recordFilterStatus("closed");
                s3 = 1;
            }
            if (paidToolStripMenuItem.Checked)
            {
                recordFilterStatus("paid");
                s4 = 1;
            }
            if (suspendToolStripMenuItem.Checked)
            {
                recordFilterStatus("suspend");
                s5 = 1;
            }
            if (completedToolStripMenuItem.Checked)
            {
                recordFilterStatus("completed");
                s6 = 1;
            }
            if (lostToolStripMenuItem.Checked)
            {
                recordFilterStatus("lost");
                s7 = 1;
            }
            if (reOpenToolStripMenuItem.Checked)
            {
                recordFilterStatus("Re-Open");
                s8 = 1;
            }
            if (s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 == 0)
            {
                loadTaskData();
                CSF();
            }
        }
        /*
        * Label filter cleaner 
        */
        private void clearLabelFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTaskData();
            CLF();
        }

        int l1, l2, l3, l4, l5, l6, l7;
        /*
         * Label filter 
        */
        private void bugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l1 = l2 = l3 = l4 = l5 = l6 = l7 = 0;
            CSF(); CPF();
            CPTF();
            CPSF();
            ds.Clear();
            if (bugToolStripMenuItem.Checked)
            {
                recordFilterLabel("bug");
                l1 = 1;
            }
            if (ideaToolStripMenuItem.Checked)
            {
                recordFilterLabel("idea");
                l2 = 1;
            }
            if (taskToolStripMenuItem.Checked)
            {
                recordFilterLabel("task");
                l3 = 1;
            }
            if (qouteToolStripMenuItem.Checked)
            {
                recordFilterLabel("qoute");
                l4 = 1;
            }
            if (issueToolStripMenuItem.Checked)
            {
                recordFilterLabel("issue");
                l5 = 1;
            }
            if (changeToolStripMenuItem.Checked)
            {
                recordFilterLabel("change");
                l6 = 1;
            }
            if (plugInToolStripMenuItem.Checked)
            {
                recordFilterLabel("PlugIn");
                l7 = 1;
            }
            if (l1 + l2 + l3 + l4 + l5 + l6 + l7 == 0)
            {
                CLF();
                loadTaskData();
            }
        }

        /*
         * Project Status Filter
        */

        private void clearProjectStatusFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTaskData();
            CPSF();
        }
        int p1, p2, p3, p4;
        private void projectStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLF();
            CSF();
            CPF();
            CPTF();
            ds.Clear();
            p1 = p2 = p3 = p4 = 0;
            if (openToolStripMenuItem1.Checked)
            {
                recordFilterProjectStatus("open");
                p1 = 1;
            }
            if (closedToolStripMenuItem1.Checked)
            {
                recordFilterProjectStatus("closed");
                p2 = 1;
            }
            if (onHoldToolStripMenuItem.Checked)
            {
                recordFilterProjectStatus("On hold");
                p3 = 1;
            }
            if (cancelledToolStripMenuItem.Checked)
            {
                recordFilterProjectStatus("cancelled");
                p4 = 1;
            }
            if (p1 + p2 + p3 + p4 == 0)
            {
                CPSF();
                loadTaskData();
            }

        }

        private void clearFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFilter();
        }

    }
}
