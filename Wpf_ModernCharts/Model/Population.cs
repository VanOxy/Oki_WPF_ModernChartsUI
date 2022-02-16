using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_ModernCharts.Model
{
    public class Population : INotifyPropertyChanged
    {
        private string _name = string.Empty;
        private int _count = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                NotifyPropertyChanged("Count");
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}