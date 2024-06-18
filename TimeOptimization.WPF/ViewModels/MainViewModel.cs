using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeOptimization.Model.Models;

namespace TimeOptimization.WPF.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<ProcessInfo> Processes
        {
            get => _processes;
            set
            {
                if (_processes != value)
                {
                    _processes.Clear();
                    _processes = value;
                }
            }
        }
        private ObservableCollection<ProcessInfo> _processes;
        public MainViewModel()
        {
            AppCoreModel appCoreModel = new AppCoreModel();
            _processes = new ObservableCollection<ProcessInfo>(appCoreModel.GetProcesses());
        }
    }
}
