using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOptimization.Model.Models
{
    public class AppCoreModel
    {
        public void GetProcesses()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    Console.WriteLine($"Nazwa: {process.ProcessName}, ID: {process.Id}");
                }
                catch( Exception ex )
                {
                    Console.WriteLine($"Nie można uzyskać informacji o procesie: {ex.Message}");
                }
            }
        }
    }
}
