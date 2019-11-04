using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_Management_System
{
    class Util
    {
        public enum Effect { Roll, Slide, Centre, Bend }
        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flag = effmap[(int)effect];
            if (ctl.Visible)
            {
                flag |= 0x10000;
                angle += 180;
            }
            else
            {
                if (ctl.TopLevelControl == ctl)
                    flag |= 0x20000;
                else if (effect == Effect.Bend)
                    throw new ArgumentException();

            }
            flag |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flag);
            if (!ok)
                throw new Exception("Animation Failed");
            ctl.Visible = !ctl.Visible;
        }
        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };
        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flag);

    }
}
