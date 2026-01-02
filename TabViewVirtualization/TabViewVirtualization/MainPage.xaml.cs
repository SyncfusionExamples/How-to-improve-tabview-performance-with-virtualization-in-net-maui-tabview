using Syncfusion.Maui.TabView;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TabViewVirtualization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ObservableCollection<string> HomeItems { get; } = new();
        public ObservableCollection<string> TaskItems { get; } = new();
        public ObservableCollection<ReportRow> ReportItems { get; } = new();

        public MainPageViewModel()
        {
            HomeItems.Add("Welcome to the Home tab. Here you can find an overview of your application and quick access to essential features.");

            TaskItems.Add("Manage your tasks efficiently. Add new tasks, track progress, and stay organized to meet your goals.");

            ReportItems.Add(new ReportRow { Title = "Sales (Q1)", Value = "₹12.4L" });
            ReportItems.Add(new ReportRow { Title = "Active Users", Value = "3,482" });
            ReportItems.Add(new ReportRow { Title = "Support Tickets", Value = "27 open" });
        }
    }

    public class ReportRow
    {
        public string Title { get; set; } = "";
        public string Value { get; set; } = "";
    }

}
