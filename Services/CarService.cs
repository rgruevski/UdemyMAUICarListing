using UdemyMAUICarListing.Models;

namespace UdemyMAUICarListing.Services;
public partial class CarService
{
    public static List<Car> GetCars() => new()
    {
        new Car(0,"Honda","Accord","1234567890"),
        new Car(1,"Chevorlet","Corvette","1234567891"),
        new Car(2,"Hyundai","Sonata","1234567892"),
        new Car(3,"Ford","Focus","1234567893"),
        new Car(4,"Nissan","Skyline","1234567894"),
        new Car(5,"Acura","Integra","1234567895"),
        new Car(6, "Mistubishi","Lancer","1234567896"),
        new Car(7, "Toyota","Supra","1234567897")
    };
}