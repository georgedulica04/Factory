using Factory.ConcreteProducts;
using Factory.Interfaces;

namespace Factory.ConcreteCreators;

//Concrete Creator Cat
public class CreateCat : IAnimalsFactory
{
    public IAnimal CreateAnimal()
    {
        return new Cat();
    }
}