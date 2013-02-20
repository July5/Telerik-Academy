using System;

class HelloUser
{
    static void Hello()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Hello();
    }
}

