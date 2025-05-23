namespace LR9;

public class Hostel : AccommodationBase, ITransfer, IInternet
{
    public override void GetInfo() =>
        Console.WriteLine($"Размещение: {Name}, тип {Type} (хостел)\n");

    public void TransferFromAirport() =>
        Console.WriteLine($"{Name}: организую шатл от аэропорта");
    public void ConnectInternet() =>
        Console.WriteLine($"{Name}: подключаю бесплатный Wi-Fi");
}