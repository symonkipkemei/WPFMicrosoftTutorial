using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Threading;
using System.Threading;

namespace WPFMicrosoftTutorial
{
    public class Clock:INotifyPropertyChanged //declaration
    {
        public string currentTime => DateTime.Now.ToLongTimeString();

        // any class that has simple c# property as the source of databinding must implement the INotifyPropertyChanged interface this interface
        // lets your application notify the WPF framework when a data bound property cahanges
        public event PropertyChangedEventHandler? PropertyChanged;

        // invoking the IpropertyChanged every second
        private DispatcherTimer _timer;

        //constructor
        public Clock() 
        { 
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += (sender, o) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(currentTime)));
            _timer.Start();
        
        }
    }
}
