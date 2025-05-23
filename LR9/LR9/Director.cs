namespace LR9;

internal static class Director
{
    public static AccommodationBase CreateStandardHotel(string name)
    {
        return new HotelBuilder()
            .SetName(name)
            .SetType(AccommodationType.Hotel)
            .SetPayment(new CardPayment())
            .WithTransfer()
            .WithMiniBar()
            .WithPool()
            .WithInternet()
            .Build();
    }

    public static AccommodationBase CreateBudgetHostel(string name)
    {
        return new HostelBuilder()
            .SetName(name)
            .SetType(AccommodationType.Hostel)
            .SetPayment(new CashPayment())
            .WithInternet()
            .Build();
    }

    public static AccommodationBase CreateAgroFarm(string name)
    {
        return new AgroFarmBuilder()
            .SetName(name)
            .SetType(AccommodationType.AgroFarm)
            .SetPayment(new BankTransferPayment())
            .WithTransfer()
            .Build();
    }
}