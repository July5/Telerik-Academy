using System;
using System.IO;

class ReadAndPrintFileContent
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"C:\WINDOWS\win.ini");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory is not found.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path is too long.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The path is not in the requared format.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You are not authorized to open this file.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The given path is null");
        }
        finally
        {
            Console.WriteLine("See you next time!");
        }
    }
}

