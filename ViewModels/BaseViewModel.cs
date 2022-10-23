using CommunityToolkit.Mvvm.ComponentModel;
namespace UdemyMAUICarListing.ViewModels;
public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    string title;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(NotLoading))]
    bool loading;

    public bool NotLoading => !loading;
}
