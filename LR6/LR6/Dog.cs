namespace LR6;

class Dog: Animal
{
    private string Breed;

    public Dog(string name, int age, string breed)
        : base(name, age)  
    {
        Breed = breed;
        Console.WriteLine($"Порода: {Breed}");
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} говорит: Гав-гав!");
    }
    
    public override void Move()
    {
        Console.WriteLine($"{Name} бежит на четырёх лапах.");
    }
    
    public void Ball()
    {
        Console.WriteLine($"{Name} приносит мячик.");
    }
    
}