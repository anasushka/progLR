namespace LR9;

public class Hotel : AccommodationBase, ITransfer, IMiniBar, IPoolAccess, IInternet
{
    public override void GetInfo() =>
        Console.WriteLine($"Размещение: {Name}, тип {Type} (отель)\n");

    public void TransferFromAirport() =>
        Console.WriteLine($"{Name}: организую трансфер от аэропорта");
    public void UseMiniBar() =>
        Console.WriteLine($"{Name}: пользуюсь минибаром");
    public void UsePool() =>
        Console.WriteLine($"{Name}: посещаю бассейн");
    public void ConnectInternet() =>
        Console.WriteLine($"{Name}: подключаю интернет");
}