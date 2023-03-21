using AvnObservable;
using System.Windows;
namespace WPFDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ObservableCollectionWithSelection<Person> People { get; set; }
        = new ObservableCollectionWithSelection<Person>();

    public MainWindow()
    {
        InitializeComponent();
        
        People.Add(new Person { Id = 1, Name = "Isadora Jarr", Email = "isadora@jarr.com" });
        People.Add(new Person { Id = 2, Name = "Ben Chillin", Email = "ben@chillin.com" });
        People.Add(new Person { Id = 3, Name = "Hugh Jarms", Email = "hugh@jarms.com" });

        DataContext = this;
    }

}
