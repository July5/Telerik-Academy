using System;
using System.Collections.Generic;

class PrintWordWithIndexForEveryLetterFormArray
{
    static void Main()
    {
        char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Console.Write("Enter word with capital letters: ");
        char letter;
        List<int> wordIndexes = new List<int>();
        while (true)
        {

            letter = (char)Console.Read();
            if (letter == '\n' || letter == '\r')
            {
                break;
            }
            for (int i = 0; i < 26; i++)
            {
                if (letter == arr[i])
                {
                    wordIndexes.Add(i);
                }
            }
        }
        Console.WriteLine("The indexes of the letter in the word is:");
        foreach (var index in wordIndexes)
        {
            Console.Write(index+ " ");
        }
        Console.WriteLine();
    }
}