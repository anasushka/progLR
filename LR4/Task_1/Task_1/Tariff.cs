namespace Task_1;

public class Tariff
{
   private double _cost;
   
   public Tariff(double initialCost)
   {
      _cost = initialCost;
   }
   
   public double Cost 
   { 
      get { return _cost; } 
      private set { _cost = value; } 
   }
   
   public void IncreaseTariff(double amount)
   {
      Cost += amount;
      Console.WriteLine($"Стоимость тарифа увеличина на {amount}. Новая стоимость : {Cost}.");
   }
   
   public void IncreaseTariff()
   {
      IncreaseTariff(5.0);
   }
   
   public void DecreaseTariff(double amount)
   {
      if (Cost - amount >= 0)
      {
         Cost -= amount;
         Console.WriteLine($"Стоимость тарифа уменьшена на {amount}. Новая стоимость: {Cost}.");
      }
      else
      {
         Cost = 0;
         Console.WriteLine("Стоимость тарифа не может быть отрицательной.");
      }
   }
   
   public void DecreaseTariff()
   {
      DecreaseTariff(5.0);
   }
}