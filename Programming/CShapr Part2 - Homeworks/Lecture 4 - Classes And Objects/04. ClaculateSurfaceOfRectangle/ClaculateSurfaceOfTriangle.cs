using System;

class ClaculateSurfaceOfTriangle
{
    static void Main()
    {
        SurfaceOfTriangle(2, 6.7);
        SurfaceOfTriangle(angle:65, a:2, b:5);
        SurfaceOfTriangle(a:3, b:4 ,c:2);
    }

    static void SurfaceOfTriangle(double a, double h)
    {
        Console.WriteLine("The Surface of triangle is: {0:F3}", (a*h)/2);
    }

    static void SurfaceOfTriangle(int angle, double a, double b)
    {
        Console.WriteLine("The Surface of triangle is: {0:F3}", (a * b * Math.Sin(angle/57.3)) / 2);
    }

    static void SurfaceOfTriangle(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        Console.WriteLine("The Surface of triangle is: {0:F3}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }
}

