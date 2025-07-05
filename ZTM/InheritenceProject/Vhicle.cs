public class Vhicle
{
    public String? Brand { get; set; }
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle is Starting...");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}, year: {Year}");
    }
}