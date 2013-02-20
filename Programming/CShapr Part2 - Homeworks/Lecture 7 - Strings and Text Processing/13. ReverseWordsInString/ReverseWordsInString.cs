using System;

class ReverseWordsInString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        char end = stringText[stringText.Length - 1];
        stringText = stringText.Trim('.', '!', '?');
        string[] arrString = stringText.Split(' ');
        for (int i = arrString.Length-1; i >= 0; i--)
        {
            Console.Write(arrString[i] + " ");
        }
        Console.WriteLine("\b" + end);
    }
}
