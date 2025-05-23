namespace LR9;

public abstract class AccommodationBase
{
    public string Name { get; set; } = string.Empty;
    public AccommodationType Type { get; set; }

    private IPayment _payment;

    public void SetPayment(IPayment payment) => _payment = payment;

    public void Pay(decimal amount)
    {
        _payment.Pay(amount);
    }

    public abstract void GetInfo();
}