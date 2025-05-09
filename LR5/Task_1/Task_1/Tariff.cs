namespace Task_1;

public enum SubscriptionFee
{
    Low    = 1,
    Medium = 2,
    High   = 3
}
public class Tariff
{
    public SubscriptionFee FeeLevel  { get; set; }
    public double PricePerMb  { get; set; }

    public Tariff(SubscriptionFee feeLevel  , double pricePerMb )
    {
        FeeLevel  = feeLevel;
        PricePerMb  = pricePerMb ;
    }
    
}