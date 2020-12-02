using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Controls;
using WpfWithPrism.Views;

namespace WpfWithPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "WPF with Prism";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            
        }
    }
}