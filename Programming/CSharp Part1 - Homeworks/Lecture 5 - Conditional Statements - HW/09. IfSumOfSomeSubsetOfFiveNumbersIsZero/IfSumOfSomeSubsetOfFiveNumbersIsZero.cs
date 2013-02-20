using System;

class IfSumOfSomeSubsetOfFiveNumbersIsZero
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int number4 = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int number5 = int.Parse(Console.ReadLine());
        if ((number1 + number2) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number3) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number2 + number3) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number2 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number2 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number3 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number3 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number4 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number2 + number3) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number2 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number2 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number4 + number2 + number3) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number5 + number2 + number3) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number4 + number3) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number5 + number4 + number3) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number4 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number4 + number2 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number2 + number3 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number2 + number3 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number2 + number5 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number5 + number3 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number5 + number2 + number3 + number4) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else if ((number1 + number2 + number3 + number4 + number5) == 0)
        {
            Console.WriteLine("The five given integer numbers have at least one subset sum equals to zero");
        }
        else
        {
            Console.WriteLine("The five given integer numbers don't have subset sums equals to zero");
        }
    }
}

