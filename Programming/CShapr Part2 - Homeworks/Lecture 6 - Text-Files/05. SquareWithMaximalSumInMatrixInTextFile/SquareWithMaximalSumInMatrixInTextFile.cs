using System;
using System.IO;

class SquareWithMaximalSumInMatrixInTextFile
{
    static void Main()
    {
        int N = 4;
        int[,] matrix = new int[N, N];
        StreamReader reader = new StreamReader(@"..\..\File 1.txt");
        using (reader)
        {            
            string line = reader.ReadLine();
            int lineNumber = 1;
            while (line != null)
            {
                string[] lineStr = line.Split(' ');
                for (int i = 0; i < N; i++)
                {
                    matrix[lineNumber-1, i] = int.Parse(lineStr[i]);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }
        int sum = int.MinValue;
        for (int row = 0; row < N - 1; row++)
        {
            for (int col = 0; col < N - 1; col++)
            {
                if((matrix[row,col] + matrix[row+1, col] + matrix[row, col+1] + matrix[row+1, col+1]) > sum)
                {
                    sum = matrix[row,col] + matrix[row+1, col] + matrix[row, col+1] + matrix[row+1, col+1];
                }
            }
        }
        Console.WriteLine("Maximal sum is: {0}", sum);
    }
}

