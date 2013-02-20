using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k < i; k++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int k = 1; k <= (n - i); k++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = 1; i < n; i++)
        {
            for (int k = 1; k <= (n - i - 1); k++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int k = 1; k <= i; k++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}

