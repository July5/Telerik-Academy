using System;
using System.Globalization;

class DaysBetweenTwoDates
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
        Console.Write("Enter first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        int count = 0;
        while (firstDate != secondDate)
        {
            firstDate = firstDate.AddDays(1);
            count++;
        }
        Console.WriteLine("Distance berween two given days is: {0} days", count);
    }
}

