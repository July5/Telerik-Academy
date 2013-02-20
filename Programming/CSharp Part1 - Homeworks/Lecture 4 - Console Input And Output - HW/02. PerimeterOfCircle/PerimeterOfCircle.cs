using System;

class PerimeterOfCircle
{
    static void Main()
    {
        Console.Write("Enter the radius of a circle: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        Console.WriteLine("Perimeter: {0:F3}", radius*pi*2);
        Console.WriteLine("Area: {0:F3}", radius*pi*pi);
    }
}
