using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = 1; i <= (n-1); i++)
        {
            for (int k = 1; k <= (n-i); k++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int k = 1; k < ((n-1) + i); k++)
            {
                Console.Write(".");
            }
            Console.WriteLine("*");
        }
        for (int i = 0; i < (2*n); i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
