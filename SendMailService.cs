using AutoSendMailBaoNoSoPhieu;
using FluentScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AutoSendCapNhapDH
{
    public partial class SendMailService : ServiceBase
    {
        public SendMailService()
        {
            InitializeComponent();
        }
        public void OnDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Files service started.");
            JobManager.Initialize(new MyRegistry());
        }
        protected override void OnStop()
        {
            EventLog.WriteEntry("Files service stopped.");
        }
    }
}
