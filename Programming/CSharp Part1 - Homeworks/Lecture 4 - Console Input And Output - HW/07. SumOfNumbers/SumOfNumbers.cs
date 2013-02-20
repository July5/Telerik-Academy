using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine("Enter numbers to sum: ");
        for (int i = 1; i <= n; i++)
        {
            int addNumber = int.Parse(Console.ReadLine());
            sum += addNumber;
        }
        Console.WriteLine("The sum of all entered number are: {0}", sum);
    }
}

