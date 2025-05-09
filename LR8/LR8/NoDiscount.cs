namespace LR8;

public class NoDiscount : ICostStrategy
{
    public double GetCost(double baseCost) => baseCost;
}