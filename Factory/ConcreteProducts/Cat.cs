using Factory.Interfaces;

namespace Factory.ConcreteProducts;

//Concrete Product Cat
public class Cat : IAnimal
{
    public string Name { get; set; }
    public string Owner { get; set; }

    public void Sound()
    {
        Console.WriteLine("Meeoww");
    }
}