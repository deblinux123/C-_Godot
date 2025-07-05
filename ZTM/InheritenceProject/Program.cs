using System;

class Program
{
    static void Main(String[] args)
    {
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Model = "Crolla";
        myCar.Year = 1990;

        myCar.Start();
        myCar.Drive();
        myCar.ShowInfo();
    }
}