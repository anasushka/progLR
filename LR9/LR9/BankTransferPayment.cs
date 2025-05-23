namespace LR9;

internal class BankTransferPayment : IPayment
{
    public void Pay(decimal amount) =>
        Console.WriteLine($"Оплата банковским переводом: сумма {amount} руб.");
}