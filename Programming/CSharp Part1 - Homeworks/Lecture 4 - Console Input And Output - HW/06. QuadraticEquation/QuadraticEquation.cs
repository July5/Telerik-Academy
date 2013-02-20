using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        int c = int.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("The equation don't have real roots");
        }
        else
        {
            if (d == 0)
            {
                Console.WriteLine("The equation have one real root x = {0}", (-b) / (2 * a));
            }
            else
            {
                double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The first root of the equation is x1 = {0}", x1);
                Console.WriteLine("The first root of the equation is x2 = {0}", x2);
            }
        }


    }
}

