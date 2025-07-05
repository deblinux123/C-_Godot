using System;

class Program
{
    static void Main(String[] args)
    {
        Car myCar = new Car("Toyota", "Crolla", 2020);
        myCar.showInfo();
        Console.WriteLine(myCar.Brand);
        
    }
}