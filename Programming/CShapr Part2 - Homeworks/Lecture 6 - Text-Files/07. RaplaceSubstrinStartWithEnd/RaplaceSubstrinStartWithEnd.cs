using System;
using System.IO;

class RaplaceSubstrinStartWithEnd
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\File 1.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"..\..\File 2.txt");
            using (writer)
            {           
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("The result is in --> File 2.txt");
    }
}

