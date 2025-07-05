using System;


class Program
{
    static void Main(String[] args)
    {
        Person p1 = new Person("Farid", 34);
        p1.Great();

        Student s1 = new Student("Ali", 13, 15);
        s1.ShowInfo();
        Console.WriteLine($"Name: {s1.Name}");
        s1.Name = "Farid";
        Console.WriteLine($"The new name is {s1.Name}");
    }
}