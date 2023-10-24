using System.Diagnostics;

namespace GCTest;

public partial class CollectionViewPage : ContentPage
{
    public CollectionViewPage()
    {
        Debug.WriteLine("CollectionViewPage");
        InitializeComponent();
    }

    ~CollectionViewPage() => Debug.WriteLine("~CollectionViewPage");
}