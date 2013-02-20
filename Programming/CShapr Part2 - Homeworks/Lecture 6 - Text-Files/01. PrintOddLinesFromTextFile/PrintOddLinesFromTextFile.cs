using System;
using System.IO;

class PrintOddLinesFromTextFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Problem 1.txt");
        using (reader)
        {
            int lineNumber = 1;
            string oddLine = reader.ReadLine();
            while (oddLine != null)
            {
                if (lineNumber%2 == 1)
                {
                    Console.WriteLine("Line number {0}: {1}", lineNumber, oddLine);
                }                
                oddLine = reader.ReadLine();
                lineNumber++;
            }
        }

    }
}

