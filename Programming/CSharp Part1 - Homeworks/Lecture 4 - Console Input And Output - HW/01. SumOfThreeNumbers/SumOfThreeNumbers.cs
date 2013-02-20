using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 =int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Third number: ");
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three number is: {0}", number1 + number2 + number3);
    }
}

