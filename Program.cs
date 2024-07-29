using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ToolsApp;
using NSClient;

namespace AutoSendCapNhapDH
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [Obsolete]
        static void Main()
        {       

            #region Debug
            SendMailService myService = new SendMailService();
            myService.OnDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
            #endregion

            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new SendMailService()
            //};
            //ServiceBase.Run(ServicesToRun);
        }
    }
}
