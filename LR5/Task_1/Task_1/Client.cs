namespace Task_1;

public class Client
{
   public string Name { get; }
   public Tariff CurrentTariff { get; }
   public double UsageMb { get; set; }

   public Client( string name, Tariff tariff)
   {
      Name = name;
      CurrentTariff = tariff;
      UsageMb = 0;
   }

   public void AddTraffic(double mb)
   {
       if (mb > 0)
       {
           UsageMb = mb;
       }
       else
       {
           Console.WriteLine("Объем трафика не может быть отрицательным");
       }
   }

   public double GetTotal()
   {
       return UsageMb * CurrentTariff.PricePerMb;
   }

}