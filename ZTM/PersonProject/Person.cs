public class Person
{
    public String Name;
    public int Age;

    public Person(String name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Great()
    {
        Console.WriteLine($"Hello my name is {Name} and i {Age} years old");
    }
}