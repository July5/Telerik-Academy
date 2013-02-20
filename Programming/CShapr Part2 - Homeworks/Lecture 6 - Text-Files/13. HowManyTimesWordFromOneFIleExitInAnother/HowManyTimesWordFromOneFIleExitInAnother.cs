using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class HowManyTimesWordFromOneFIleExitInAnother
{
    static void Main()
    {
        //try
        {
            List<string> givenList = new List<string>();
            StreamReader reader = new StreamReader(@"..\..\Words.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    givenList.AddRange(line.Split(' ', ',', '.'));
                    line = reader.ReadLine();
                }
            }
            StreamReader reader2 = new StreamReader(@"..\..\test.txt");
            using (reader2)
            {
                StreamWriter writer = new StreamWriter(@"..\..\result.txt");
                using (writer)
                {
                    int[] count = new int[givenList.Count];
                    string line = reader2.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < givenList.Count; i++)
                        {
                            count[i] += Regex.Matches(line, "\\b" + givenList[i] + "\\b").Count;
                        }
                        line = reader2.ReadLine();
                    }
                    string[] sortedWords = (string[])givenList.ToArray().Clone();
                    Array.Sort(count, sortedWords);
                    for (int i = sortedWords.Length-1; i >= 0; i--)
                    {
                        writer.WriteLine("{0} -> {1} times found in the test.txt.", sortedWords[i], count[i]);
                    }
                }
            }
            Console.WriteLine("The result is in --> result.txt");
        }
        //catch (Exception e)
        //{
        //    Console.WriteLine("{0} --> {1}", e.GetType().Name, e.Message);
        //}
    }
}

