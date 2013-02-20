using System;
using System.Numerics;

class FactorialForNumbersToOneHundred
{
    static BigInteger Factorial(int number)
    {
        BigInteger result = 1;
        for (int i = 1; i <= number; i++)
			{
                result *= i;
			}
        return result;
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int numberN = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine("{0}! = {1}", i,  Factorial(i));
            Console.WriteLine();
        }
        
    }
}

