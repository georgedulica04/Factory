using Factory.ConcreteProducts;
using Factory.Interfaces;

namespace Factory.ConcreteCreators;

//Concrete Creator Dog
public class CreateDogs : IAnimalsFactory
{
    public IAnimal CreateAnimal()
    {
        return new Dog();
    }
}