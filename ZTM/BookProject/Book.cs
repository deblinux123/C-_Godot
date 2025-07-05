using System.Reflection.Metadata.Ecma335;

public class Book
{
    private String title;
    private String author;
    private double price;

    public Book(String title, String author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public String Title
    {
        get { return title; }
        set { title = value; }
    }

    public String Author
    {
        get { return author; }
        set { author = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
            {
                price = value;
            }
            else
            {
                Console.WriteLine("Invlaid price.");
            }
        }
    }

    public void showInfo()
    {
        Console.WriteLine("Book Information.");
        Console.WriteLine($"Author: {author}\nBook Title: {title}\nPrice: {price}");
    }
}