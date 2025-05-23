namespace LR9;

internal class HostelBuilder : AccommodationBuilder
{
    public override AccommodationBase Build()
    {
        var hostel = new Hostel { Name = name, Type = type };
        if (payment != null) hostel.SetPayment(payment);
        return hostel;
    }
}