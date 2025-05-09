namespace LR6;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nСобачка");
        Animal dog = new Dog("Рекс", 3, "Овчарка");
        dog.Eat(); 
        dog.Speak(); 
        dog.Move();
        //dog.Ball();

        Cat c1 = (Cat)dog;

        Console.WriteLine("\nПтичка");
        Bird bird = new Bird("Чирик", 1, 0.25);
        bird.Eat();
        bird.Speak(); 
        bird.Move(); 
        bird.Fly(); 

        Console.WriteLine("\nКот");
        Cat cat = new Cat("Вискас", 2);
        cat.Eat(); 
        ((Animal)cat).Eat();
        cat.Speak();
        cat.Move();
        cat.Scratch();
    }
}