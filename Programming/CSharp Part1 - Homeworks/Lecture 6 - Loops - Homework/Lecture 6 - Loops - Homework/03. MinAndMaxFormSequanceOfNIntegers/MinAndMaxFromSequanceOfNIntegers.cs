using System;

class MinAndMaxFromSequanceOfNIntegers
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        int max = 0;
        int min = 0;
        int currentNumber = 0;
        for (int i = 1; i <= n; i++)
        {
            currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber > max)
            {
                max = currentNumber;
            }
            if (currentNumber < min)
            {
                min = currentNumber;
            }
        }
        Console.WriteLine("Max number is: {0}", max);
        Console.WriteLine("Min number is: {0}", min);
    }
}

