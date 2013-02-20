using System;
using System.Globalization;

class PrintsDateAndTimeAfter6AndHalfHoursInBulgarian
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.Write("Enter date and time in format day.month.year hour:minute:second: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("The given date and time after 6:30 hours, will be: {0} {1}", firstDate.AddHours(6).AddMinutes(30), firstDate.ToString("dddd", new CultureInfo("bg-BG")));
    }
}

