using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Write the width of rectangle: ");
        string stringWidth = Console.ReadLine();
        int width = int.Parse(stringWidth);
        Console.Write("Write the height of rectangle: ");
        string stringHeight = Console.ReadLine();
        int height = int.Parse(stringHeight);
        Console.WriteLine("Rectangle's area is: {0}", width*height);
    }
}

