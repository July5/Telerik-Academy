using System;

class ExtraxtPolindromesFromString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string stringText = Console.ReadLine();
        string[] arrString = stringText.Split(' ', ',', '.', '.', '?', '!', ':', ';', '-');
        bool checkPolindrome = false;
        Console.WriteLine("Polindromes are:");
        for (int i = 0; i < arrString.Length; i++)
        {
            for (int j = 0; j <= arrString[i].Length/2; j++)
            {
                if (arrString[i][j] == arrString[i][arrString[i].Length-j-1])
                {
                    checkPolindrome = true;
                }
            }
            if (checkPolindrome)
            {
                Console.WriteLine(arrString[i]);
            }
        }
    }
}

