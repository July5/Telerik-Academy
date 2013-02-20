using System;
using System.IO;

class ConcatenateTwoTextFiles
{
    static void Main()
    {
        string source1 = @"..\..\File 1.txt";
        string source2 = @"..\..\File 2.txt";
        string destination = @"..\..\File 1+2.txt";
        Concatenation(source1, destination, false);
        Concatenation(source2, destination, true);
        Console.WriteLine("Concatenations completed!");
    }
  
    static void Concatenation(string source, string destination, bool add)
    {
            StreamReader reader = new StreamReader(source);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(destination, add);
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                    writer.WriteLine("\n");
                }
            }
    }
}
