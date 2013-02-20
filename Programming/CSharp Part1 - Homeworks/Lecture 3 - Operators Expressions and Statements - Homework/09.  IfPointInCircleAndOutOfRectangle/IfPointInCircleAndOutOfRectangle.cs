using System;

    class IfPointInCircleAndOutOfRectangle
{
    static void Main()
    {
        Console.Write("Write X coordinate: ");
        string stringNumber = Console.ReadLine();
        double xCoordinate = double.Parse(stringNumber);
        Console.Write("Write Y coordinate: ");
        stringNumber = Console.ReadLine();
        double yCoordinate = double.Parse(stringNumber);
        if ((((xCoordinate-1) * (xCoordinate-1)) + ((yCoordinate-1) * (yCoordinate-1))) <= 9)
        {
            if ((xCoordinate <= 1) & (xCoordinate >= -1) & (yCoordinate <= 5) & (yCoordinate >= -1))
            {
                Console.WriteLine("The point is in the circle and the rectangle");
            }
        }
        else
        {
            Console.WriteLine("The point is outside the circle and rectangle.");
        }
    }
}

