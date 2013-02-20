using System;

class HelloWordString
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string msgHelloWorld = (string)helloWorld;
        Console.WriteLine(msgHelloWorld);
    }
}

