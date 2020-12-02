using DataManager;
using DataModels;
using Prism.Commands;
using Prism.Regions;
using WpfWithPrism.Services;
using WpfWithPrism.Views;

namespace WpfWithPrism.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        #region Attributes

        private readonly IUserDAO _userDAO;

        public DelegateCommand SaveCommand { get; private set; }
        public DelegateCommand CancelCommand { get; private set; }

        #endregion

        #region Properties

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _login;
        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        #endregion

        public RegisterViewModel(INavigationService navigationService, IUserDAO userDAO) :
            base(navigationService)
        {
            _userDAO = userDAO;

            SaveCommand = new DelegateCommand(SaveAction);
            CancelCommand = new DelegateCommand(CancelAction);
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            Name = Login = Password = string.Empty;
        }

        private void SaveAction()
        {
            _userDAO.Save(new User(_name, _login, _password));

            _navigationService.Navigate(nameof(MainView));
        }

        private void CancelAction()
        {
            _navigationService.GoBack();
        }
    }
}