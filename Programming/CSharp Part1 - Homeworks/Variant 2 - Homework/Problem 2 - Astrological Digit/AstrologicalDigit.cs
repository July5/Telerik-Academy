using System;

class AstrologicalDigit
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double afterPoint = 0;
        afterPoint = n % 1;
        afterPoint *= 1e+300;
        int result = 0;
        double helper = 0;
        do
        {            
            for (int i = 0; i < 300; i++)
            {
                helper = Math.Abs(n % 10);
                n /= 10;
                result += (int)helper;
                if (n <= 0)
                {
                    break;
                }
            }
            for (int i = 0; i < 300; i++)
            {
                helper = Math.Abs(afterPoint % 10);
                afterPoint /= 10; 
                result += (int)helper;
                if (afterPoint <= 0)
                {
                    break;
                }
            }
        }
        while (result > 9);
        Console.WriteLine(result);
    }
}