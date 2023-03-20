using AvnObservable;
using System.Windows.Forms;

namespace WindowsFormsDemo;

public partial class Form1 : Form
{
    private readonly BindingSource bindingSource = new BindingSource();

    public ObservableCollectionWithSelection<Person> People { get; set; }
        = new ObservableCollectionWithSelection<Person>();

    public Form1()
    {
        InitializeComponent();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem != null)
        {
            People.SelectedItem = listBox1.SelectedItem as Person;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        People.Add(new Person { Id = 1, Name = "Isadora Jarr", Email = "isadora@jarr.com" });
        People.Add(new Person { Id = 2, Name = "Ben Chillin", Email = "ben@chillin.com" });
        People.Add(new Person { Id = 3, Name = "Hugh Jarms", Email = "hugh@jarms.com" });

        bindingSource.DataSource = People;
        listBox1.DataSource = bindingSource;
        listBox1.DisplayMember = "Name";
        listBox1.ValueMember = "Id";

        nameTextBox.DataBindings.Add(new Binding("Text", bindingSource,
            "Name", false, DataSourceUpdateMode.OnPropertyChanged));

        emailTextBox.DataBindings.Add(new Binding("Text", bindingSource,
            "Email", false, DataSourceUpdateMode.OnPropertyChanged));
    }
}