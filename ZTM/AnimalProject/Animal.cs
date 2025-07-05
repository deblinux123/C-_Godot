public class Animal
{
    private String name;
    private int age;

    public String Name
    {
        get { return name; }
        set
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Invalid name.");
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine($"Animal: {name}, Age: {age}");
            }
        }
    }

    public virtual void makeSound()
    {
        Console.WriteLine("Animal make sound.");
    }

}