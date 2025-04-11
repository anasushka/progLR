namespace Task_1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число(двухзначное) : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число(недвухзначное): ");
        int b = Convert.ToInt32(Console.ReadLine());

        NumberTransformer transformer = new NumberTransformer();

        int transformedA = transformer.swapDigits(a);
        int transformedB = transformer.swapDigits(b);
        
        Console.WriteLine($"Число {a} стало {transformedA}, число {b} стало {transformedB}");

    }
}