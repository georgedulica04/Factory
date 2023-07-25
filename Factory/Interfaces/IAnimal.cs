namespace Factory.Interfaces;

//Product interface
public interface IAnimal
{
    public string Name { get; set; }

    public string Owner { get; set; }

    public void Sound();
}