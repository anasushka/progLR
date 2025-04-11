namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            InternetOperator internetOp = InternetOperator.GetInstance("SuperNet", 1200, 50.0);
            internetOp.PrintOperatorInfo();
            
            Console.WriteLine("\nУвеличиваем тариф на 10:");
            internetOp.IncreaseTariff(10.0);
            internetOp.PrintOperatorInfo();

            Console.WriteLine("\nУменьшаем тариф на значение по умолчанию (5):");
            internetOp.DecreaseTariff();
            internetOp.PrintOperatorInfo();
            
        }
    }
}