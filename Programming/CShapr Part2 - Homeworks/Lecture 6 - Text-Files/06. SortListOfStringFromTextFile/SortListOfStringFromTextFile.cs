using System;
using System.Collections.Generic;
using System.IO;

class SortListOfStringFromTextFile
{
    static void Main()
    {
        List<string> arrNames = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\File 1.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                arrNames.Add(line);
                line = reader.ReadLine();
            }
        }
        arrNames.Sort();
        StreamWriter writer = new StreamWriter(@"..\..\File 2.txt");
        using (writer)
        {
            for (int i = 0; i < arrNames.Count; i++)
            {
                writer.WriteLine(arrNames[i]);
            }                
        }
        Console.WriteLine("Names are sorted!");
    }
}

