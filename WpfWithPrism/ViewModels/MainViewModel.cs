using DataManager;
using DataModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;
using WpfWithPrism.Services;
using WpfWithPrism.Views;

namespace WpfWithPrism.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IUserDAO _userDAO;

        public ObservableCollection<User> Users { get; set; }

        public DelegateCommand RegisterCommand { get; private set; }

        public MainViewModel(INavigationService navigationService, IUserDAO userDAO) : 
            base(navigationService)
        {
            _userDAO = userDAO;

            RegisterCommand = new DelegateCommand(RegisterAction);
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            Users = new ObservableCollection<User>(_userDAO.ListAll());
            RaisePropertyChanged(nameof(Users));
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        private void RegisterAction()
        {
            _navigationService.Navigate(nameof(RegisterView));
        }
    }
}
