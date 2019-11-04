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
    public partial class ViewTeam : Form
    {
        public ViewTeam()
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
        private void loadTeamData()
        {

            adap.SelectCommand = new SqlCommand("SELECT t.teamID As TEAM_ID, t.TeamName as TEAM_NAME, t.creationDate as TEAM_CREATED_DATE,p.PROJECTID AS PROJECT_ID, p.ProjectNAME AS PROJECT_NAME,e.EMPID as EMP_NO, e.EMPFirstName+' '+e.EMPLastName as EMP_NAME, e.Job as EMP_JOB FROM project p,Team t,TeamMember tm, Employee e  WHERE p.TeamID=t.TeamID AND tm.TeamID = t.TeamID AND tm.EMPID = e.EMPID", con);
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
        private void ViewTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
        /*
         * Form loader 
        */
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
        private void ViewTeam_Load(object sender, EventArgs e)
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
            loadTeamData();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Exit application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
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
                 * Row counter
                */
        private void rowCountByHR(int i)
        {
            i += 1;
            lbCount.Text = "";
            lbCount.Text = "Record " + i + " of" + (bs.Count);
            lbTotalRecords.Text = " |  Total Records: " + (bs.Count);
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dg.CurrentRow.Index;
            rowCountByHR(index);
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
            lbCount.Text = "";
            int count = (bs.Position) + 1;
            lbCount.Text = "Record " + count + " of " + (bs.Count);
            lbTotalRecords.Text = "|  Total Records: " + (bs.Count);
        }

        /*
         * Printing report 
        */

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Team Details"; // Header
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
         *Searching records 
        */
        private void tbSearchRecords_TextChanged(object sender, EventArgs e)
        {

            adap.SelectCommand = new SqlCommand("SELECT t.teamID As TEAM_ID, t.TeamName as TEAM_NAME, t.creationDate as TEAM_CREATED_DATE,p.PROJECTID AS PROJECT_ID, p.ProjectNAME AS PROJECT_NAME,e.EMPID as EMP_NO, e.EMPFirstName+' '+e.EMPLastName as EMP_NAME, e.Job as EMP_JOB FROM project p,Team t,TeamMember tm, Employee e  WHERE p.TeamID=t.TeamID AND tm.TeamID = t.TeamID AND tm.EMPID = e.EMPID  AND (convert ( varchar , t.teamId) ='" + tbSearchRecords.Text + "' OR  t.TeamName like  '%" + tbSearchRecords.Text + "%' OR p.ProjectNAME like '%" + tbSearchRecords.Text + "%' OR  e.EMPFirstName like '%" + tbSearchRecords.Text + "%' OR  e.EMPLastName like '%" + tbSearchRecords.Text + "%' OR e.Job like '%" + tbSearchRecords.Text + "%')", con);
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
         * Project Status and Type filters 
        */
        private void recordFilterByStatus(string fil)
        {
            adap.SelectCommand = new SqlCommand("SELECT t.teamID As TEAM_ID, t.TeamName as TEAM_NAME, t.creationDate as TEAM_CREATED_DATE,p.PROJECTID AS PROJECT_ID, p.ProjectNAME AS PROJECT_NAME,e.EMPID as EMP_NO, e.EMPFirstName+' '+e.EMPLastName as EMP_NAME, e.Job as EMP_JOB FROM project p,Team t,TeamMember tm, Employee e  WHERE p.TeamID=t.TeamID AND tm.TeamID = t.TeamID AND tm.EMPID = e.EMPID AND p.Status='" + fil + "'", con);
            adap.Fill(ds);
            dg.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
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
        private void recordFilterByType(string fil)
        {
            adap.SelectCommand = new SqlCommand("SELECT t.teamID As TEAM_ID, t.TeamName as TEAM_NAME, t.creationDate as TEAM_CREATED_DATE,p.PROJECTID AS PROJECT_ID, p.ProjectNAME AS PROJECT_NAME,e.EMPID as EMP_NO, e.EMPFirstName+' '+e.EMPLastName as EMP_NAME, e.Job as EMP_JOB FROM project p,Team t,TeamMember tm, Employee e  WHERE p.TeamID=t.TeamID AND tm.TeamID = t.TeamID AND tm.EMPID = e.EMPID AND p.Type='" + fil + "'", con);
            adap.Fill(ds);
            dg.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
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
         * For Team members job (JOIN) 
        */
        private void recordFilter(string fil)
        {

            adap.SelectCommand = new SqlCommand("SELECT t.teamID As TEAM_ID, t.TeamName as TEAM_NAME, t.creationDate as TEAM_CREATED_DATE,p.PROJECTID AS PROJECT_ID, p.ProjectNAME AS PROJECT_NAME,e.EMPID as EMP_NO, e.EMPFirstName+' '+e.EMPLastName as EMP_NAME, e.Job as EMP_JOB FROM project p,Team t,TeamMember tm, Employee e  WHERE p.TeamID=t.TeamID AND tm.TeamID = t.TeamID AND tm.EMPID = e.EMPID AND e.Job='" + fil + "'", con);
            adap.Fill(ds);
            dg.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
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
        private void CGF()
        {
            g1 = g2 = g3 = g4 = g5 = g6 = g7 = 0;
            designerToolStripMenuItem.Checked = false;
            dBAToolStripMenuItem.Checked = false;
            analystToolStripMenuItem.Checked = false;
            testerToolStripMenuItem.Checked = false;
            programmerToolStripMenuItem.Checked = false;
            adminToolStripMenuItem.Checked = false;
            qAToolStripMenuItem.Checked = false;
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
        }

        /*
         * Clear all filter 
        */
        private void clearFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPSF();
            CPTF();
            CGF();
            loadTeamData();
        }
        /*
         * Project Status  
        */
        private void CPSF()
        {
            p1 = p2 = p3 = p4 = 0;
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
            openToolStripMenuItem.Checked = false;
            closeToolStripMenuItem.Checked = false;
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
        /*
         * Project Status filter
        */
        bool f1 = false;
        bool f2 = false;
        bool f3 = false;
        int p1, p2, p3, p4;
        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = false;
            CPTF();
            CGF();
            ds.Clear();
            p1 = p2 = p3 = p4 = 0;
            if (openToolStripMenuItem.Checked)
            {
                f1 = true;
                recordFilterByStatus("open");
                p1 = 1;
            }
            if (closeToolStripMenuItem.Checked)
            {
                f1 = true;
                recordFilterByStatus("closed");
                p2 = 1;
            }
            if (onHoldToolStripMenuItem.Checked)
            {
                f1 = true;
                recordFilterByStatus("On hold");
                p3 = 1;
            }
            if (cancelledToolStripMenuItem.Checked)
            {
                f1 = true;
                recordFilterByStatus("cancelled");
                p4 = 1;
            }
            if (p1 + p2 + p3 + p4 == 0)
            {
                f1 = false;
                CPSF();
                loadTeamData();
            }

        }
        private void clearStatusFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(f2 || f3))
            {
                CPSF();
                loadTeamData();
            }
        }
        /*
         * Project type filter
        */
        int t1, t2, t3;
        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = false;
            CPSF();
            ds.Clear();
            t1 = t2 = t3 = 0;
            if (supportToolStripMenuItem.Checked)
            {
                f2 = true;
                recordFilterByType("support");
                t1 = 1;
            }
            if (newSiteToolStripMenuItem.Checked)
            {
                f2 = true;
                recordFilterByType("New Site");
                t2 = 1;
            }
            if (internalToolStripMenuItem.Checked)
            {
                f2 = true;
                recordFilterByType("internal");
                t3 = 1;
            }
            if (t1 + t2 + t3 == 0)
            {
                f2 = false;
                CPTF();
                loadTeamData();
            }

        }
        private void clearTypeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(f1 || f3))
            {
                CPTF();
                loadTeamData();
            }
        }
        /*
         * Project In team filter
        */
        int g1, g2, g3, g4, g5, g6, g7;
        private void inTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = false;
            g1 = g2 = g3 = g4 = g5 = g6 = g7 = 0;
            CPTF();
            CPSF();
            ds.Clear();
            if (designerToolStripMenuItem.Checked)
            {
                f3 = true;
                recordFilter("designer");
                g1 = 1;
            }
            if (testerToolStripMenuItem.Checked)
            {
                f3 = true;
                recordFilter("tester");
                g2 = 1;
            }
            if (qAToolStripMenuItem.Checked)
            {
                f3 = true;
                recordFilter("qa");
                g3 = 1;
            }
            if (programmerToolStripMenuItem.Checked)
            {
                f3 = true;
                recordFilter("programmer");
                g4 = 1;
            }
            if (dBAToolStripMenuItem.Checked)
            {
                f3 = true;
                recordFilter("dba");
                g5 = 1;
            }
            if (adminToolStripMenuItem.Checked)
            { 

               f3 = true;
                recordFilter("admin");
                g6 = 1;
            }
            if (analystToolStripMenuItem.Checked)
            {
                f3 = true;
                recordFilter("analyst");
                g7 = 1;
            }
            if (g1 + g2 + g3 + g4 + g5 + g6 + g7 == 0)
            {
                f3 = false;
                loadTeamData();
                CGF();
            }
        }
        private void clearInTeamFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(f1 || f2))
            {
                CGF();
                loadTeamData();
            }
        }

    }
}
