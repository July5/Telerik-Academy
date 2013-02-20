using System;
using System.IO;

class GetOnlyTextFromXMLTextFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\File 1.txt");
        using(reader)
	    {
            StreamWriter writer = new StreamWriter(@"..\..\File 2.txt");
            using (writer)
            {
                int end;
                char currentChar = (char)(end = reader.Read());
                while (end != -1)
                {
                    if (currentChar == '>')
                    {
                        currentChar = (char)(end = reader.Read()); ;
                        while ((currentChar != '<') && (end !=-1))
                        {
                            writer.Write(currentChar);
                            currentChar = (char)(end = reader.Read());
                        }                   
                    }
                    currentChar = (char)(end = reader.Read());
                }
            }
	    }
        Console.WriteLine("File is written!");
    }
}

