using Factory.Interfaces;

namespace Factory.ConcreteProducts;

//Concrete Product Dog
public class Dog : IAnimal
{
    public string Name { get; set; }

    public string Owner { get; set; }

    public void Sound()
    {
        Console.WriteLine("Wooof");
    }
}