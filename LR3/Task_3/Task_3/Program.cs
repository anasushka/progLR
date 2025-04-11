using Task_3;

namespace Task_1;

class Program
{
    static void Main()
    {
       
        DateService dateService = new DateService();
        Console.WriteLine("Введите дату : ");
        string date =Console.ReadLine();

        dateService.GetDay(date);
        
        Console.WriteLine("Введите день : ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер месяца : ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите год : ");
        int year = Convert.ToInt32(Console.ReadLine());

        dateService.GetDaysSpan(day,month,year);
    }
}