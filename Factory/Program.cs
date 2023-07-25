using Factory.ConcreteCreators;
using Factory.Interfaces;

class Program
{
    public static void Main()
    {
        IAnimalsFactory catsFactory = new CreateCat();
        IAnimalsFactory dogsFactory = new CreateDogs();

        IAnimal cat = catsFactory.CreateAnimal();
        IAnimal dog = dogsFactory.CreateAnimal();

        cat.Name = "Tomas";
        cat.Owner = "Gicu";

        Console.WriteLine(cat.Name + " " + cat.Owner);
        cat.Sound();

        dog.Name = "Toto";
        dog.Owner = "Popescu";

        Console.WriteLine(dog.Name + " " + dog.Owner);
        dog.Sound();
    }
}