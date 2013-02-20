using System;

class PrintNumberInTheInterval
{
    static void Main()
    {
        Console.Write("Enter the end of the interval: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("{0,3}",i);
        }

    }
}

