namespace LR9;

public class AgroFarm : AccommodationBase, ITransfer
{
    public override void GetInfo() =>
        Console.WriteLine($"Размещение: {Name}, тип {Type} (агроусадьба)\n");

    public void TransferFromAirport() =>
        Console.WriteLine($"{Name}: договариваюсь о трансфере на тракторах");
}