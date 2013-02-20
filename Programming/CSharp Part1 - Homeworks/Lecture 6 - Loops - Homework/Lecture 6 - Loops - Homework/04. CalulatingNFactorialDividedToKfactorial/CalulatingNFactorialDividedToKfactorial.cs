using System;

class CalulatingNFactorialDividedToKfactorial
{
    static void Main()
    {
        Console.Write("Enter positive number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K greater than N: ");
        int k = int.Parse(Console.ReadLine());
        double kFactorial = 1;
        double nFactorial = 1;
        if ((k > n) && (n > 0))
        {
            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }
            double result = nFactorial / kFactorial;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Enter correct numbers next time!");
        }
    }
}

