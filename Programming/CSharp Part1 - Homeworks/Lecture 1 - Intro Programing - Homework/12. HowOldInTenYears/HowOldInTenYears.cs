using System;

class HowOldInTenYears
{
    static void Main()
    {
        Console.WriteLine("Your current age is:");
        string readAge = System.Console.ReadLine();
        int age = int.Parse(readAge);
        Console.WriteLine("After ten year, you will be " +(age+10)+ " years old.");
    }
}

