using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using 应用1.Contracts.ViewModels;
using 应用1.Core.Contracts.Services;
using 应用1.Core.Models;

namespace 应用1.ViewModels;

public partial class 查询ViewModel : ObservableRecipient, INavigationAware
{

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();


    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();
        SQL sql= new SQL();
        // TODO: Replace with real data.
        sql.Selectall(Source);
    }

    public void OnNavigatedFrom()
    {
    }
}
