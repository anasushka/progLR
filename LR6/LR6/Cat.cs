namespace LR6;

sealed class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
        Console.WriteLine($"Котик {name} готов.");
            
    }
    
    public override void Speak()
    { 
        Console.WriteLine($"{Name} говорит: Мяу-мяу!");
    }
    
    public new void Eat()
    {
        Console.WriteLine($"{Name} аккуратно ест молоко.");
    }
    
    public void Scratch()
    {
        Console.WriteLine($"{Name} царапается.");
    }
}