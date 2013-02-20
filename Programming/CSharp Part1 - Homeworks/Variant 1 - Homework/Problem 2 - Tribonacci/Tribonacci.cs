using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());    
        int t3 = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger[] tribo = new BigInteger[n];
        tribo[0] = t1;
        tribo[1] = t2;
        tribo[2] = t3;
        for (int i = 3; i <= n-1; i++)
        {
            tribo[i] = tribo[i - 1] + tribo[i - 2] + tribo[i - 3];
        }
        Console.WriteLine(tribo[n-1]);
    }
}

