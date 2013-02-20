using System;

class IfNumberIsPrime
{
    static void Main()
    {
        Console.Write("Write number in the interval [0;100]: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        if ((number <= 100) & (number >= 0))
        {
            int count = 0;
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    count = +1;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("The number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }
        }
        else
        {
            Console.WriteLine("The number is not in the requested interval!");
        }
    }

}

