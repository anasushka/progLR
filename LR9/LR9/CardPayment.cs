namespace LR9;

internal class CardPayment : IPayment
{
    public void Pay(decimal amount) =>
        Console.WriteLine($"Оплата картой: сумма {amount} руб.");
}