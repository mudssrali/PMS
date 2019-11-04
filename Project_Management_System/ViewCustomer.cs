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

    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
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
        string[] str = new string[15];
        int index = 0;

        private void loadCustomerData()
        {
            adap.SelectCommand = new SqlCommand("SELECT CUSTOMERID AS CUSTOMER_ID, CUSTOMERFNAME AS FIRSTNAME,CUSTOMERLNAME AS LASTTNAME,CNIC AS IDENTITY_CARD_NO, CONTACT, GENDER, EMAIL, CITY, LOCATION AS COUNTRY FROM Customer", con);
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
         * Sleep Thread  
        */
        void SaveLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
            }
        }
        private void ViewCustomer_Load(object sender, EventArgs e)
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
            
            loadCustomerData();
        }

        private void ViewCustomer_FormClosed(object sender, FormClosedEventArgs e)
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
         * Previous record button 
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
            printer.Title = "Customer Details"; // Header
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
         *  Updating record
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
                    SqlCommand getData = new SqlCommand("SELECT *FROM CUSTOMER WHERE CUSTOMERID='" + Id + "'", con);
                    SqlDataReader dataReader;
                    con.Open();
                    dataReader = getData.ExecuteReader();

                    int i = 0;
                    dataReader.Read();
                    while (i < 9)
                    {
                        if (i == 0)
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
                    tbFirstName.Text = str[1];
                    tbLastName.Text = str[2];
                    tbCNIC.Text = str[3];
                    tbContact.Text = str[4];
                    cbGender.Text = str[5];
                    tbEmail.Text = str[6];
                    cbCity.Text = str[7];
                    cbLoc.Text = str[8];
                    lbCustomer.Text = "";
                    lbCustomer.Text = "CUSTOMER RECORD UPDATION";
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
         * Delete record method 
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
                        adap.DeleteCommand = new SqlCommand("Delete From Customer WHERE Convert(Varchar,CustomerID)='" + Id + "'", con);
                        con.Open();
                        adap.DeleteCommand.ExecuteNonQuery();
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
                            loadCustomerData();
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

        private void btnBackToMGRPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                this.Close();
            }
        }

        private void tbSearchRecords_TextChanged(object sender, EventArgs e)
        {
            adap.SelectCommand = new SqlCommand("SELECT CUSTOMERID AS CUSTOMER_ID, CUSTOMERFNAME AS FIRSTNAME,CUSTOMERLNAME AS LASTTNAME,CNIC AS IDENTITY_CARD_NO, CONTACT, GENDER, EMAIL, CITY, LOCATION AS COUNTRY From CUSTOMER Where Convert(varchar,CustomerID)='" + tbSearchRecords.Text + "' OR CustomerFNAME LIKE'%" + tbSearchRecords.Text + "%' OR CustomerLNAME LIKE'%" + tbSearchRecords.Text + "%' OR CNIC LIKE'%" + tbSearchRecords.Text + "%' OR CONTACT LIKE'%" + tbSearchRecords.Text + "%' OR LOCATION LIKE'%" + tbSearchRecords.Text + "%' OR CITY LIKE'%" + tbSearchRecords.Text + "%' OR EMAIL LIKE'%" + tbSearchRecords.Text + "%'OR Gender LIKE'%" + tbSearchRecords.Text + "%'", con);
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


        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {

                adap.UpdateCommand = new SqlCommand("Update CUSTOMER SET CUSTOMERFNAME = @CUSTOMERFNAME,CUSTOMERLNAME = @CUSTOMERLNAME,CNIC = @CNIC, CONTACT = @CONTACT, GENDER = @GENDER, EMAIL = @EMAIL, CITY = @CITY, LOCATION = @LOCATION WHERE Convert(Varchar,CUSTOMERID)='" + str[0] + "'", con);


                adap.UpdateCommand.Parameters.AddWithValue("@CUSTOMERFNAME", tbFirstName.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@CUSTOMERLNAME", tbLastName.Text);

                adap.UpdateCommand.Parameters.AddWithValue("@Gender", cbGender.Text);

                adap.UpdateCommand.Parameters.AddWithValue("@CNIC", tbCNIC.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@Contact", tbContact.Text);

                adap.UpdateCommand.Parameters.AddWithValue("@Email", (tbEmail.Text));
                adap.UpdateCommand.Parameters.AddWithValue("@City", cbCity.Text);
                adap.UpdateCommand.Parameters.AddWithValue("@lOCATION", cbLoc.Text);


                con.Open();
                adap.UpdateCommand.ExecuteNonQuery();
                con.Close();
                using (var waitForm = new UpdatingWait(Save))
                {
                    waitForm.ShowDialog(this);
                }
                if (MetroFramework.MetroMessageBox.Show(this, "Record has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    lbCustomer.Text = "";
                    lbCustomer.Text = "CUSTOMER INFORMATION";
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
                    loadCustomerData();
                    rowCount();
                    Util.Animate(_PanelView, Util.Effect.Slide, 200, 360);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbCustomer.Text = "";
                lbCustomer.Text = "CUSTOMER INFORMATION";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            lbCustomer.Text = "";
            lbCustomer.Text = "CUSTOMER INFORMATION";
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
         * To avoid pressing enter key
        */
        private void tbSearchRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void recordFilter(string fil)
        {
            adap.SelectCommand = new SqlCommand("SELECT CUSTOMERID AS CUSTOMER_ID, CUSTOMERFNAME AS FIRSTNAME,CUSTOMERLNAME AS LASTTNAME,CNIC AS IDENTITY_CARD_NO, CONTACT, GENDER, EMAIL, CITY, LOCATION AS COUNTRY FROM Customer where location = '" + fil + "'", con);
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
                lbCount.Text = "Record 0 of 0";
                lbTotalRecords.Text = " |  Total Records: 0";
            }
        }
        private void selectCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recordFilter(selectCountryToolStripMenuItem.Text);
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
        }

        private void selectCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recordFilter(selectCityToolStripMenuItem.Text);
            lbFilterState.Text = "ON";
            lbFilterState.ForeColor = Color.Red;
        }

        private void clearFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbFilterState.Text = "OFF";
            lbFilterState.ForeColor = Color.White;
            loadCustomerData();
        }

        private void msFilter_Enter(object sender, EventArgs e)
        {
            this.msFilter.Cursor = Cursors.Hand;
        }
        
    }
}
