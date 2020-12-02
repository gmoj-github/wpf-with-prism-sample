using Prism.Regions;

namespace WpfWithPrism.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IRegionManager _registerManager;

        public NavigationService(IRegionManager regionManager)
        {
            _registerManager = regionManager;
        }

        public bool Navigate(string view)
        {
            _registerManager.RequestNavigate("RootRegion", view);
            //_registerManager.Regions["RootRegion"].NavigationService.RequestNavigate(view);

            return true;
        }

        public bool GoBack()
        {
            if (!_registerManager.Regions["RootRegion"].NavigationService.Journal.CanGoBack)
                return false;

            _registerManager.Regions["RootRegion"].NavigationService.Journal.GoBack();

            return true;
        }
    }
}