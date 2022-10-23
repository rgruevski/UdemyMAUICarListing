namespace UdemyMAUICarListing.Models;
public class Car
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Vin { get; set; }
    public Car() { }
    public Car(int id, string Make, string Model, string Vin)
    {
        this.Id = id;
        this.Make = Make;
        this.Model = Model;
        this.Vin = Vin;
    }
}
