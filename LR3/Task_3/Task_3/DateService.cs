namespace Task_3;

public class DateService
{
    public void GetDay(string date)
    {
        DateTime dt = DateTime.Parse(date);
        DayOfWeek dayOfWeek = dt.DayOfWeek;
        Console.WriteLine($"{date} -  {dayOfWeek}.");
    }
    public void GetDaysSpan(int day, int month, int year)
    {
        DateTime inputDate = new DateTime(year, month, day);
        DateTime currentDate = DateTime.Now.Date;
        TimeSpan span = inputDate - currentDate;
        Console.WriteLine($"Между течущей датой и {inputDate.ToShortDateString()}  пройдёт {span.Days} дней.");
    }
}
