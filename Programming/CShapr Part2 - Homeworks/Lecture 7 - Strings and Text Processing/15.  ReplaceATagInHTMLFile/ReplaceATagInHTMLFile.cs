using System;

class ReplaceATagInHTMLFile
{
    static void Main()
    {
        Console.Write("Enter HTML string: ");
        string htmlString = Console.ReadLine();
        htmlString = htmlString.Replace("</a>", "[/URL]");
        htmlString = htmlString.Replace("<a", "[URL");
        htmlString = htmlString.Replace("\">", "\"]");
        Console.WriteLine("Formated HTML string is: {0}", htmlString);
    }
}

