public class Car : Vhicle
{
    public String? Model { get; set; }

    public void Drive()
    {
        Console.WriteLine("Car is running...");
    }

    public new void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model} and year: {Year}");
    }
}