using Project_Management_System;
using System;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
            //Application.Run(new ViewCustomer());
            //Application.Run(new AddCustomer());
            //Application.Run(new Add_Task());
            //Application.Run(new Add_Project());
            //Application.Run(new AddEmployee());
            //Application.Run(new EmpDashboard("Mentor"));
            //Application.Run(new EmpSettings());
            //Application.Run(new ManagerSettings());
            //Application.Run(new ManagerDashboard("MGR123"));
            //Application.Run(new ViewTask());
            //Application.Run(new ViewEMP());
            //Application.Run(new AddTeam());
            //Application.Run(new ViewProject());
            //Application.Run(new LoginWindows());
            //Application.Run(new ViewTeam());
            //Application.Run(new Register());
        }
    }
}
