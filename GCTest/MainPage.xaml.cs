using System.Diagnostics;

namespace GCTest
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            Debug.WriteLine("MainPage");
            InitializeComponent();
        }

        ~MainPage() => Debug.WriteLine("~MainPage");

        private void GCCollect(object sender, EventArgs e)
        {
            GC.Collect();
            Debug.WriteLine("GC.Collect()");
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OpenBindableLayoutPage(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new BindableLayoutPage());
        }

        private void OpenBorderPage(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new BorderPage());
        }

        private void OpenCollectionViewPage(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new CollectionViewPage());
        }

        private void OpenEmptyPage(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new EmptyPage());
        }

        private void OpenRectanglePage(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new RectanglePage());
        }

        private void OpenWebViewPage(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new WebViewPage());
        }
    }
}