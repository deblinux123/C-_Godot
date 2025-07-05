public class Car : IVehicle
{
    private String brand;
    private String model;
    private int year;

    public Car(String brand, String model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    public String Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public String Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value >= 1990 && value <= 2025)
            {
                year = value;
            }
            else
            {
                Console.WriteLine("Year is not valid.");
            }
        }
    }

    public void showInfo()
    {
        Console.WriteLine($"Car-{brand} | Model-{model} | Year-{year}");
    }
}