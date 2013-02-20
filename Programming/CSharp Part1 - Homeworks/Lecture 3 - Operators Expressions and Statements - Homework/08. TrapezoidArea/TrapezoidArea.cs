using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Write side A of trapezoid: ");
        string stringSideA = Console.ReadLine();
        int sideA = int.Parse(stringSideA);
        Console.Write("Write side B of trapezoid: ");
        string stringSideB = Console.ReadLine();
        int sideB = int.Parse(stringSideB);
        Console.Write("Write the height of trapezoid: ");
        string stringHeight = Console.ReadLine();
        int height = int.Parse(stringHeight);
        Console.WriteLine("Trapezoid's area is: {0}", ((sideA * sideB) / 2) * height);
    }
}

