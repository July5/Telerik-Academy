using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter N in range {1;19}: ");
        int numberN = int.Parse(Console.ReadLine());
        if ((numberN < 20) && (numberN > 0))
        {
            for (int i = 0; i < numberN; i++)
            {
                for (int k = 1; k <= numberN; k++)
                {
                    Console.Write(i + k + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("N is not in the requered range!");
        }
        
    }
}

