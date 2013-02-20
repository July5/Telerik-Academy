using System;

class FindLongestSequenceOfElementInMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix[N, M]!");
        Console.Write("Enter size N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter size M: ");
        int M = int.Parse(Console.ReadLine());
        string[,] matrix = new string[N, M];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter element with index [{0}, {1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        string longesSequance = null;
        string where = null;
        int count = 1;
        int maxCount = int.MinValue;
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        longesSequance = matrix[row, col];
                        maxCount = count;
                        where = "row";
                    }
                }
            }
            count = 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                    if (count > maxCount)
                    {
                        longesSequance = matrix[row, col];
                        maxCount = count;
                        where = "column";
                    }
                }
            }
            count = 1;
        }
        for (int row = 0, col = matrix.GetLength(1) - 1; (row < matrix.GetLength(0) - 1) && (0 < col); row++, col--)
        {
            if (matrix[row, col] == matrix[row + 1, col - 1])
            {
                count++;

                if (count > maxCount)
                {
                    longesSequance = matrix[row, col];
                    maxCount = count;
                    where = "diagonal";
                }
            }
            else
            {
                count = 1;
            }
        }
        count = 1;
        for (int col = 0, row = 0; (col < (matrix.GetLength(1) - 1)) && (row < matrix.GetLength(0) - 1); row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                count++;
                if (count > maxCount)
                {
                    longesSequance = matrix[row, col];
                    maxCount = count;
                    where = "diagonal";
                }
            }
            else
            {
                count = 1;
            }
        }
        count = 1;        
        Console.WriteLine("The longest sequance of elements in the matrix is on {0}: \"{1}\" repeating {2} times.", where, longesSequance, maxCount);
    }
}

