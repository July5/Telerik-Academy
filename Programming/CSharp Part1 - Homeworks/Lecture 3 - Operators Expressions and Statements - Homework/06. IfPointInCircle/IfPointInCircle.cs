using System;

class IfPointInCircle
{
    static void Main()
    {
        Console.Write("Write X coordinate: ");
        string stringNumber = Console.ReadLine();
        double xCoordinate = double.Parse(stringNumber);
        Console.Write("Write Y coordinate: ");
        stringNumber = Console.ReadLine();
        double yCoordinate = double.Parse(stringNumber);
        if (((xCoordinate * xCoordinate) + (yCoordinate * yCoordinate)) <= 25)
        {
            Console.WriteLine("The point is in the circle.");
        }
        else
        {
            Console.WriteLine("The point is outside the circle.");
        }
    }
}

