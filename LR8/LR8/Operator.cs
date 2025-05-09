namespace LR8;

public class Operator
{
    private readonly List<Client> _clients = new List<Client>();

    public void AddClient(string name, Tariff tariff, ICostStrategy strategy)
    {
        if (_clients.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("Клиент уже существует");
        _clients.Add(new Client(name, tariff, strategy));
    }

    public void RecordUsage(string name, double mb)
    {
        var client = _clients.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (client == null) throw new InvalidOperationException("Клиент не найден");
        client.AddUsage(mb);
    }

    public double CalculateRevenue() => _clients.Sum(c => c.GetTotal());

}