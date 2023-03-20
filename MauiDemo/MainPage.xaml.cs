using AvnObservable;

namespace MauiDemo;

public partial class MainPage : ContentPage
{
    public ObservableCollectionWithSelection<Person> People { get; set; }
        = new ObservableCollectionWithSelection<Person>();

    public MainPage()
    {
        InitializeComponent();

        People.Add(new Person { Id = 1, Name = "Isadora Jarr", Email = "isadora@jarr.com" });
        People.Add(new Person { Id = 2, Name = "Ben Chillin", Email = "ben@chillin.com" });
        People.Add(new Person { Id = 3, Name = "Hugh Jarms", Email = "hugh@jarms.com" });

        BindingContext = this;
    }

    private void PersonPropertyChanged(object sender, TextChangedEventArgs e)
    {
        People.UpdateSelectedItemInCollection();
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        People.UpdateSelectedItemInCollection();
    }

}