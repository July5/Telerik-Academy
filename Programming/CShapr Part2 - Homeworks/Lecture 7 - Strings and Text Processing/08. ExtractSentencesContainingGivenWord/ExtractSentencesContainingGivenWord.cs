using System;

class ExtractSentencesContainingGivenWord
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        Console.Write("Enter word for searching: ");
        string keyWord = " " + Console.ReadLine() + " ";
        string[] sentances = stringText.Split('.');
        Console.WriteLine("The result is:");
        for (int i = 0; i < sentances.Length; i++)
        {
            if ((sentances[i].IndexOf(keyWord) != -1) || (sentances[i].IndexOf(keyWord.TrimEnd()) != -1))
            {
                Console.WriteLine(sentances[i]);
            }
        }
    }
}

