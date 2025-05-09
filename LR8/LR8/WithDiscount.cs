namespace LR8;

public class WithDiscount : ICostStrategy
{
    private double _discount;

    public WithDiscount(double discount)
    {
        if(discount<0)
            throw new ArgumentException("Скидка не может быть отрицательной");
        _discount = discount;
    }

    public double GetCost(double baseCost)=> Math.Max(0, baseCost - _discount);
}