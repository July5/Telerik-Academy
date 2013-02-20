using System;

class GreatestDivisorOfTwoIntegerNumbers
{
    static void Main()
    {
        Console.Write("Enter first integer number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer number: ");
        int number2 = int.Parse(Console.ReadLine());
        int reminder = 0;
        int helper;
        if (number2 > number1)
        {
            helper = number1;
            number1 = number2;
            number2 = helper;
        }
        do
        {
            reminder = (number1 % number2);
            if (reminder != 0)
            {
                number1 = number2;
                number2 = reminder;
            }
        }
        while (reminder != 0);
        Console.WriteLine("The greatest common divisor of the two given integer numbers is: {0}", number2);
	}    
}

