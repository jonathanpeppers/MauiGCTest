using System.Diagnostics;

namespace GCTest;

public partial class EmptyPage : ContentPage
{
    public EmptyPage()
    {
        Debug.WriteLine("EmptyPage");
        InitializeComponent();
    }

    ~EmptyPage() => Debug.WriteLine("~EmptyPage");
}