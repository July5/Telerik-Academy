﻿using System;

class NumberForm1ToNNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (((i % 3) != 0) || ((i % 7) != 0))
            {
                Console.WriteLine(i);
            }            
        }
    }
}

