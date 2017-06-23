using Opc.Ua;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongFang.OpcUa.Client
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
            try
            {
                ApplicationConfiguration appConfig = GetApplicationConfiguration();
                Application.Run(new MainForm(appConfig));
            }
            catch (Exception e)
            {
                ExceptionHelper.ShowExceptionDlg("软件初始化", e);
                return;
            }
        }

        public static ApplicationConfiguration GetApplicationConfiguration()
        {
            ApplicationConfiguration config = new ApplicationConfiguration
            {
                ApplicationName = "Data Access Client",
                ApplicationType = ApplicationType.Client,
                 ApplicationUri = 
            };
            return config;
        }
    }
}
