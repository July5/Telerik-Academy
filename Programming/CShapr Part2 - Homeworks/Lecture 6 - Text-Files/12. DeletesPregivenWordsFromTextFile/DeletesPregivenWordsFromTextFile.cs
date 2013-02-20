using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeletesPregivenWordsFromTextFile
{
    static void Main()
    {
        try
        {
            List<string> givenList = new List<string>();
            StreamReader reader = new StreamReader(@"..\..\Given List.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    givenList.AddRange(line.Split(' ', ',', '.'));
                    line = reader.ReadLine();
                }
            }
            StreamReader reader2 = new StreamReader(@"..\..\File 1.txt");
            using (reader2)
            {
                StreamWriter writer = new StreamWriter(@"..\..\File 2.txt");
                using (writer)
                {
                    string line = reader2.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < givenList.Count; i++)
                        {
                            line = line.Replace(givenList[i], "");
                        }
                        writer.WriteLine(line);
                        line = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("The result is in --> File 2.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} --> {1}", e.GetType().Name, e.Message);
        }
    }
}

