using System.Diagnostics;

namespace GCTest;

public partial class RectanglePage : ContentPage
{
    public RectanglePage()
    {
        Debug.WriteLine("RectanglePage");
        InitializeComponent();
    }

    ~RectanglePage() => Debug.WriteLine("~RectanglePage");
}