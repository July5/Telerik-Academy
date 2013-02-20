using System;

class PrintTheNumberSequence
{
    static void Main()
    {
        Console.WriteLine("The First 10 numbers of the sequence are:");
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(" "+i);
            else
                Console.WriteLine(-i);
        }

    }
}
