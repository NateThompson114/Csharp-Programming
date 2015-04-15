using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Programming.Programs
{
    class _12___File_Information
    {
        public void Files()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var files = Directory.GetFiles(desktop);
            Console.WriteLine("Files located in {0}.",desktop);
            foreach (var file in files)
            {
                Console.WriteLine("The file {0}.", Path.GetFileName(file));
            }
        }
    }
}
