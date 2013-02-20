using System;

    class SumOfNumberisInArrayOfIntegers
    {
        static void Main()
        {
            string numbers = "44 68 987 43 5 1 9 90";
            string[] arrStringNumbers = numbers.Split(' ');
            int sum = 0;
            for (int i = 0; i < arrStringNumbers.Length; i++)
			{
                sum += int.Parse(arrStringNumbers[i]);
			}
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

