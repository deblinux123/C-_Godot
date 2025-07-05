class Program
{
    static void Main(String[] args)
    {
        Cat myCat = new Cat();
        myCat.Name = "Jack";
        myCat.Age = 2;
        myCat.makeSound();

        Dog myDog = new Dog();
        myDog.Name = "Rob";
        myDog.Age = 3;
        myDog.makeSound(); 
    }    
}