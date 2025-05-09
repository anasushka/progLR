using Task_1;

namespace Task_1;

class Program
{
    static void Main()
    {
        var provider = new ProviderSystem();

        while (true)
        {
            Console.WriteLine("\n=== Меню Провайдера Интернета ===");
            Console.WriteLine("1. Ввести тарифы");
            Console.WriteLine("2. Зарегистрировать клиента");
            Console.WriteLine("3. Ввести данные трафика");
            Console.WriteLine("4. Подсчитать общий доход");
            Console.WriteLine("5. Найти топ-клиента");
            Console.WriteLine("6. Завершить программу");
            Console.Write("Выберите пункт: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                continue;
            }

            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите цену за МБ для каждого уровня:");
                    foreach (SubscriptionFee fee in Enum.GetValues(typeof(SubscriptionFee)))
                    {
                        Console.Write($"{fee} : ");
                        var input = Console.ReadLine();
                        if (double.TryParse(input, out double price))
                            provider.AddTariff(new Tariff(fee, price));
                        else
                            Console.WriteLine("Неверная цена. Тариф не добавлен.");
                    }
                    break;
                case 2:
                    Console.Write("Введите имя клиента: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Выберите план 1-Low 2-Medium 3-High : ");
                    if (int.TryParse(Console.ReadLine(), out int lvl) && Enum.IsDefined(typeof(SubscriptionFee), lvl))
                    {
                        provider.AddClient(name, (SubscriptionFee)lvl);
                        Console.WriteLine("Клиент зарегистрирован.");
                    }
                    else
                        Console.WriteLine("Неверный уровень плана.");
                    break;
                case 3:
                    Console.Write("Введите имя клиента: ");
                    var userName = Console.ReadLine();
                    Console.Write("Введите объём трафика (в МБ): ");
                    if (double.TryParse(Console.ReadLine(), out double mb))
                    {
                        provider.RecordTraffic(userName, mb);
                        Console.WriteLine("Трафик учтён.");
                    }
                    else
                        Console.WriteLine("Неверный объём.");
                    break;
                case 4:
                    Console.WriteLine($"Общий доход: {provider.CalculateTotalTraffic()}");
                    break;
                case 5:
                    var top = provider.GetTopClient();
                    Console.WriteLine($"Топ-клиент {top.Name}, заплатил {top.GetTotal()} ");
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Выберите пункт от 1 до 6.");
                    break;
                    
            }
        }
        
    }
}

