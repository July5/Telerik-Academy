using System;

class IntOrDoubleOrStringInputWithSwitch
{
    static void Main()
    {
        Console.Write("Enter the type of input variable -> 1 for integer; 2 for double; 3 for string sequence: ");
        byte inputType = byte.Parse(Console.ReadLine());        
        switch (inputType)
        {
            case 1:
                Console.Write("Enter integer number: ");
                int intNumber = int.Parse(Console.ReadLine());
                intNumber += 1;
                Console.WriteLine(intNumber);
                break;
            case 2:
                Console.Write("Enter double number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber += 1;
                Console.WriteLine(doubleNumber);
                break;
            case 3:
                Console.Write("Enter string sequence: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + "*");
                break;
            default:
                Console.WriteLine("Entered code is not 1, 2 or 3. Please enter correct code next time!");
                break;
        }
    }
}

