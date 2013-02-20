using System;
using System.Numerics;

class SumOfFirstNNumbersOfFibonacci
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger number1 = 0;
        BigInteger number2 = 1;
        BigInteger helper;
        BigInteger sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (i == 2)
            {
                sum += 1;
                continue;
            }
            helper = number2;
            number2 += number1;
            number1 = helper;
            sum += number2;
        }
        Console.WriteLine("Sum is: {0}", sum);
    }
}

