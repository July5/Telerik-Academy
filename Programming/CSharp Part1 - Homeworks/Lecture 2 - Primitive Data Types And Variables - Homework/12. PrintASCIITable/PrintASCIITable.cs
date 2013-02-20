using System;

class PrintASCIITable
{
    static void Main()
    {        
        for (int i = 0; i < 127; i++)
        {
            char acsiiChar = (char)i;
            Console.Write(acsiiChar+ "  ");
            if (i % 10 == 0 && i>0)
            {
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

