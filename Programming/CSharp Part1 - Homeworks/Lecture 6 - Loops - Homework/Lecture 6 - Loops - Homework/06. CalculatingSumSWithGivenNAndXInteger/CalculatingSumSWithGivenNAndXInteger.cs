using System;

class CalculatingSumSWithGivenNAndXInteger
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number X: ");
        int x = int.Parse(Console.ReadLine());
        double s = 0;
        double nFactorial = 1;
        for (int i = 0 ; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                nFactorial *= j;
            }
            s += nFactorial / (Math.Pow(x, i));
            nFactorial = 1;
        }
        Console.WriteLine("The sum S = {0}", s);
    }
}

