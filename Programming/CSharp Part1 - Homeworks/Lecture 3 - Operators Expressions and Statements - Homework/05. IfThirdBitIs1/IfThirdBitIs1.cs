using System;

class IfThirdBitIs1
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        int position = 3;              
        int mask = 1 << position;        
        int numberAndMask = number & mask;  
        int bit = numberAndMask >> position;
        if (bit == 1)
        {
            Console.WriteLine("The third bit of the number is 1.");
        }
        else
        {
            Console.WriteLine("The third bit of the number is 0.");
        }
    }
}

