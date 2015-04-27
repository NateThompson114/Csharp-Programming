using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ServiceProcess;
using System.Configuration.Install;
using System.ComponentModel;

namespace Csharp_WindowsService
{
    // ReSharper disable once InconsistentNaming
    class WEGwinService :  ServiceBase
    {
        public WEGwinService()
        {
            ServiceName = "WEG Windows Service Ver 1.0";
            EventLog.Log = "Application";
            CanPauseAndContinue = true;
            CanStop = true;
        }
        static void Main(string[] args)
        {
            ServiceBase.Run(new WEGwinService());
        }

        protected override void OnStart(string[] args)
        {
            var oSsts = new DateTime();
            var oSMessage = "The service has started: " + oSsts;
            EventLog.WriteEntry(ServiceName,oSMessage,EventLogEntryType.Information);
        }
        protected override void OnStop()
        {
            var oSsts = new DateTime();
            var oSMessage = "The service has stopped: " + oSsts;
            EventLog.WriteEntry(ServiceName, oSMessage, EventLogEntryType.Information);
        }
        protected override void OnPause()
        {
            var oSsts = new DateTime();
            var oSMessage = "The service has paused: " + oSsts;
            EventLog.WriteEntry(ServiceName, oSMessage, EventLogEntryType.Information);
        }
        protected override void OnContinue()
        {
            var oSsts = new DateTime();
            var oSMessage = "The service has resumed: " + oSsts;
            EventLog.WriteEntry(ServiceName, oSMessage, EventLogEntryType.Information);
        }
    }
}
