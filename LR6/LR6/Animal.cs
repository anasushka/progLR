
namespace LR6;

public abstract class Animal
{
    protected string Name;
    protected int Age;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public void Eat()
    {
        Console.WriteLine($"{Name} кушает вкусняшки.");
    }

    public abstract void Speak();

    public virtual void Move()
    {
        Console.WriteLine($"{Name} двигается.");
    }

}