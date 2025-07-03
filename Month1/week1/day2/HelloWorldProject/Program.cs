// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the first Number: ");
        String input1 = Console.ReadLine();

        int num1 = int.Parse(input1);

        Console.WriteLine("Enter the second number: ");

        String input2 = Console.ReadLine();

        int num2 = int.Parse(input2);

        int result = num1 + num2;

        Console.WriteLine($"The result is {result}");
    }
}