namespace LR9;

internal class CashPayment : IPayment
{
    public void Pay(decimal amount) =>
        Console.WriteLine($"Оплата наличными: сумма {amount} руб.");
}