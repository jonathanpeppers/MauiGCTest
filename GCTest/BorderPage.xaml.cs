using System.Diagnostics;

namespace GCTest;

public partial class BorderPage : ContentPage
{
    public BorderPage()
    {
        Debug.WriteLine("BorderPage");
        InitializeComponent();
    }

    ~BorderPage() => Debug.WriteLine("~BorderPage");
}