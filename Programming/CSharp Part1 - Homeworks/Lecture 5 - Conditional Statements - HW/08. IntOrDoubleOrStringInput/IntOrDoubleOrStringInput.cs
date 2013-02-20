using System;

class IntOrDoubleOrStringInput
{
    static void Main()
    {
        Console.Write("Enter integer number, double number or string sequence: ");
        string inputString = Console.ReadLine();
        double doubleNumber;
        int intNumber;
        if (double.TryParse(inputString, out doubleNumber))
        {
            doubleNumber += 1;
            Console.WriteLine(doubleNumber);
        }
        else
        {
            if (int.TryParse(inputString, out intNumber))
            {
                intNumber += 1;
                Console.WriteLine(intNumber);
            }
            else
            {
                Console.WriteLine(inputString + "*");
            }
        }
    }

    public static string inputString { get; set; }
}

