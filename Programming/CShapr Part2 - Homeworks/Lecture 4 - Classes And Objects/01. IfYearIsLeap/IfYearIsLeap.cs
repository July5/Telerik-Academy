using System;

class IfYearIsLeap
{
    static void Main()
    {
        Console.Write("Enter year to check: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
    }
}

