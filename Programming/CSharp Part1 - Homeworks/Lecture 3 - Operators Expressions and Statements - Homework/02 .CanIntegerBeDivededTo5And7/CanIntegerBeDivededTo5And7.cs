using System;

class CanIntegerBeDivededTo5And7
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        if ((number % 5 == 0) & (number % 7 == 0))
        {
            Console.WriteLine("The number can be divided to 5 and 7 without reminder.");
        }
        else
        {
            Console.WriteLine("The number can't be divided to 5 and 7 without reminder.");
        }
    }
}

