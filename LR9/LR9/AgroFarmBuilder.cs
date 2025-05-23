namespace LR9;

internal class AgroFarmBuilder : AccommodationBuilder
{
    public override AccommodationBase Build()
    {
        var farm = new AgroFarm { Name = name, Type = type };
        if (payment != null) farm.SetPayment(payment);
        return farm;
    }
}