using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The2000s
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

            frmLogin login = new frmLogin();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                switch (login.roleid)
                {
                    case 1:
                        Application.Run(new frmAdmin(login.userid));
                        break;
                    case 2:
                        Application.Run(new frmNVBH(login.userid));
                        break;
                    case 3:
                        Application.Run(new frmNVKho(login.userid));
                        break;
                }
                
            }
        }
    }
}
