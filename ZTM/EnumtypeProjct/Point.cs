public struct Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Show()
    {
        Console.WriteLine($"Point({x}, {y})");
    }
}