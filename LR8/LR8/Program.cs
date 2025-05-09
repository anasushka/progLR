namespace LR8
{
    class Program
    {
        static void Main()
        {
            var op = new Operator();
            var basic = new Tariff(5);

            op.AddClient("Иван", basic, new NoDiscount());
            op.AddClient("Мария", basic, new WithDiscount(100));

            op.RecordUsage("Иван", 50);
            op.RecordUsage("Мария", 50);

            Console.WriteLine($"Общий доход: {op.CalculateRevenue()} руб.");
        }
    }
}