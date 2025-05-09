namespace Task_1;

public class ProviderSystem
{
    private List<Tariff> _tariffs = new List<Tariff>();
    private List<Client> _clients = new List<Client>();

    public void AddTariff(Tariff tariff)
    {
        _tariffs.Add(tariff);
    }

    public Tariff GetTariffByLevel(SubscriptionFee fee)
    {
        var tariff = _tariffs.FirstOrDefault(t => t.FeeLevel == fee);
        if (tariff == null)
            throw new InvalidOperationException($"Тариф уровня {fee} не найден");
        return tariff;
    }
    
    public void AddClient(string name, SubscriptionFee feeLevel)
    {
        if (_clients.Any(c =>c.Name ==name))
        {
            throw new InvalidOperationException("Клиент с таким именем уже зарегистрирован");
        }
        var tariff = GetTariffByLevel(feeLevel);
        _clients.Add(new Client(name, tariff));
    }

  

    public Client FindClient(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя не может быть пустым", nameof(name));
        var client = _clients.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (client == null)
            throw new InvalidOperationException("Клиент не найден");
        return client;
    }
    
    public void RecordTraffic(string name, double mb)
    {
        Client client = FindClient(name);
        
        client.AddTraffic(mb);
    }

    public double CalculateTotalTraffic()
    {
       return _clients.Sum(c => c.GetTotal());
    }

    public Client GetTopClient()
    {
        if (!_clients.Any())
            throw new InvalidOperationException("Нет зарегистрированных клиентов");

        return _clients.OrderByDescending(c => c.GetTotal()).First();
    }
}