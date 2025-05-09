namespace LR8;

public class Tariff
{
    public double PricePerMb { get; }

    public Tariff(double pricePerMb)
    {
        if (pricePerMb < 0)
            throw new ArgumentException("Цена за МБ не может быть отрицательной");
        PricePerMb = pricePerMb;
    }

    public double BaseCost(double usageMb) => usageMb * PricePerMb;
}