using System;

class Program
{
    static void Main(String[] args)
    {
        Book book = new Book("The C# Book", "Farid kaki", 100);
        book.showInfo();

        Console.WriteLine("The new author new title and new price.");
        book.Author = "Babak";
        book.Title = "Java or C#";
        book.Price = 120;

        book.showInfo();
    }
    
}