using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note.UIL
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin lo = new frmLogin();
            DialogResult dr = lo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //Application.Run(new Manger());
                Application.Run(new frmMain());

            }
          
        }
    }
}
