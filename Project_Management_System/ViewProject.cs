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
    public partial class ViewProject : Form
    {
        public ViewProject()
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
        private void ViewProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void ViewProject_Load(object sender, EventArgs e)
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
            loadProjectData();

        }


        private void loadProjectData()
        {
            adap.SelectCommand = new SqlCommand("SELECT p.PROJECTID AS PROJ_ID, c.CustomerFName +'  ' + c.customerLName  as Customer_Name ,t.teamName as TeamName,p.ProjectNAME AS PROJ_NAME, p.STATUS AS PROJ_STATUS, p.PRICE AS PROJ_PRICE, p.TYPE AS PROJ_TYPE, p.DESCRIPTION AS PROJ_DESCRIPTION FROM project p, Customer c, Team t WHERE p.CustomerId=c.CustomerId AND p.TeamID=t.TeamID", con);
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
        void Save()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(15);
            }
        }
        void SaveLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
            }
        }
        /*
         *  Back to mgr panel
         */
        private void btnBackToMGRPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.Close();
            }
        }
        /*
         * Method to search record 
        */
        private void tbSearchRecords_TextChanged(object sender, EventArgs e)
        {
            adap.SelectCommand = new SqlCommand("SELECT p.PROJECTID AS PROJ_ID, c.CustomerFName +' ' + c.customerLName  as Customer_Name ,t.teamName as TeamName,p.ProjectNAME AS PROJ_NAME, p.STATUS AS PROJ_STATUS, p.PRICE AS PROJ_PRICE, p.TYPE AS PROJ_TYPE, p.DESCRIPTION AS PROJ_DESCRIPTION FROM project p, Customer c, Team t WHERE p.CustomerId = c.CustomerId AND p.TeamID = t.TeamID AND (Convert(varchar, p.PROJECTID) like '%" + tbSearchRecords.Text + "%' OR p.projectNAME LIKE'%" + tbSearchRecords.Text + "%' OR p.TYPE LIKE'%" + tbSearchRecords.Text + "%' OR p.STATUS LIKE'%" + tbSearchRecords.Text + "%' OR p.DESCRIPTION LIKE'%" + tbSearchRecords.Text + "%' OR Convert(varchar, p.price) like '%" + tbSearchRecords.Text + "%')", con);
            //adap.SelectCommand = new SqlCommand("SELECT PROJECTID AS PRODJ_ID, projectNAME AS PRODJ_NAME,STATUS AS PRODJ_STATUS,PRICE AS PRODJ_PRICE, TYPE AS PRODJ_TYPE,DESCRIPTION AS PRODJ_DESCRIPTION FROM PROJECT Where Convert(varchar, PROJECTID)='" + tbSearchRecords.Text + "' OR projectNAME LIKE'%" + tbSearchRecords.Text + "%' OR TYPE LIKE'%" + tbSearchRecords.Text + "%' OR STATUS LIKE'%" + tbSearchRecords.Text + "%' OR DESCRIPTION LIKE'%" + tbSearchRecords.Text + "'", con);
            //	MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
            ds.Clear();
            adap.Fill(ds);
            //	MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
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
            printer.Title = "Project Details"; // Header
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
         * Closing form
        */
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * Updating records 
        */
        string[] str = new string[20];
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
                    SqlCommand getData = new SqlCommand("SELECT *FROM PROJECT WHERE PROJECTID='" + Id + "'", con);
                    SqlDataReader dataReader;
                    con.Open();
                    dataReader = getData.ExecuteReader();

                    int i = 0;
                    dataReader.Read();
                    while (i < 8)
                    {
                        if (i == 0 || i == 3 || i == 6 || i == 4)
                        {
                            str[i] = dataReader.GetValue(i).ToString();

                        }
                        else
                        {
                            str[i] = dataReader.GetString(i);
                        }
                        i++;
                    }
                    con.Close();

                    tbName.Text = str[1];
                    cbType.Text = str[2];
                    fillCBTeam(str[3]);
                    tbPrice.Text = str[4];
                    cbStatus.Text = str[5];
                    fillCBCustomer(str[6]); // Calling fill customer combo box
                    tbDescription.Text = str[7];
                    lbProejct.Text = "";
                    lbProejct.Text = "PROJECT UPDATION";
                    lbTotalRecords.Visible = false;
                    tbSearchRecords.Visible = false;
                    btnSearch.Visible = false;
                    msFilter.Visible = false;
                    lbCount.Visible = false;

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
         * Fillig data to customer combo box
        */
        void fillCBCustomer(string Id)
        {
            string query = "SELECT *FROM Customer where convert(varchar,customerid)='" + Id + "'";
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
                    cbCustomer.Text = sName1 + " " + sName2;

                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        /*
         * Method to fill the team combo box
        */
        void fillCBTeam(string Id)
        {

            string query = "SELECT *FROM Team where convert(varchar,teamID)='" + Id + "'";
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
                    cbTeam.Text = sName1 + " " + sName2;
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message);
            }
            con.Close();
        }
        /*
         * Deleting record method
        */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bs.Count > 0)
            {
                bool f1 = dg.Rows[bs.Position].Selected == true;
                bool f2 = dg.Rows[index].Selected == true;
                if (f1 || f2)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt32(ds.Tables[0].Rows[bs.Position][0]);
                        int Id1 = Convert.ToInt32(ds.Tables[0].Rows[index][0]);
                        if (Id == Id1)
                            Id = Id1;
                        else if (Id1 > Id || Id1 < Id && f2)
                            Id = Id1;
                        adap.DeleteCommand = new SqlCommand("Delete From  PROJECT WHERE Convert(Varchar,projectid)='" + Id + "'", con);
                        con.Open();
                        adap.DeleteCommand.ExecuteNonQuery().ToString();
                        con.Close();
                        using (var waitForm = new DeleteWait(Save))
                        {
                            waitForm.ShowDialog(this);
                        }
                        if (MetroFramework.MetroMessageBox.Show(this, "Record has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            lbFilterState.Text = "OFF";
                            lbFilterState.ForeColor = Color.White;
                            lbSearchStae.Text = "NONE";
                            loadProjectData();
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please select the record first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "There is no record found to delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Exit application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                adap.UpdateCommand = new SqlCommand("Update PROJECT SET PROJECTNAME = @PROJECTNAME, TYPE = @TYPE,TEAMID = @TEAMID,PRICE = @PRICE, STATUS = @STATUS, CUSTOMERID = @CUSTOMERID,DESCRIPTION = @DESCRIPTION WHERE Convert(Varchar,PROJECTID)='" + str[0] + "'", con);
                adap.UpdateCommand.Parameters.AddWithValue("@projectName", tbName.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Type", cbType.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@TeamID", Convert.ToInt32(cbTeam.Text.Substring(0, cbTeam.Text.IndexOf(' '))));
                adap.UpdateCommand.Parameters.AddWithValue("@price", Convert.ToInt32(tbPrice.Text));
                adap.UpdateCommand.Parameters.AddWithValue("@Status", cbStatus.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(cbCustomer.Text.Substring(0, cbCustomer.Text.IndexOf(' '))));
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
                    lbProejct.Text = "";
                    lbProejct.Text = "PROJECT INFORMATION";
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
                    loadProjectData();
                }
            }

        }
        /*
         * Method to cancel updation
        */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                _PanelUpdate.Refresh();
                lbProejct.Text = "";
                lbProejct.Text = "PROJECT INFORMATION";
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
         * Method to back to project information panel  
        */
        private void btnBack_Click(object sender, EventArgs e)
        {
            lbProejct.Text = "";
            lbProejct.Text = "PROJECT INFORMATION";
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
         * Project Status and Type filters 
        */
        private void recordFilterByStatus(string fil)
        {


            adap.SelectCommand = new SqlCommand("SELECT p.PROJECTID AS PROJ_ID, c.CustomerFName +'  ' + c.customerLName  as Customer_Name ,t.teamName as TeamName,p.ProjectNAME AS PROJ_NAME, p.STATUS AS PROJ_STATUS, p.PRICE AS PROJ_PRICE, p.TYPE AS PROJ_TYPE, p.DESCRIPTION AS PROJ_DESCRIPTION FROM project p, Customer c, Team t WHERE p.CustomerId=c.CustomerId AND p.TeamID=t.TeamID AND p.Status='" + fil + "'", con);
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
            adap.SelectCommand = new SqlCommand("SELECT p.PROJECTID AS PROJ_ID, c.CustomerFName +'  ' + c.customerLName  as Customer_Name ,t.teamName as TeamName,p.ProjectNAME AS PROJ_NAME, p.STATUS AS PROJ_STATUS, p.PRICE AS PROJ_PRICE, p.TYPE AS PROJ_TYPE, p.DESCRIPTION AS PROJ_DESCRIPTION FROM project p, Customer c, Team t WHERE p.CustomerId=c.CustomerId AND p.TeamID=t.TeamID AND p.Type='" + fil + "'", con);
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
            adap.SelectCommand = new SqlCommand("SELECT distinct p.PROJECTID AS PROJ_ID, c.CustomerFName +'  ' + c.customerLName  as Customer_Name ,t.teamName as TeamName,p.ProjectNAME AS PROJ_NAME, p.STATUS AS PROJ_STATUS, p.PRICE AS PROJ_PRICE, p.TYPE AS PROJ_TYPE, p.DESCRIPTION AS PROJ_DESCRIPTION FROM project p, Customer c, Team t, TeamMember tm, Employee e WHERE p.CustomerId=c.CustomerId AND p.TeamID=t.TeamID AND tm.TeamID = t.TeamID AND tm.EMPID = e.EMPID AND e.Job='" + fil + "'", con);

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
            loadProjectData();
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
        int p1, p2, p3, p4;
        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPTF();
            CGF();
            ds.Clear();
            p1 = p2 = p3 = p4 = 0;
            if (openToolStripMenuItem.Checked)
            {
                recordFilterByStatus("open");
                p1 = 1;
            }
            if (closeToolStripMenuItem.Checked)
            {
                recordFilterByStatus("closed");
                p2 = 1;
            }
            if (onHoldToolStripMenuItem.Checked)
            {
                recordFilterByStatus("On hold");
                p3 = 1;
            }
            if (cancelledToolStripMenuItem.Checked)
            {
                recordFilterByStatus("cancelled");
                p4 = 1;
            }
            if (p1 + p2 + p3 + p4 == 0)
            {
                CPSF();
                loadProjectData();
            }

        }
        private void clearStatusFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPSF();
            loadProjectData();
        }
        /*
         * Project type filter
        */
        int t1, t2, t3;

        private void cbTeam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPSF();
            ds.Clear();
            t1 = t2 = t3 = 0;
            if (supportToolStripMenuItem.Checked)
            {
                recordFilterByType("support");
                t1 = 1;
            }
            if (newSiteToolStripMenuItem.Checked)
            {
                recordFilterByType("New Site");
                t2 = 1;
            }
            if (internalToolStripMenuItem.Checked)
            {
                recordFilterByType("internal");
                t3 = 1;
            }
            if (t1 + t2 + t3 == 0)
            {
                CPTF();
                loadProjectData();
            }

        }
        private void clearTypeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPTF();
            loadProjectData();
        }
        /*
         * Project In team filter
        */
        int g1, g2, g3, g4, g5, g6, g7;
        private void inTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g1 = g2 = g3 = g4 = g5 = g6 = g7 = 0;
            CPTF();
            CPSF();
            ds.Clear();
            if (designerToolStripMenuItem.Checked)
            {
                recordFilter("designer");
                g1 = 1;
            }
            if (testerToolStripMenuItem.Checked)
            {
                recordFilter("tester");
                g2 = 1;
            }
            if (qAToolStripMenuItem.Checked)
            {
                recordFilter("qa");
                g3 = 1;
            }
            if (programmerToolStripMenuItem.Checked)
            {
                recordFilter("programmer");
                g4 = 1;
            }
            if (dBAToolStripMenuItem.Checked)
            {
                recordFilter("dba");
                g5 = 1;
            }
            if (adminToolStripMenuItem.Checked)
            {
                recordFilter("admin");
                g6 = 1;
            }
            if (analystToolStripMenuItem.Checked)
            {
                recordFilter("analyst");
                g7 = 1;
            }
            if (g1 + g2 + g3 + g4 + g5 + g6 + g7 == 0)
            {
                loadProjectData();
                CGF();
            }
        }
        private void clearInTeamFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CGF();
            loadProjectData();
        }

    }
}
