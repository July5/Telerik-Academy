using System;

class StringLiteralWithQuotes
{
    static void Main()
    {
        string quatation1 = @"The ""use"" of quatation causes difficulties.";
        Console.WriteLine(quatation1);
        string quatation2 = "The \"use\" of quatation causes difficulties.";
        Console.WriteLine(quatation2);
        string quatation3 = "The use of quatation causes difficulties.";
        Console.WriteLine(quatation3);
    }
}

