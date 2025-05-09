namespace LR7;

class Program
{
    static void Main()
    {
        
            var c1 = new Circle(2.5);
            var c2 = new Circle(1.0, 1.0, 3.0);

            Console.WriteLine(c1);
            Console.WriteLine($"Периметр={c1.GetPerimeter():F2}, Площадь={c1.GetArea():F2}");
            Console.WriteLine(c2);
            Console.WriteLine($"Периметр={c2.GetPerimeter():F2}, Площадь={c2.GetArea():F2}");
            Console.WriteLine();

     
            Console.WriteLine($"Второй круг: центр x={c2[0]}, y={c2[1]}, радиус={c2[2]}");
            c2[0] = -1; c2[1] = -1; c2[2] = 5;
            Console.WriteLine("После изменения через индексатор. " + c2);
            Console.WriteLine();

         
            var sum    = c1 + 1.5;
            var diff   = c2 - 2.0;
            var scaled = c1 * 2;
            var div    = c2 / 2;

            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(scaled);
            Console.WriteLine(div);
            Console.WriteLine();

         
            Console.WriteLine("++c1 = " + (++c1));
            Console.WriteLine("--c2 = " + (--c2));
            Console.WriteLine();

      
            var c3 = new Circle(0, 0, Math.Sqrt(2.5 * 2.5 / Math.PI)); // площадью = c1
            Console.WriteLine($"c1 == c3? {c1 == c3}");
            Console.WriteLine($"c2 > c1? {c2 > c1}");
            Console.WriteLine($"c2 < c1? {c2 < c1}");
            Console.WriteLine();

    
            if (c1)
                Console.WriteLine("Первая окружность не в начале координат");
            if (!new Circle(0, 0, 1))
                Console.WriteLine("Первая окружность в начале координат");
            Console.WriteLine();

      
            Circle c4 = 4.2; 
            double r   = (double)c4;  
            Console.WriteLine($"c4 = {c4}, r = {r}");
    }
}

