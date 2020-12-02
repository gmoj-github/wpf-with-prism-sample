namespace WpfWithPrism.Services
{
    public interface INavigationService
    {
        bool Navigate(string view);

        bool GoBack();
    }
}
