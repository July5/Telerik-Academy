using System;
using System.Text.RegularExpressions;

class ExtractingEmails
{
    static void Main()
    {
        Console.Write("Enter string containing emails: ");
        string stringText = Console.ReadLine();
        Match m = Regex.Match(stringText, @"\w+\.?\w+@\w+\.\w+");
        Console.WriteLine("Emails in the list:");
        while (m.Success)
        {
            Console.WriteLine(m.Value);
            m = m.NextMatch();
        }   
    }
}

