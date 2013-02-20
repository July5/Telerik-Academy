using System;

class CensorForbidenWordsInString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        Console.Write("Enter forbiden words: ");
        string forbidenWords = Console.ReadLine();
        string[] forbidenList = forbidenWords.Split(',');
        for (int i = 0; i < forbidenList.Length; i++)
        {
            forbidenList[i] = forbidenList[i].Trim();
            stringText = stringText.Replace(forbidenList[i], new string('*', forbidenList[i].Length));
        }
        Console.WriteLine("The censored string is: {0}", stringText);
    }
}

