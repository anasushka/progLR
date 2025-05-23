namespace LR9;

internal class HotelBuilder : AccommodationBuilder
{
    public override AccommodationBase Build()
    {
        var hotel = new Hotel { Name = name, Type = type };
        if (payment != null) hotel.SetPayment(payment);
        return hotel;
    }
}