using System;

class ThreeRealNumbersInDescendingOrder
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double number3 = double.Parse(Console.ReadLine());
        double exchange = 0;
        if (number1 > number2)
        {
            if (number1 > number3)
            {
                if (number2 > number3)
                {
                }
                else
                {
                    exchange = number2;
                    number2 = number3;
                    number3 = exchange;
                }
            }
            else
            {
                exchange = number1;
                number1 = number3;
                number3 = exchange;
                exchange = number2;
                number2 = number3;
                number3 = exchange;
            }
        }
        else
        {
            exchange = number2;
            number2 = number1;
            number1 = exchange;
            if (number1 > number3)
            {
                if (number2 > number3)
                {
                }
                else
                {
                    exchange = number2;
                    number2 = number3;
                    number3 = exchange;
                }
            }
            else
            {
                exchange = number1;
                number1 = number3;
                number3 = exchange;
                exchange = number2;
                number2 = number3;
                number3 = exchange;
            }
        }
        Console.WriteLine("The three numbers in descending order: {0}; {1}; {2}", number1, number2, number3);
    }
}

