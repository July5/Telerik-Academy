using System;

class ThreeDSlices
{
    static void Main()
    {
        string sizes = Console.ReadLine();
        string[] sizesList = sizes.Split(' ');
        int width = int.Parse(sizesList[0]);
        int height = int.Parse(sizesList[1]);
        int depth = int.Parse(sizesList[2]);
        int[,,] cube = new int[width, height, depth];
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine();
            string[] pieces = line.Split('|');
            for (int j = 0; j < depth; j++)
            {
                string[] numbers = pieces[j].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int k = 0; k < width; k++)
                {
                    int cell = int.Parse(numbers[k]);
                    cube[k, i, j] = cell;
                }
            }
        }
        long maxSum = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                for (int k = 0; k < depth; k++)
                {
                    maxSum += cube[i, j, k];
                }
            }
        }
        int count = 0;
        long sum = 0;
        for (int i = 0; i < width-1; i++)
        {
            for (int j = 0; j < height; j++)
            {
                for (int k = 0; k < depth; k++)
                {
                    sum += cube[i, j, k];
                }
            }
            if (sum+sum == maxSum)
            {
                count++;
            }
        }
        sum = 0;
        for (int i = 0; i < height-1; i++)
        {
            for (int j = 0; j < width; j++)
            {
                for (int k = 0; k < depth; k++)
                {
                    sum += cube[i, j, k];
                }
            }
            if (sum + sum == maxSum)
            {
                count++;
            }
        }
        sum = 0;
        for (int i = 0; i < depth-1; i++)
        {
            for (int j = 0; j < width; j++)
            {
                for (int k = 0; k < height; k++)
                {
                    sum += cube[i, j, k];
                }
            }
            if (sum + sum == maxSum)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

