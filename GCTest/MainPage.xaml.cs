using Microsoft.Maui.Controls.Shapes;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Path = Microsoft.Maui.Controls.Shapes.Path;

namespace GCTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Debug.WriteLine("MainPage");
            InitializeComponent();

            InitActions();
            BindableLayout.SetItemsSource(buttons, Actions);

            InitActionsMoreComplex();
            BindableLayout.SetItemsSource(buttonsMoreComplex, ActionsMoreComplex);
        }

        ~MainPage() => Debug.WriteLine("~MainPage");

        public ObservableCollection<ButtonAction> Actions { get; private set; }
        public ObservableCollection<ButtonAction> ActionsMoreComplex { get; private set; }

        private void GCCollect(object sender, EventArgs e)
        {
            GC.Collect();
            Debug.WriteLine("GC.Collect()");
        }

        private void InitActions()
        {
            Actions =
            [
                new()
                {
                    Description = "AbsoluteLayout",
                    Command = new Command(() => OpenContainerPage(() => new AbsoluteLayout()))
                },
                new()
                {
                    Description = "FlexLayout",
                    Command = new Command(() => OpenContainerPage(() => new FlexLayout()))
                },
                new()
                {
                    Description = "Grid",
                    Command = new Command(() => OpenContainerPage(() => new Grid()))
                },
                new()
                {
                    Description = "HorizontalStackLayout",
                    Command = new Command(() => OpenContainerPage(() => new HorizontalStackLayout()))
                },
                new()
                {
                    Description = "StackLayout",
                    Command = new Command(() => OpenContainerPage(() => new StackLayout()))
                },
                new()
                {
                    Description = "VerticalStackLayout",
                    Command = new Command(() => OpenContainerPage(() => new VerticalStackLayout()))
                },
                new()
                {
                    Description = "Border",
                    Command = new Command(() => OpenContainerPage(() => new Border()))
                },
                new()
                {
                    Description = "BoxView",
                    Command = new Command(() => OpenContainerPage(() => new BoxView()))
                },
                new()
                {
                    Description = "Frame",
                    Command = new Command(() => OpenContainerPage(() => new Frame()))
                },
                new()
                {
                    Description = "Image",
                    Command = new Command(() => OpenContainerPage(() => new Image()))
                },
                new()
                {
                    Description = "Label",
                    Command = new Command(() => OpenContainerPage(() => new Label()))
                },
                new()
                {
                    Description = "ScrollView",
                    Command = new Command(() => OpenContainerPage(() => new ScrollView()))
                },
                new()
                {
                    Description = "WebView",
                    Command = new Command(() => OpenContainerPage(() => new WebView()))
                },
                new()
                {
                    Description = "Ellipse",
                    Command = new Command(() => OpenContainerPage(() => new Ellipse()))
                },
                new()
                {
                    Description = "Line",
                    Command = new Command(() => OpenContainerPage(() => new Line()))
                },
                new()
                {
                    Description = "Path",
                    Command = new Command(() => OpenContainerPage(() => new Path()))
                },
                new()
                {
                    Description = "Polygon",
                    Command = new Command(() => OpenContainerPage(() => new Polygon()))
                },
                new()
                {
                    Description = "Polyline",
                    Command = new Command(() => OpenContainerPage(() => new Polyline()))
                },
                new()
                {
                    Description = "Rectangle",
                    Command = new Command(() => OpenContainerPage(() => new Rectangle()))
                },
                new()
                {
                    Description = "Button",
                    Command = new Command(() => OpenContainerPage(() => new Button()))
                },
                new()
                {
                    Description = "ImageButton",
                    Command = new Command(() => OpenContainerPage(() => new ImageButton()))
                },
                new()
                {
                    Description = "RadioButton",
                    Command = new Command(() => OpenContainerPage(() => new RadioButton()))
                },
                new()
                {
                    Description = "RefreshView",
                    Command = new Command(() => OpenContainerPage(() => new RefreshView()))
                },
                new()
                {
                    Description = "SearchBar",
                    Command = new Command(() => OpenContainerPage(() => new SearchBar()))
                },
                new()
                {
                    Description = "SwipeView",
                    Command = new Command(() => OpenContainerPage(() => new SwipeView()))
                },
                new()
                {
                    Description = "CheckBox",
                    Command = new Command(() => OpenContainerPage(() => new CheckBox()))
                },
                new()
                {
                    Description = "DatePicker",
                    Command = new Command(() => OpenContainerPage(() => new DatePicker()))
                },
                new()
                {
                    Description = "Slider",
                    Command = new Command(() => OpenContainerPage(() => new Slider()))
                },
                new()
                {
                    Description = "Stepper",
                    Command = new Command(() => OpenContainerPage(() => new Stepper()))
                },
                new()
                {
                    Description = "Switch",
                    Command = new Command(() => OpenContainerPage(() => new Microsoft.Maui.Controls.Switch()))
                },
                new()
                {
                    Description = "TimePicker",
                    Command = new Command(() => OpenContainerPage(() => new TimePicker()))
                },
                new()
                {
                    Description = "Editor",
                    Command = new Command(() => OpenContainerPage(() => new Editor()))
                },
                new()
                {
                    Description = "Entry",
                    Command = new Command(() => OpenContainerPage(() => new Entry()))
                },
                new()
                {
                    Description = "ActivityIndicator",
                    Command = new Command(() => OpenContainerPage(() => new ActivityIndicator()))
                },
                new()
                {
                    Description = "ProgressBar",
                    Command = new Command(() => OpenContainerPage(() => new ProgressBar()))
                },
                new()
                {
                    Description = "CarouselView",
                    Command = new Command(() => OpenContainerPage(() => new CarouselView()))
                },
                new()
                {
                    Description = "CollectionView",
                    Command = new Command(() => OpenContainerPage(() => new CollectionView()))
                },
                new()
                {
                    Description = "IndicatorView",
                    Command = new Command(() => OpenContainerPage(() => new IndicatorView()))
                },
                new()
                {
                    Description = "ListView",
                    Command = new Command(() => OpenContainerPage(() => new ListView()))
                },
                new()
                {
                    Description = "Picker",
                    Command = new Command(() => OpenContainerPage(() => new Picker()))
                },
                new()
                {
                    Description = "TableView",
                    Command = new Command(() => OpenContainerPage(() => new TableView()))
                },
                new()
                {
                    Description = "ContentView",
                    Command = new Command(() => OpenContainerPage(() => new ContentView()))
                },
            ];
        }

        private void InitActionsMoreComplex()
        {
            ActionsMoreComplex =
            [
                new()
                {
                    Description = "AbsoluteLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new AbsoluteLayout();
                        layout.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new()
                {
                    Description = "Grid",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new Grid();
                        layout.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new()
                {
                    Description = "FlexLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new FlexLayout();
                        layout.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new()
                {
                    Description = "HorizontalStackLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new HorizontalStackLayout();
                        layout.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new()
                {
                    Description = "StackLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new StackLayout();
                        layout.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new()
                {
                    Description = "VerticalStackLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new VerticalStackLayout();
                        layout.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new()
                {
                    Description = "Border",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var border = new Border();
                        border.Content = new Label() { Text = "test" };
                        return border;
                    }))
                },
                new()
                {
                    Description = "Frame",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var frame = new Frame();
                        frame.Content = new Label() { Text = "test" };
                        return frame;
                    }))
                },
                new()
                {
                    Description = "Image",
                    Command = new Command(() => OpenContainerPage(() => new Image() { Source = "dotnet_bot.png" }))
                },
                new()
                {
                    Description = "Label",
                    Command = new Command(() => OpenContainerPage(() => new Label() { Text = "test" }))
                },
                new()
                {
                    Description = "ScrollView",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var view = new ScrollView();
                        view.Content = new Label() { Text = "test" };
                        return view;
                    }))
                },
                new()
                {
                    Description = "WebView",
                    Command = new Command(() => OpenContainerPage(() => new WebView() { Source = "https://google.com" }))
                },
                new()
                {
                    Description = "Ellipse",
                    Command = new Command(() => OpenContainerPage(() => new Ellipse() { Stroke = Brush.Red, HeightRequest = 200, WidthRequest = 200 }))
                },
                new()
                {
                    Description = "Line",
                    Command = new Command(() => OpenContainerPage(() => new Line(0, 0, 200, 200) { Stroke = Brush.Red, }))
                },
                new()
                {
                    Description = "Polygon",
                    Command = new Command(() => OpenContainerPage(() => new Polygon(new PointCollection([
                        new Point(0, 0),
                        new Point(50, 100),
                        new Point(200, 200)]))
                    { Stroke = Brush.Red, }))
                },
                new()
                {
                    Description = "Polyline",
                    Command = new Command(() => OpenContainerPage(() => new Polyline(new PointCollection([
                        new Point(0, 0),
                        new Point(50, 100),
                        new Point(200, 200)]))
                    { Stroke = Brush.Red, }))
                },
                new()
                {
                    Description = "Rectangle",
                    Command = new Command(() => OpenContainerPage(() => new Rectangle() { Stroke = Brush.Red, WidthRequest = 200, HeightRequest = 200 }))
                },
                new()
                {
                    Description = "Button",
                    Command = new Command(() => OpenContainerPage(() => new Button() { Text = "test" }))
                },
                new()
                {
                    Description = "ImageButton",
                    Command = new Command(() => OpenContainerPage(() => new ImageButton() { Source = "dotnet_bot.png" }))
                },
                new()
                {
                    Description = "RefreshView",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var view = new RefreshView();
                        view.Content = new Label() { Text = "test" };
                        return view;
                    }))
                },
                new()
                {
                    Description = "CarouselView",
                    Command = new Command(() => OpenContainerPage(() => new CarouselView()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new()
                {
                    Description = "CollectionView",
                    Command = new Command(() => OpenContainerPage(() => new CollectionView()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new()
                {
                    Description = "IndicatorView",
                    Command = new Command(() => OpenContainerPage(() => new IndicatorView()))
                },
                new()
                {
                    Description = "ListView",
                    Command = new Command(() => OpenContainerPage(() => new ListView()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new()
                {
                    Description = "Picker",
                    Command = new Command(() => OpenContainerPage(() => new Picker()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new()
                {
                    Description = "ContentView",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var view = new ContentView();
                        view.Content = new Label() { Text = "test" };
                        return view;
                    }))
                },
            ];
        }

        private void OpenContainerPage(Func<View> action)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ContainerPage(action()));
        }

        public class ButtonAction
        {
            public ICommand Command { get; set; }
            public string Description { get; set; }
        }
    }
}