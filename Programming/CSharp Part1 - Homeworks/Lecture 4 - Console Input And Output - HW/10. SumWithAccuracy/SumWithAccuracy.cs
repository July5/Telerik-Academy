using System;

class SumWithAccuracy
{
    static void Main()
    {
        float sum1 = 0f;
        float sum2 = 1f;
        float helper = 1f;
        int alternative = 2;
        while (Math.Abs(sum2-sum1) >= 0.001)
        {
            sum1 = sum2;
            if ((alternative % 2) == 1)
            {
                sum2 = sum2 - (helper / alternative);
            }
            else
            {
                sum2 = sum2 + (helper / alternative);
            }
            alternative++;
        }
        Console.WriteLine(sum2);
        Console.WriteLine(alternative);
    }
}

