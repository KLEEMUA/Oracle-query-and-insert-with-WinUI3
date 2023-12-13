using Microsoft.UI.Xaml.Controls;

using 应用1.ViewModels;

namespace 应用1.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        var sql = new SQL();
        sql.Insert(new string[]{StudentId.Text,FirstName.Text,LastName.Text,Email.Text,PhoneNo.Text,CGA.Text,DepartmentId.Text,AdmissionYear.Text});
    }
}
