using Microsoft.UI.Xaml.Controls;

using 应用1.ViewModels;

namespace 应用1.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class 查询Page : Page
{
    public 查询ViewModel ViewModel
    {
        get;
    }

    public 查询Page()
    {
        ViewModel = App.GetService<查询ViewModel>();
        InitializeComponent();
    }
}
