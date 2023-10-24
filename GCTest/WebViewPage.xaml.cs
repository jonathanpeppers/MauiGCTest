using System.Diagnostics;

namespace GCTest;

public partial class WebViewPage : ContentPage
{
    public WebViewPage()
    {
        Debug.WriteLine("WebViewPage");
        InitializeComponent();
    }

    ~WebViewPage() => Debug.WriteLine("~WebViewPage");
}