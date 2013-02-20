using System;

class BitExchange
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int result = number;
        for (int i = 0; i <= 2; i++)
        {
            int mask1 = 1 << (3 + i);
            int numberAndMask1 = number & mask1;
            int mask1A = numberAndMask1 << 21;
            int mask1B = numberAndMask1 >> (3 + i);
            if (mask1B == 1)
            {
                result = result | mask1A;
            }
            else
            {
                result = result & (~(mask1 << 21));
            }
            int mask2 = 1 << (24+i);
            int numberAndMask2 = number & mask2;           
            int mask2A = numberAndMask2 >> 21;
            int mask2B = numberAndMask2 >> (24 + i); 
            if (mask2B == 1)
            {
                result = result | mask2A;
            }
            else
            {
                result = result & (~(mask2 >> 21));
            }
        }
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

