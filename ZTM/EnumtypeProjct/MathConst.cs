public class MathConst
{
    public const double PI = 3.14159;
    public static void ShowCircleArea(double radius)
    {
        double area = PI * radius * radius;
        Console.WriteLine($"Area is : {area}");
    }
}