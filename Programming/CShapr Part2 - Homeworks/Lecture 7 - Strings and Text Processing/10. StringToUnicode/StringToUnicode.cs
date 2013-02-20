using System;

class StringToUnicode
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        for (int i = 0; i < stringText.Length; i++)
        {
            Console.Write("\\u{0:X4}", (ushort)stringText[i]);
        }
    }
}

