using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class GeneralSettings : Form
    {
        public GeneralSettings()
        {
            InitializeComponent();
        }

        /*
         * Closing general setting form 
        */
        private void GeneralSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        /*
         * Showing this owner form 
        */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
