using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        byte check = 0;
        int result = 0;
        for (int i = 1; i < 10000000; i++)
        {
            if ((i % a) == 0)
            {
                check += 1;
            }
            if ((i % b) == 0)
            {
                check += 1;
            }
            if ((i % c) == 0)
            {
                check += 1;
            }
            if ((i % d) == 0)
            {
                check += 1;
            }
            if ((i % e) == 0)
            {
                check += 1;
            }
            if (check >= 3)
            {
                result = i;
                break;
            }
            check = 0;
        }
        Console.WriteLine(result);
    }
}

