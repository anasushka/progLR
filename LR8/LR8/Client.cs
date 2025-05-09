namespace LR8;

public class Client
{
    public string Name { get; }
    private readonly Tariff _tariff;
    private readonly ICostStrategy _strategy;
    private double _usageMb;

    public Client(string name, Tariff tariff, ICostStrategy strategy)
    {
        Name = name;
        _tariff = tariff;
        _strategy = strategy;
        _usageMb = 0;
    }

    public void AddUsage(double mb)
    {
        if (mb < 0) throw new ArgumentException("Объём трафика не может быть отрицательным");
        _usageMb += mb;
    }

    public double GetTotal()
    {
        double raw = _tariff.BaseCost(_usageMb);
        return _strategy.GetCost(raw);
    }
}