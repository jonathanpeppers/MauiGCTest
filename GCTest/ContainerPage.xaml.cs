using System.Diagnostics;

namespace GCTest;

public partial class ContainerPage : ContentPage
{
    public ContainerPage(View view)
    {
        InitializeComponent();
        Content = view;
        Title = view.GetType().Name;
        Console.WriteLine($"{Title} Page");
    }

    ~ContainerPage() => Console.WriteLine($"~{Title} Page");
}