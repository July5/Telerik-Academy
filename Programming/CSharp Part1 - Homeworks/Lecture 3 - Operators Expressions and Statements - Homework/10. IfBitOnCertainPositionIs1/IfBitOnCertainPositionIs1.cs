using System;

class IfBitOnCertainPositionIs1
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringV = Console.ReadLine();
        int v = int.Parse(stringV);
        Console.Write("Write position: ");
        string stringP = Console.ReadLine();
        int p = int.Parse(stringP);
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

