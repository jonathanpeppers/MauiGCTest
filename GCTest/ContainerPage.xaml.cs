using System.Diagnostics;

namespace GCTest;

public partial class ContainerPage : ContentPage
{
    public ContainerPage(View view)
    {
        InitializeComponent();
        Content = view;
        Title = view.GetType().Name;
        Debug.WriteLine($"{Title} Page");
    }

    ~ContainerPage() => Debug.WriteLine($"~{Title} Page");
}