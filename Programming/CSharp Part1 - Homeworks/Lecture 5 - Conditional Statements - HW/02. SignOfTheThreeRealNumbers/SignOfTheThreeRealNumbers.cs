using System;

class SignOfTheThreeRealNumbers
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double number3 = double.Parse(Console.ReadLine());
        int result = 1;
        if (number1 < 0)
        {
            result += 1;
        }
        if (number2 < 0)
        {
            result += 1;
        }
        if (number3 < 0)
        {
            result += 1;
        }
        if ((result % 2) == 0)
        {
            Console.WriteLine("The sign is -"); ;
        }
        else
        {
            Console.WriteLine("The sign is +");
        }
    }
}

