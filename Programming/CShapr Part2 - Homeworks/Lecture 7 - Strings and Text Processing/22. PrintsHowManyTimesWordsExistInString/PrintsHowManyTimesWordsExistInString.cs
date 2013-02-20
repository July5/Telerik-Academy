using System;
using System.Collections.Generic;

class PrintsHowManyTimesWordsExistInString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        List<string> listWords = new List<string>();
        string[] arrString = stringText.Split(' ', ',', '.', '.', '?', '!', ':', ';', '-');
        listWords.AddRange(arrString);
        int count = 1;
        for (int i = 0; i < listWords.Count; )
        {
            for (int j = i + 1; j < listWords.Count; j++)
            {
                if (listWords[i] == listWords[j])
                {
                    count++;
                    listWords.RemoveRange(j,1);
                    j--;
                }
            }
            Console.WriteLine("Word \"{0}\" -> found {1} times.", listWords[i], count);
            count = 1;
            listWords.Remove(listWords[i]);
            if (listWords.Count == 0)
            {
                break;
            }
        }
    }
}

