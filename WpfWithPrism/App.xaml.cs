using DataManager;
using DataModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;
using WpfWithPrism.Modules;
using WpfWithPrism.Services;
using WpfWithPrism.Views;

namespace WpfWithPrism
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton(typeof(INavigationService), typeof(NavigationService));

            containerRegistry.RegisterSingleton(typeof(IUserDAO), typeof(UserDAO));
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ViewsModule>();
        }
    }
}