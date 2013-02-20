using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger nFactorialMulti2 = 1;
        BigInteger nFactorialPlus1;
        for (int i = 1; i <= numberN; i++)
        {
            nFactorial *= i;
        }
        for (int i = 1; i <= (numberN * 2); i++)
        {
            nFactorialMulti2 *= i;
        }
        nFactorialPlus1 = nFactorial * (numberN + 1);
        Console.WriteLine("The Catalan Number for the given N is: {0}", (nFactorialMulti2 / (nFactorial * nFactorialPlus1)));
    }
}

