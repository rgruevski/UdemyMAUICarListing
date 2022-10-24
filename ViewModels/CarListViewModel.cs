using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using UdemyMAUICarListing.Models;
using UdemyMAUICarListing.Services;

namespace UdemyMAUICarListing.ViewModels;
public partial class CarListViewModel : BaseViewModel
{
    private readonly CarService carService;
    public ObservableCollection<Car> Cars { get; private set; }
    public CarListViewModel(CarService carService, ObservableCollection<Car> cars)
    {
        Title = "Car Listings";
        this.carService = carService;
        Cars = cars;
    }

    [RelayCommand]
    async Task GetCarListAsync()
    {
        if (Loading) return;
        try
        {
            Loading = true;
            if (Cars.Any()) Cars.Clear();
            foreach (var car in Cars) Cars.Add(car);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to get Car List due to {ex.Message}");
            await Shell.Current.DisplayAlert("Error", "Failed to retrieve the list of Cars.", "Ok"); 
        }
        finally
        {
            Loading = false;
        }
    }
}