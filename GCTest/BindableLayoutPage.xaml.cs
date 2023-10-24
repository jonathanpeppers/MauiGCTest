using System.Diagnostics;

namespace GCTest;

public partial class BindableLayoutPage : ContentPage
{
    public BindableLayoutPage()
    {
        Debug.WriteLine("BindableLayoutPage");
        InitializeComponent();
    }

    ~BindableLayoutPage() => Debug.WriteLine("~BindableLayoutPage");
}