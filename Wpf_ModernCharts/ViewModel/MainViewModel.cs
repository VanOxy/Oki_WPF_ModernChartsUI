using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Timers;
using System.Windows;
using Wpf_ModernCharts.Model;

namespace Wpf_ModernCharts.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<string> _populationNames;
        private ObservableCollection<Population> _populations;
        private Timer _timer;
        private string _selectedCountry = "";

        public RelayCommand ButtonCommand { get; private set; }

        public ObservableCollection<Population> Populations
        {
            get
            {
                return _populations;
            }
        }

        public ObservableCollection<string> PopulationNames
        {
            get { return _populationNames; }
            private set { _populationNames = value; }
        }

        public string SelectedCountry
        {
            set
            {
                _selectedCountry = value;
            }
        }

        public MainViewModel()
        {
            _populations = new ObservableCollection<Population>();
            _populationNames = new ObservableCollection<string>();

            _populations.Add(new Population() { Name = "China", Count = 1340 });
            _populations.Add(new Population() { Name = "India", Count = 1220 });
            _populations.Add(new Population() { Name = "United States", Count = 309 });
            _populations.Add(new Population() { Name = "Indonesia", Count = 240 });
            _populations.Add(new Population() { Name = "Brazil", Count = 195 });
            _populations.Add(new Population() { Name = "Pakistan", Count = 174 });
            _populations.Add(new Population() { Name = "Nigeria", Count = 158 });

            _populationNames.Add("China");
            _populationNames.Add("India");
            _populationNames.Add("United States");
            _populationNames.Add("Indonesia");
            _populationNames.Add("Brazil");
            _populationNames.Add("Pakistan");
            _populationNames.Add("Nigeria");

            this.ButtonCommand = new RelayCommand(ActionOnButtonCommand);
        }

        private void ActionOnButtonCommand()
        {
            try
            {
                _populations.Where(itm => itm.Name.Equals(_selectedCountry)).First().Count += 100;
            }
            catch { }
        }
    }
}