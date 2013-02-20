using System;

class SumTwoPolynomials
{
    static void Main()
    {
        Console.Write("Enter degree of the first polynomial: ");
        int degree1 = int.Parse(Console.ReadLine());
        int[] Poly1 = new int[degree1+1];
        Console.WriteLine("Enter elements for the array:");
        for (int i = 0; i <= degree1; i++)
        {
            Console.Write("X^{0} = ", i);
            Poly1[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter degree of the second polynomial: ");
        int degree2 = int.Parse(Console.ReadLine());
        int[] Poly2 = new int[degree2+1];
        Console.WriteLine("Enter elements for the array:");
        for (int i = 0; i <= degree2; i++)
        {
            Console.Write("X^{0} = ", i);
            Poly2[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum of the two given polynomials: ");
        int[] result = SumPolynomials(Poly1, Poly2);
        for (int i = Math.Max(degree1, degree2); i >= 0 ; i--)
        {
            Console.Write("X^{0} ", result[i]);
            if (i != 0)
            {
                Console.Write("+ ");
            }
        }
        Console.WriteLine();
    }

    static int[] SumPolynomials(int[] arr1, int[] arr2)
    {
        int lessLength;
        int maxLength;
        int key = 0;
        if (arr1.Length > arr2.Length)
        {
            lessLength = arr2.Length;
            maxLength = arr1.Length;
            key = 1;
        }
        else
        {
            lessLength = arr1.Length;
            maxLength = arr2.Length;
            key = 2;
        }
        int[] result = new int[maxLength];
        for (int i = 0; i < lessLength; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }
        if(key == 1)
        {
            for (int i = lessLength; i <= maxLength; i++)
            {
                result[i] = arr1[i];
            }
        }
        else
	    {
             for (int i = lessLength; i < maxLength; i++)
            {
                result[i] = arr2[i];
            }
	    }
        return result;
    }

}

