using System;

class TenRandomNumbers
{
    static void Main()
    {
        Random randomGen = new Random();
        Console.WriteLine("Ten random numbers in range [1..100]: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomGen.Next(100));
        }

    }
}

