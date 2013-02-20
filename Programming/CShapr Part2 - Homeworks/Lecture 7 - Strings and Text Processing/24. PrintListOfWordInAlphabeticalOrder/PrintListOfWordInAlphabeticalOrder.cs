using System;

class PrintListOfWordInAlphabeticalOrder
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        string[] arrString = stringText.Split(' ');
        Array.Sort(arrString);
        for (int i = 0; i < arrString.Length; i++)
        {
            Console.WriteLine(arrString[i]);
        }

    }
}

