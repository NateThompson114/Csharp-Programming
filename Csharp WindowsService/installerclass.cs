using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.ComponentModel;
using System.Configuration.Install;

namespace Csharp_WindowsService
{
    [RunInstaller(true)]
    public class installerclass : Installer
    {
        public installerclass()
        {
            var simpleServiceProcessInstaller = new ServiceProcessInstaller();
            var serviceInstaller = new ServiceInstaller();

            simpleServiceProcessInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.DisplayName = "WEG Windows Service Ver 1.0";
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.ServiceName = "winservice";

            Installers.Add(simpleServiceProcessInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}
