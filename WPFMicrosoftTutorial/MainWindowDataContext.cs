using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMicrosoftTutorial
{
    public class MainWindowDataContext:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string? userName {  get; set; }

        private bool _isNameNeeded = true;

        public MainWindowDataContext() 
        {
            userName = "Kipkemei";
        }

        
        public bool IsNameNeeded
        {
            get { return _isNameNeeded; }
            set
            {
                if (value != _isNameNeeded)
                {
                    _isNameNeeded = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(IsNameNeeded)));
                }
            }
        }


    }
}
