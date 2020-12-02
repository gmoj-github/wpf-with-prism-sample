using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using WpfWithPrism.Views;

namespace WpfWithPrism.Modules
{
    public class ViewsModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>().RequestNavigate("RootRegion", nameof(MainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView>();
            containerRegistry.RegisterForNavigation<RegisterView>();
        }
    }
}
