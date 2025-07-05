enum Day
{
    Suterday,
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}

class Program
{
    static void Main(string[] args)
    {
        Day today = Day.Monday;
        Console.WriteLine($"Today is: {today}");

        int dayNumer = (int)today;
        Console.WriteLine($"Day Number: {dayNumer}");


        MathConst.ShowCircleArea(10);

        Point point = new Point(3, 4);
        point.Show();
    }
}