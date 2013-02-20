using System;

class ExchangeTwoIntegerIfFirstIsBigger
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        if (number1 > number2)
        {
            int exchange = number1;
            number1 = number2;
            number2 = exchange;
        }
        Console.WriteLine(number1);
        Console.WriteLine(number2);
    }
}

