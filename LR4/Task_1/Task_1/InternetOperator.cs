namespace Task_1;

public class InternetOperator
{
    private static InternetOperator? _autoInstance;
    private string _nameOperator;
    private int _subscribers;
    private Tariff _tariff;
    
    private InternetOperator(string name, int subs, double initialTariffCost = 50.0)
    {
        _nameOperator = name;
        _subscribers = subs;
        _tariff = new Tariff(initialTariffCost);
    }
    
    public static InternetOperator GetInstance(string name = "Оператор", int subs = 0, double tariffCost = 50.0)
    {
        if (_autoInstance == null)
        {
            _autoInstance = new InternetOperator(name, subs, tariffCost);
        }
        return _autoInstance;
    }
    
    public string OperatorName { get { return _nameOperator; } }
    public int Subscribers { get { return _subscribers; } set { _subscribers = value; } }
    public double TariffCost { get { return _tariff.Cost; } }
    
    public double GetTotalRevenue()
    {
        return _tariff.Cost * _subscribers;
    }
    
    public void IncreaseTariff(double amount)
    {
        _tariff.IncreaseTariff(amount);
    }
    
    public void IncreaseTariff()
    {
        _tariff.IncreaseTariff();
    }
    
    public void DecreaseTariff(double amount)
    {
        _tariff.DecreaseTariff(amount);
    }
    
    public void DecreaseTariff()
    {
        _tariff.DecreaseTariff();
    }
    
    public void PrintOperatorInfo()
    {
        Console.WriteLine($"Оператор: {_nameOperator}");
        Console.WriteLine($"Число абонентов: {_subscribers}");
        Console.WriteLine($"Текущая стоимость тарифа: {_tariff.Cost}");
        Console.WriteLine($"Общая выручка: {GetTotalRevenue()}");
    }
    
    
}