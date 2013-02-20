using System;

class ReverseCertanBitInNumber
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringN = Console.ReadLine();
        int n = int.Parse(stringN);
        Console.Write("Write value: ");
        string stringV = Console.ReadLine();
        int v = int.Parse(stringV);
        Console.Write("Write position: ");
        string stringP = Console.ReadLine();
        int p = int.Parse(stringP);
        if (v == 1)
        {
            int mask = 1 << p;
            int iAndMask = n | mask;
            Console.WriteLine(Convert.ToString(iAndMask, 2).PadLeft(32, '0'));
        }
        if (v == 0)
        {
            int mask = ~(1 << p);
            int iAndMask = n & mask;
            Console.WriteLine(Convert.ToString(iAndMask, 2).PadLeft(32, '0'));
        }
    }
}

