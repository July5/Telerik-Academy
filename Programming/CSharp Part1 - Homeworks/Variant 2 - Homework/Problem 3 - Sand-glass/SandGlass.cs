using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int i = 1; i <= (((n - 2) / 2) + 1); i++)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write(".");
            }
            for (int k = 1; k <= (n - (2 * i)); k++)
            {
                Console.Write("*");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = ((n - 2) / 2); i >= 1 ; i--)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write(".");
            }
            for (int k = 1; k <= (n - (2 * i)); k++)
            {
                Console.Write("*");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }


        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

