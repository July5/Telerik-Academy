using System;

class PrintMatrixWithPattern
{
    static void Main()
    {
        Console.Write("Enter size N: ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N,N];
        matrix = PatternA(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();
        matrix = PatternB(matrix);
        PrintMatrix(matrix);
        Console.WriteLine();
        matrix = PatternC(matrix);
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
		{
            for (int col = 0; col < matrix.GetLength(1); col++)
			{
                 Console.Write("{0} ",matrix[row, col]);   
			}
            Console.WriteLine();
		}
    }

    static int[,] PatternA(int[,] matrix)
    {
        byte filler = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = filler++;
            }
        }
        return matrix;
    }

    static int[,] PatternB(int[,] matrix)
    {
        byte filler = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if ((filler % matrix.GetLength(0) == 1) && (filler % (matrix.GetLength(0) * 2) != 1))
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = filler++;
                }
            }
            else
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = filler++;
                }
            }
        }
        return matrix;
    }

    static int[,] PatternC(int[,] matrix)
    {
        int filler = 1;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < (matrix.GetLength(0) - row); col++)
            {
                matrix[row + col, col] = filler++;
            }
        }
        for (int col = 1; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < (matrix.GetLength(0) - col); row++)
            {
                matrix[row, col + row] = filler++;
            }
        }
        return matrix;
    }
}

