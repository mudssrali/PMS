using System;
using System.Windows.Forms;
using Project_Management_System;
using System.Drawing;
using Project_Management_System.Properties;
using System.Threading;
using System.Data.SqlClient;

namespace Project
{
    public partial class Welcome : MetroFramework.Forms.MetroForm
    {

        public Welcome()
        {
            
          //  Thread t = new Thread(new ThreadStart(Splash));
          //   t.Start();            ESTBConection();
            InitializeComponent();
            /*
            string str = string.Empty;
            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(5);
                if (i == 499)
                    t.Abort();
            }
            */
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Datadirectory|\projectDatabase.mdf;Integrated Security=True;Connect Timeout=60");
        private void ESTBConection()
        {
            con.Open();
            ;
            con.Close();
        }
        void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Project Management";
            frm.ShowInTaskbar = true;
            frm.AppNameFont = "Times New Roman";
            frm.AppNameFontIcon = "Times New Roman";
            frm.Icon = Resources.pms2;
            Application.Run(frm);
        }

        /*
        Thread t = new Thread(new ThreadStart(Loading));
        t.Start();
        InitializeComponent();
        for (int i = 0; i <=500 ; i++)
        {
            Thread.Sleep(10);
        }
        t.Abort();*/

        /*
        void Loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }*/

        Bitmap imag1 = Resources._1;
        Bitmap imag2 = Resources._2;
        Bitmap imag3 = Resources._3;
        Bitmap imag4 = Resources._4;
        Bitmap imag5 = Resources._5;
        Bitmap imag6 = Resources._6;
        Bitmap imag7 = Resources._7;
        Bitmap imag8 = Resources._8;
        Bitmap imag9 = Resources._9;
        Bitmap imag10 = Resources._10;
        Bitmap imag11 = Resources._11;
        Bitmap imag12 = Resources._12;
        Bitmap imag13 = Resources._13;
        int i = 1;

        /*
         * Register account interface             
        */
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            /*
             * Creating form owner to control the forms openning & Closing
             */
            //   Register regForm = new Register();
            Register regForm = new Register();
            regForm.Owner = this;
            regForm.Show();
            this.Hide();          // Closing Login form
        }
        /*
         * Login into system 
        */
        private void LoginWindow_Click(object sender, EventArgs e)
        {
            LoginWindows lg = new LoginWindows();
            lg.Owner = this;
            lg.Show();
            this.Hide();
        }
        private void Welcome_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = imag1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 11)
            {
                i = 1;
            }
            if (i == 1)
            {
                pictureBox1.Image = imag1;
                Thread.Sleep(5);
            }
            else if (i == 2)
            {
                pictureBox1.Image = imag2;
                Thread.Sleep(5);
            }
            else if (i == 3)
            {
                pictureBox1.Image = imag3;
                Thread.Sleep(5);
            }
            else if (i == 4)
            {
                pictureBox1.Image = imag4;
                Thread.Sleep(5);
            }
            else if (i == 5)
            {
                pictureBox1.Image = imag5;
                Thread.Sleep(5);
            }
            else if (i == 6)
            {
                pictureBox1.Image = imag6;
                Thread.Sleep(5);
            }
            else if (i == 7)
            {
                pictureBox1.Image = imag7;
                Thread.Sleep(5);
            }
            else if (i == 8)
            {
                pictureBox1.Image = imag8;
                Thread.Sleep(5);
            }
            else if (i == 9)
            {
                pictureBox1.Image = imag9;
                Thread.Sleep(5);
            }
            else if (i == 10)
            {
                pictureBox1.Image = imag10;
                Thread.Sleep(5);
            }
            //else if (i == 11)
            //    pictureBox1.Image = imag11;
            //else if (i == 12)
            //    pictureBox1.Image = imag12;
            //else if (i == 13)
            //    pictureBox1.Image = imag13;

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
    }
}
