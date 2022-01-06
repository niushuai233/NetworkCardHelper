using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCardHelper
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            if (CheckAdministrator())
            {
                // 是管理员权限
                System.Windows.Forms.Application.Run(new Application());
            }
            else
            {
                MessageBox.Show("Not Administrator");
            }
            
        }

        static bool CheckAdministrator()
        {
            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();

            System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);


            return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
    }
}
