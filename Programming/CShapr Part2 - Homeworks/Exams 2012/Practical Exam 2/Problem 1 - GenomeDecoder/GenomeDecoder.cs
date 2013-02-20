using System;
using System.Collections.Generic;
using System.Text;

class GenomeDecoder
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] numbers = line.Split(' ');
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i].Trim();
        }
        int N = int.Parse(numbers[0]);
        int M = int.Parse(numbers[1]);
        string genome = Console.ReadLine();
        StringBuilder index = new StringBuilder();
        StringBuilder finalGenom = new StringBuilder();
        for (int i = 0; i < genome.Length; i++)
        {
            if (genome[i] != 'A' && genome[i] != 'C' && genome[i] != 'G' && genome[i] != 'T')
            {
                index.Append(genome[i]);
            }
            else
            {
                if (index.ToString() == "")
                {
                    finalGenom.Append(genome[i]);
                }
                else
                {
                    for (int j = 0; j < int.Parse(index.ToString()); j++)
                    {
                        finalGenom.Append(genome[i]);
                    }
                }
                index.Clear();
            }
        }
        int linee = 2;
        int indexe = 0;
        int format = finalGenom.Length / N +1;
        switch (format / 10)
        {
            case 1:
                index.Append(" ");
                break;
            case 2:
                index.Append("  ");
                break;
            case 3:
                index.Append("   ");
                break;
            case 4:
                index.Append("    ");
                break;
            case 5:
                index.Append("     ");
                break;
            default:
                break;
        }
        index.Append("1 " +finalGenom[0].ToString());
        for (int i = 1; i < finalGenom.Length; i++)
        {
            indexe++;
            
            if (i % N == 0)
            {
                index.Append("\n");
                switch (format / 10)
                {
                    case 1:
                        index.Append(" ");
                        break;
                    case 2:
                        index.Append("  ");
                        break;
                    case 3:
                        index.Append("   ");
                        break;
                    case 4:
                        index.Append("    ");
                        break;
                    case 5:
                        index.Append("     ");
                        break;
                    default:
                        break;
                }
                if (i / (N-1) >= 10)
                {
                    index.Append("\b");
                }
                index.Append(linee++);
                indexe = 0;
            }
            if (indexe % M == 0)
            {
                index.Append(" ");
            }
           
            index.Append(finalGenom[i].ToString());            
        }
        Console.WriteLine(index.ToString());
    }
}

