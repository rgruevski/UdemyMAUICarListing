using CommunityToolkit.Mvvm.ComponentModel;
namespace UdemyMAUICarListing.ViewModels;
public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    string _title;

    [ObservableProperty]
    bool _isBusy;
}
