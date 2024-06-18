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
        public List<ProcessInfo> GetProcesses()
        {
            List<ProcessInfo> processes = new List<ProcessInfo>(); 
            var temp = Process.GetProcesses().ToList();

            foreach (Process process in temp)
            {
                try
                {
                    processes.Add(new ProcessInfo
                    {
                        Name = process.ProcessName,
                        Id = process.Id,
                        Filename = process.MainModule.FileName
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Nie można uzyskać informacji o procesie: {ex.Message}");
                }
            }

            return processes;
        }
    }
}
