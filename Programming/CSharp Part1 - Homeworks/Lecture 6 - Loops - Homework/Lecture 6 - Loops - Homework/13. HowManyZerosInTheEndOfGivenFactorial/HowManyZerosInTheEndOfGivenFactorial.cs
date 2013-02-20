using System;
using System.Numerics;

class HowManyZerosInTheEndOfGivenFactorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        int sumZeros = 0;
        for (int i = 1; i <= numberN; i++)
        {
            nFactorial *= i;
        }        
        for (int i = 5; i <= numberN; i*=5)
        {
            sumZeros += (numberN / i);
        }
        Console.WriteLine(nFactorial);
        Console.WriteLine("There are {0} zeros in the end of N!", sumZeros);
    }
}

