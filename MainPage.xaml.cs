using System.Collections.ObjectModel;
using UdemyMAUICarListing.Models;
using UdemyMAUICarListing.Services;
using UdemyMAUICarListing.ViewModels;

namespace UdemyMAUICarListing;

public partial class MainPage : ContentPage
{
    private readonly CarListViewModel carListViewModel;
    int count = 0;

    public MainPage(CarListViewModel carListViewModel)
    {
        InitializeComponent();
        BindingContext = carListViewModel;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

