namespace LR6;

 class Bird : Animal
{
 private double WingSpan;
 public Bird(string name, int age, double wingSpan)
  : base(name, age)
 {
  WingSpan = wingSpan;
  Console.WriteLine($" Размах крыльев: {WingSpan} м.");
 }

 public override void Speak()
 {
  Console.WriteLine($"{Name} чирикает: Чир-чир!");
 }
 
 public void Fly()
 {
  Console.WriteLine($"{Name} летит ввысь.");
 }
 
    
}