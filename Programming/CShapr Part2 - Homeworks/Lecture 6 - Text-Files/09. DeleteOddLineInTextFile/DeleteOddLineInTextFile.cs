using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLineInTextFile
{
    static void Main()
    {
        List<string> evenLines = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\File 1.txt");
        using (reader)
        {           
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 1)
                {
                    evenLines.Add(line);
                }
                line = reader.ReadLine();
                lineNumber++;
            }            
        }
        StreamWriter writer = new StreamWriter(@"..\..\File 1.txt");
        using (writer)
        {
            for (int i = 0; i < evenLines.Count; i++)
            {
                writer.WriteLine(evenLines[i]);
            }
        }
        Console.WriteLine("File is updated!");
    }
}

