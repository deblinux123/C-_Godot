// See https://aka.ms/new-console-template for more information
using System.Globalization;

String name = "Hello";

Console.WriteLine(name.Length);

String path = @"C:\terms";

Console.WriteLine(path);

String text = "The five character is farid";

Console.WriteLine(text.Substring(0, 9));

Console.WriteLine(name.StartsWith("H"));
Console.WriteLine(name.ToUpper());

String upperText = "HELLO THIS IS THE LOWERCASE TEXT";

Console.WriteLine(upperText.ToLower());


DateTime dateOfBirth = new DateTime(1997, 3, 12);

Console.WriteLine(dateOfBirth.DayOfWeek);

String strNum = "12";

int number = int.Parse(strNum);

Console.WriteLine(number);

DateTime localDate = DateTime.Parse("12.09.1990");
DateTime usDate = DateTime.Parse("09/21/1990", new CultureInfo("en-US"));

Console.WriteLine($"The local Date: {localDate} usDate: {usDate}");

Console.WriteLine("Please enter the number: ");

String userInput = Console.ReadLine();

int userNumber = int.Parse(userInput);

// if (userNumber % 2 == 0)
// {
//     Console.WriteLine($"{userNumber} is even");
// }
// else
// {
//     Console.WriteLine($"{userNumber} is odd");
// }

String result = userNumber % 2 == 0 ? "Even" : "Odd";
Console.WriteLine($"{userNumber} is {result}");


Console.WriteLine("Now Please enter your age: ");
String? ageInput = Console.ReadLine();

int userAge = int.Parse(ageInput);

switch (userAge)
{
    case < 18:
        Console.WriteLine("You are childe.");
        break;
    case < 30:
        Console.WriteLine("You are young person.");
        break;
    case < 50:
        Console.WriteLine("You are middle age.");
        break;
    case < 80:
        Console.WriteLine("You are old");
        break;
    default:
        Console.WriteLine("you are a wise person.");
        break;
}

Console.WriteLine("Enter the number you want to print the text just number: ");
String? numberOfTime = Console.ReadLine();

int amounTime = int.Parse(numberOfTime);

Console.WriteLine("Enter your text: ");
String? userText = Console.ReadLine();

int count = amounTime;

while (count > 0)
{
    Console.WriteLine($"{count} {userText}");
    count--;
}
