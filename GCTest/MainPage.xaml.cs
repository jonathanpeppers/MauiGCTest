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
        }

        ~MainPage() => Debug.WriteLine("~MainPage");

        public ObservableCollection<ButtonAction> Actions { get; private set; }

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