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
    public partial class ViewEMP : Form
    {
        public ViewEMP()
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

        private void loadEmployeeData()
        {
            adap.SelectCommand = new SqlCommand("SELECT EMPID AS EMPNO, EMPFIRSTNAME AS FIRSTNAME, EMPLASTNAME AS LASTNAME,CONTACT,CNIC,EMAIL,JOB,SALARY,HIREDATE, ISNULL(HOUSENO,'')+' '+ISNULL(STREET,'')+' '+ISNULL(AREA,'')+' '+ISNULL(CITY,'')+' '+ISNULL(COUNTRY,'') AS ADDRESS, ADDRESSTYPE AS ADD_TYPE FROM Employee", con);
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
        private void ViewEMP_Load(object sender, EventArgs e)
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
            loadEmployeeData();
        }
        private void ViewEMP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
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
            lbCount.Text = "";
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
            printer.Title = "Employee Details"; // Header
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
        void SaveLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
            }
        }
        /*
         * Updating record 
        */
        string[] str = new string[20];
        private void btnUpdateEMP_Click(object sender, EventArgs e)
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
                    SqlCommand getData = new SqlCommand("SELECT *FROM EMPloyee WHERE EMPID='" + Id + "'", con);
                    SqlDataReader dataReader;
                    con.Open();
                    dataReader = getData.ExecuteReader();

                    int i = 0;
                    dataReader.Read();
                    while (i < 19)
                    {
                        if (i == 0 || i == 10 || i == 11)
                        {
                            str[i] = dataReader.GetValue(i).ToString();
                        }
                        else if (!(i == 3 || i == 5 || i == 12))
                        {
                            str[i] = dataReader.GetString(i);

                        }

                        i++;
                    }
                    con.Close();
                    tbFirstName.Text = str[1];
                    tbLastName.Text = str[2];
                    cbGender.Text = str[4];
                    tbCNIC.Text = str[6];
                    tbContact.Text = str[7];
                    tbEmail.Text = str[8];
                    cbJob.Text = str[9];
                    tbSalary.Text = str[10];
                    tbExperience.Text = str[11];
                    tbHouseNo.Text = str[13];
                    tbStreetNo.Text = str[14];
                    tbArea.Text = str[15];
                    tbCity.Text = str[16];
                    cbCountry.Text = str[17];
                    cbHomeAdd.Text = str[18];
                    lbEMP.Text = "";
                    lbEMP.Text = "EMPLOYEE RECORD UPDATION";
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
         * Method to delete emp
        */
        private void btnDeleteEMP_Click(object sender, EventArgs e)
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
                        adap.DeleteCommand = new SqlCommand("Delete From Employee WHERE Convert(Varchar,EMPID)='" + Id + "'", con);
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
                            loadEmployeeData();
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
        /*
         * Back to mgr panel 
        */
        private void btnBackToMGRPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.Close();
            }
        }
        /*
         * Searching through records 
        */
        private void tbSearchRecords_TextChanged(object sender, EventArgs e)
        {
            adap.SelectCommand = new SqlCommand("SELECT EMPID AS EMPNO, EMPFIRSTNAME AS FIRSTNAME, EMPLASTNAME AS LASTNAME,CONTACT,CNIC,EMAIL,JOB,SALARY,HIREDATE, ISNULL(HOUSENO,'')+' '+ISNULL(STREET,'')+' '+ISNULL(AREA,'')+' '+ISNULL(CITY,'')+' '+ISNULL(COUNTRY,'') AS ADDRESS, AddressType AS ADD_TYPE FROM Employee Where Convert(varchar,EMPID)='" + tbSearchRecords.Text + "' OR EMPFIRSTNAME LIKE'%" + tbSearchRecords.Text + "%' OR EMPLASTNAME LIKE'%" + tbSearchRecords.Text + "%' OR CNIC LIKE'%" + tbSearchRecords.Text + "%' OR CONTACT LIKE'%" + tbSearchRecords.Text + "%' OR JOB LIKE'%" + tbSearchRecords.Text + "%' OR COUNTRY LIKE'%" + tbSearchRecords.Text + "%' OR CITY LIKE'%" + tbSearchRecords.Text + "%' OR ADDRESSTYPE LIKE'%" + tbSearchRecords.Text + "%' OR EMAIL LIKE'%" + tbSearchRecords.Text + "%' OR AREA LIKE'%" + tbSearchRecords.Text + "%'", con);
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*
         * Updating record confirmation 
        */
        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {

                adap.UpdateCommand = new SqlCommand("Update Employee SET EMPFIRSTNAME = @EMPFIRSTNAME,EMPLASTNAME = @EMPLASTNAME,GENDER = @GENDER, CNIC = @CNIC,CONTACT = @CONTACT,EMAIL = @EMAIL, JOB = @JOB, SALARY = @SALARY, EXPERIENCE = @EXPERIENCE, HOUSENO = @HOUSENO, STREET = @STREET, AREA = @AREA, CITY = @CITY, COUNTRY = @COUNTRY, ADDRESSTYPE = @ADDRESSTYPE WHERE Convert(Varchar,EMPID)='" + str[0] + "'", con);

                adap.UpdateCommand.Parameters.AddWithValue("@EMPFirstName", tbFirstName.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@EMPLastName", tbLastName.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Gender", cbGender.Text);

                adap.UpdateCommand.Parameters.AddWithValue("@CNIC", tbCNIC.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Contact", tbContact.Text);

                adap.UpdateCommand.Parameters.AddWithValue("@Email", (tbEmail.Text));
                adap.UpdateCommand.Parameters.AddWithValue("@Job", cbJob.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Salary", Convert.ToInt32(tbSalary.Text));
                adap.UpdateCommand.Parameters.AddWithValue("@Experience", Convert.ToInt32(tbExperience.Text));
                adap.UpdateCommand.Parameters.Add("@HireDate", SqlDbType.Date).Value = tbHireDate.Value.Date;
                adap.UpdateCommand.Parameters.AddWithValue("@HouseNo", tbHouseNo.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Street", tbStreetNo.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Area", tbArea.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@City", tbCity.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Country", cbCountry.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@AddressType", cbHomeAdd.Text);

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
                    lbEMP.Text = "";
                    lbEMP.Text = "EMPLOYEE INFORMATION";
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

                    loadEmployeeData();
                 
                }
            }
        }
        /*
         * Canceling updation 
        */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure  to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _PanelUpdateEMP.Refresh();
                lbEMP.Text = "";
                lbEMP.Text = "EMPLOYEE INFORMATION";
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
         * Back to emp information panel 
        */
        private void btnBack_Click(object sender, EventArgs e)
        {
            lbEMP.Text = "";
            lbEMP.Text = "EMPLOYEE INFORMATION";
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
         * Record counter by row header 
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
         * To avoid enter key in multiline texbox 
        */
        private void tbSearchRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        /*
         * Filter on Employee View
        */
        private void recordFilter(string fil)
        {
            adap.SelectCommand = new SqlCommand("SELECT EMPID AS EMPNO, EMPFIRSTNAME AS FIRSTNAME, EMPLASTNAME AS LASTNAME,CONTACT,CNIC,EMAIL,JOB,SALARY,HIREDATE, ISNULL(HOUSENO,'')+' '+ISNULL(STREET,'')+' '+ISNULL(AREA,'')+' '+ISNULL(CITY,'')+' '+ISNULL(COUNTRY,'') AS ADDRESS, ADDRESSTYPE AS ADD_TYPE FROM Employee where JOB= '" + fil + "'", con);
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
        private void clearFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CGF();
            loadEmployeeData();
        }
        int g1, g2, g3, g4, g5, g6, g7;
        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g1 = g2 = g3 = g4 = g5 = g6 = g7 = 0;
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
                loadEmployeeData();
                CGF();
            }
        }
    }
}
