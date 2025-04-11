using Task_2.Services; 
namespace Task_2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение z : ");
        double z = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение b : ");
        double b = Convert.ToDouble(Console.ReadLine());

        NewFunction funY = new NewFunction();
        
        funY.FunctionY(z,b);
    }
}