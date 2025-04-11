using System.Xml;

namespace Task_2.Services;

public class NewFunction
{
    public void FunctionY(double z, double b)
    {
        int branch = z >= 1 ? 2 : 1;
        double x = (z < 1) ? z/b : Math.Sqrt(Math.Pow(z*b,3));

        double y = -Math.PI + Math.Pow(Math.Cos(Math.Pow(x, 3)), 2)+Math.Pow(Math.Sin(Math.Pow(x,2)),3);
        
        Console.WriteLine($"Результат вычислений y = {y},ветка {branch}.");
    }
}