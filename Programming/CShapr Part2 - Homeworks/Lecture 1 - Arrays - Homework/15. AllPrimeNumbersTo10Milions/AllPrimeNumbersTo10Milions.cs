using System;
using System.Collections.Generic;

class AllPrimeNumbersTo10Milions
{
    static void Main()
    {
        List<int> primeNumbers = new List<int>();
        primeNumbers.Add(2);
        int rulePrime = 0;
        Console.Write(2+ "  ");
        for (int i = 2; i < 10000000; i++)
        {
            for (int k = 0; k < primeNumbers.Count; k++)
            {
                if (i % primeNumbers[k] == 0)
                {
                    rulePrime++;
                    break;
                }
            }
            if (rulePrime == 0)
            {
                primeNumbers.Add(i);
                Console.Write(i + "  ");
            }
            rulePrime = 0;
        }
        //foreach (var element in primeNumbers)
        //{
        //    Console.Write(element +"  ");
        //}
    }
}

