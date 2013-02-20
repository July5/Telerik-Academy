using System;

class ValueOfGivenBitNumber
{
    static void Main()
    {
        Console.Write("Write number: ");
        string stringI = Console.ReadLine();
        int i = int.Parse(stringI);
        Console.Write("Write position: ");
        string stringPosition = Console.ReadLine();
        int position = int.Parse(stringPosition);
        int mask = 1 << position;
        int iAndMask = i & mask;
        int bit = iAndMask >> position;
        Console.WriteLine("The value of {0} bit of the number {1} is: {2}", position, i, bit);
    }
}

