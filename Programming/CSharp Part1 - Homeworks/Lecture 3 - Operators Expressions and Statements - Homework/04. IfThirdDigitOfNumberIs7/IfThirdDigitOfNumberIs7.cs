using System;

class IfThirdDigitOfNumberIs7
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        if ((((number / 100) % 10)) == 7)
        {
            Console.WriteLine("The third digit of the number is 7");
        }
        else
        {
            Console.WriteLine("The third digit of the number is not 7");
        }
    }
}

