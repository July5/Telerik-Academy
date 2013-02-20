using System;

class ProfessionalBitExchange
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        Console.Write("Write position P: ");
        string stringP = Console.ReadLine();
        int p = int.Parse(stringP);
        Console.Write("Write position Q: ");
        string stringQ = Console.ReadLine();
        int q = int.Parse(stringQ);
        Console.Write("Write how many bit to exchange: ");
        string stringK = Console.ReadLine();
        int k = int.Parse(stringK);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int result = number;
        int interval = Math.Abs(p - q);
        if (p > q)
        {
            int exchange = p;
            p = q;
            q = exchange;
        }
        for (int i = 0; i <= k; i++)
        {
            int mask1 = 1 << (p + i);
            int numberAndMask1 = number & mask1;
            int mask1A = numberAndMask1 << interval;
            int mask1B = numberAndMask1 >> (p + i);
            if (mask1B == 1)
            {
                result = result | mask1A;
            }
            else
            {
                result = result & (~(mask1 << interval));
            }
            int mask2 = 1 << (q + i);
            int numberAndMask2 = number & mask2;
            int mask2A = numberAndMask2 >> interval;
            int mask2B = numberAndMask2 >> (q + i);
            if (mask2B == 1)
            {
                result = result | mask2A;
            }
            else
            {
                result = result & (~(mask2 >> interval));
            }
        }
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

