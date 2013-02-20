using System;

class Guitar
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] inputInterval = line.Split(',');
        int[] numbersInterval = new int[inputInterval.Length];
        for (int i = 0; i < inputInterval.Length; i++)
        {
            numbersInterval[i] = int.Parse(inputInterval[i].Trim());
        }
        int B = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[numbersInterval.Length + 1, M + 1];
        matrix[0, M] = 1;
        Console.WriteLine(NewMethod(numbersInterval, M, matrix));
    }

    static int NewMethod(int[] numbersInterval, int M, int[,] matrix)
    {
        for (int i = 1; i <= numbersInterval.Length; i++)
        {
            for (int j = 0; j <= M; j++)
            {
                int current = numbersInterval[i - 1];
                if (matrix[i - 1, j] == 1)
                {
                    if (j + current <= M)
                    {
                        matrix[i, j + current] = 1;
                    }
                    if (j - current >= 0)
                    {
                        matrix[i, j - current] = 1;
                    }
                }
            }
        }
        for (int i = M; i >= 0; i--)
        {
            if (matrix[numbersInterval.Length, i] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}

