using Prism.Mvvm;
using Prism.Regions;
using WpfWithPrism.Services;

namespace WpfWithPrism.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        protected readonly INavigationService _navigationService;

        public ViewModelBase(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }
    }
}
