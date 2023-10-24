namespace GCTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitNavigation();
        }

        private void InitNavigation()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}