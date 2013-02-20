using System;
using System.Globalization;

class NumberOfWorkDay
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
        DateTime today = DateTime.Today.Date;
        Console.Write("Enter future date in format [DD/MM/YYYY]: ");
        DateTime futureDate = DateTime.Parse(Console.ReadLine());
        string[] notWorkingDays = new string[] {"03/03/2013", "31/07/2013", "01/05/2013"};
        Console.WriteLine("There are {0} working days to given future date!", HowManyWorkingDays(today, futureDate, notWorkingDays));
    }

    static int HowManyWorkingDays(DateTime today, DateTime futureDate, string[] notWorkingDays)
    {
        int count = 0;
        bool checkDay = true;
        while (today != futureDate)
        {
            for (int i = 0; i < notWorkingDays.Length; i++)
            {
                if (today.ToShortDateString() == notWorkingDays[i])
                {
                    checkDay = false;
                }
            }
            if ((today.DayOfWeek.ToString() == "Saturday") || (today.DayOfWeek.ToString() == "Sunday"))
            {
                checkDay = false;
            }
            today = today.AddDays(1);
            if (checkDay)
            {
                count++;
            }
            checkDay = true;
        }
        return count;
    }
}

