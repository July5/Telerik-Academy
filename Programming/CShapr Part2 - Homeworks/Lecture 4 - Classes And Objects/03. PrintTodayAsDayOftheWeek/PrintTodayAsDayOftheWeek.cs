using System;
using System.Globalization;

class PrintTodayAsDayOftheWeek
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
        DateTime today = DateTime.Today;
        Console.WriteLine("Today is: {0}", today.DayOfWeek);
        Console.WriteLine(today.ToShortDateString());
    }
}

