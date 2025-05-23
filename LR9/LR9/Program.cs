using System;
using System.Collections.Generic;


namespace LR9 
{
    class Program
    {
        static void Main()
        {
            var accommodations = new List<AccommodationBase>
            {
                Director.CreateStandardHotel("Sunny Resort"),
                Director.CreateBudgetHostel("Backpackers Inn"),
                Director.CreateAgroFarm("Green Fields")
            };

            foreach (var acc in accommodations)
            {
                acc.GetInfo();
                acc.Pay(1000);

                if (acc is ITransfer transfer) transfer.TransferFromAirport();
                if (acc is IMiniBar mini) mini.UseMiniBar();
                if (acc is IPoolAccess pool) pool.UsePool();
                if (acc is IInternet net) net.ConnectInternet();

                Console.WriteLine(new string('-', 40));
            }
        }
    }
}