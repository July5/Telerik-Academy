using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDateFromString
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        Console.Write("Enter string containing dates with format DD.MM.YYYY: ");
        string stringText = Console.ReadLine();
        Match m = Regex.Match(stringText, @"\d{1,2}\.\d{1,2}\.\d{4}");
        Console.WriteLine("Dates in the list are:");
        while (m.Success)
        {
            Console.WriteLine(m.Value.ToString(CultureInfo.GetCultureInfo("en-CA")));
            m = m.NextMatch();
        }   
    }
}

