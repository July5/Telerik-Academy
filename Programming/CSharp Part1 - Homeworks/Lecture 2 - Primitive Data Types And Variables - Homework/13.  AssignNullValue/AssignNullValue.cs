using System;

class AssignNullValue
{
    static void Main()
    {
        int? integerNull = null;
        double? doubleNull = null;
        Console.WriteLine(integerNull);
        Console.WriteLine(doubleNull);
        integerNull = 34;
        doubleNull = 45.9887;
        Console.WriteLine(integerNull);
        Console.WriteLine(doubleNull);
    }
}

