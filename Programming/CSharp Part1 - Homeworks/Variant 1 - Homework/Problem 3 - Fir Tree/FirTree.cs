using System;

class FirTree
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        for (int i = 1; i < n ; i++)
        {
            for (int k = 0; k < (n - i - 1); k++)
            {
                Console.Write(".");
            }
            for (int k = 0; k < ((i * 2) - 1); k++)
            {
                Console.Write("*");
            }
            for (int k = 0; k < (n - i - 1); k++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int k = 0; k < (n - 2); k++)
        {
            Console.Write(".");
        }
        Console.Write("*");
        for (int k = 0; k < (n - 2); k++)
        {
            Console.Write(".");
        }
        Console.WriteLine();        
    }
}

