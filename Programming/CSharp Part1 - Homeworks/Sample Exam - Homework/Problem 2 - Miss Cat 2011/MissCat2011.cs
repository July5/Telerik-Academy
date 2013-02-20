using System;

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cats = new int[10];
        int winner = 0;
        for (int i = 0; i < n; i++)
        {
            winner = int.Parse(Console.ReadLine());
            if (1 == winner)
            {
                cats[0]++;
            }
            if (2 == winner)
            {
                cats[1]++;
            }
            if (3 == winner)
            {
                cats[2]++;
            }     
            if (4 == winner)
            {
                cats[3]++;
            }
            if (5 == winner)
            {
                cats[4]++;
            }
            if (6 == winner)
            {
                cats[5]++;
            }
            if (7 == winner)
            {
                cats[6]++;
            }
            if (8 == winner)
            {
                cats[7]++;
            }
            if (9 == winner)
            {
                cats[8]++;
            }
            if (10 == winner)
            {
                cats[9]++;
            }        
        }
        if ((cats[0] >= cats[1]) && (cats[0] >= cats[2]) && (cats[0] >= cats[3]) && (cats[0] >= cats[4]) && (cats[0] >= cats[5]) && (cats[0] >= cats[6]) && (cats[0] >= cats[7]) && (cats[0] >= cats[8]) && (cats[0] >= cats[9]))
        {
            Console.WriteLine(1);
        }
        else if ((cats[0] <= cats[1]) && (cats[1] >= cats[2]) && (cats[1] >= cats[3]) && (cats[1] >= cats[4]) && (cats[1] >= cats[5]) && (cats[1] >= cats[6]) && (cats[1] >= cats[7]) && (cats[1] >= cats[8]) && (cats[1] >= cats[9]))
        {
            Console.WriteLine(2);
        }
        else if ((cats[2] >= cats[1]) && (cats[0] <= cats[2]) && (cats[2] >= cats[3]) && (cats[2] >= cats[4]) && (cats[2] >= cats[5]) && (cats[2] >= cats[6]) && (cats[2] >= cats[7]) && (cats[2] >= cats[8]) && (cats[2] >= cats[9]))
        {
            Console.WriteLine(3);
        }
        else if ((cats[3] >= cats[1]) && (cats[3] >= cats[2]) && (cats[0] <= cats[3]) && (cats[3] >= cats[4]) && (cats[3] >= cats[5]) && (cats[3] >= cats[6]) && (cats[3] >= cats[7]) && (cats[3] >= cats[8]) && (cats[3] >= cats[9]))
        {
            Console.WriteLine(4);
        }
        else if ((cats[4] >= cats[1]) && (cats[4] >= cats[2]) && (cats[4] >= cats[3]) && (cats[0] <= cats[4]) && (cats[4] >= cats[5]) && (cats[4] >= cats[6]) && (cats[4] >= cats[7]) && (cats[4] >= cats[8]) && (cats[4] >= cats[9]))
        {
            Console.WriteLine(5);
        }
        else if ((cats[5] >= cats[1]) && (cats[5] >= cats[2]) && (cats[5] >= cats[3]) && (cats[5] >= cats[4]) && (cats[0] <= cats[5]) && (cats[5] >= cats[6]) && (cats[5] >= cats[7]) && (cats[5] >= cats[8]) && (cats[5] >= cats[9]))
        {
            Console.WriteLine(6);
        }
        else if ((cats[6] >= cats[1]) && (cats[6] >= cats[2]) && (cats[6] >= cats[3]) && (cats[6] >= cats[4]) && (cats[6] >= cats[5]) && (cats[0] <= cats[6]) && (cats[6] >= cats[7]) && (cats[6] >= cats[8]) && (cats[6] >= cats[9]))
        {
            Console.WriteLine(7);
        }
        else if ((cats[7] >= cats[1]) && (cats[7] >= cats[2]) && (cats[7] >= cats[3]) && (cats[7] >= cats[4]) && (cats[7] >= cats[5]) && (cats[7] >= cats[6]) && (cats[0] <= cats[7]) && (cats[7] >= cats[8]) && (cats[7] >= cats[9]))
        {
            Console.WriteLine(8);
        }
        else if ((cats[8] >= cats[1]) && (cats[8] >= cats[2]) && (cats[8] >= cats[3]) && (cats[8] >= cats[4]) && (cats[8] >= cats[5]) && (cats[8] >= cats[6]) && (cats[8] >= cats[7]) && (cats[0] <= cats[8]) && (cats[8] >= cats[9]))
        {
            Console.WriteLine(9);
        }
        else if ((cats[9] >= cats[1]) && (cats[9] >= cats[2]) && (cats[9] >= cats[3]) && (cats[9] >= cats[4]) && (cats[9] >= cats[5]) && (cats[9] >= cats[6]) && (cats[9] >= cats[7]) && (cats[9] >= cats[8]) && (cats[0] <= cats[9]))
        {
            Console.WriteLine(10);
        }
    }
}
