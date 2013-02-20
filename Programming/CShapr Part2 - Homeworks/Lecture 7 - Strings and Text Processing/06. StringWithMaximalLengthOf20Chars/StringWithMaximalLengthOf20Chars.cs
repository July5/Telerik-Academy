using System;

class StringWithMaximalLengthOf20Chars
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        if (stringText.Length > 20)
        {
           Console.WriteLine("Resulted string: {0}", stringText = stringText.Remove(20));

        }
        else
        {
            Console.Write("Resulted string: {0}", stringText);
            for (int i = stringText.Length; i < 20; i++)
            {
                 Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

