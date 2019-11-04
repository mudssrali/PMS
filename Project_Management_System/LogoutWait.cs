using System;
using System.Threading.Tasks;

namespace Project_Management_System
{
    public partial class LogoutWait : MetroFramework.Forms.MetroForm
    {
        public Action Worker { get; set; }

        public LogoutWait(Action worker)
        {

            InitializeComponent();
            if (Worker == worker)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
