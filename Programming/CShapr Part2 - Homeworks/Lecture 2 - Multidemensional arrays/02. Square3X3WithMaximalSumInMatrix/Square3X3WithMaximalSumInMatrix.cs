using System;

class Square3X3WithMaximalSumInMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix[N, M]!");
        Console.Write("Enter size N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter size M: ");
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter element with index [{0}, {1}]: ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        int sum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                if (sum < (matrix[row, col] + matrix[row+1, col] + matrix[row+2, col] +
                    matrix[row, col+1] + matrix[row, col+2] + matrix[row+1, col+1] +
                    matrix[row+1, col+2] + matrix[row+2, col+1] + matrix[row+2, col+2]))
                {
                    sum = (matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                    matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 1] +
                    matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2]);
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The square 3X3 with maximal sum in the given matrix is:");
        Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol+1], matrix [bestRow, bestCol+2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow+1, bestCol], matrix[bestRow+1, bestCol + 1], matrix[bestRow+1, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow+2, bestCol], matrix[bestRow+2, bestCol + 1], matrix[bestRow+2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", sum);
    }
}

