using System;
using System.IO;

class LineNumberBeforeEveryLine
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\File 1.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"..\..\File 2.txt");
            using (writer)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{1}. {0}", line, lineNumber);
                    line = reader.ReadLine();
                    lineNumber++;
                }
                writer.WriteLine("\n");
            }
        }
        Console.WriteLine("File is written!");
    }
}

