using System;
using TimeOptimization.Model.Models;

namespace TimeOptimizationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppCoreModel model = new AppCoreModel();
            model.GetProcesses();
        }
    }
}
