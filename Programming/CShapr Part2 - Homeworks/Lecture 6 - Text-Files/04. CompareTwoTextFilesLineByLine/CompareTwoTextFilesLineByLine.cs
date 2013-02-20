using System;
using System.IO;

class CompareTwoTextFilesLineByLine
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader(@"..\..\File 1.txt");
        using (reader1)
        {
            StreamReader reader2 = new StreamReader(@"..\..\File 2.txt");
            using (reader2)
            {
                string line1 = reader1.ReadLine();
                string line2 = reader2.ReadLine();
                int linenumber = 1;
                while (line1 != null)
                {
                    if (line1 == line2)
                    {
                        Console.WriteLine("Lines {0} from the both text files are: Same", linenumber);
                    }
                    else
                    {
                        Console.WriteLine("Lines {0} from the both text files are: Different", linenumber);
                    }
                    line1 = reader1.ReadLine();
                    line2 = reader2.ReadLine();
                    linenumber++;
                }
            }
        }

    }
}

