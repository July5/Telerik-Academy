using System;

class ApplyingBonusScoreToGivenScore
{
    static void Main()
    {
        Console.Write("Enter given score in the range [1..9]: ");
        short score = short.Parse(Console.ReadLine());
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                score *= 10;
                Console.WriteLine("The final score is: {0}", score);
                break;
            case 4:
            case 5:
            case 6:
                score *= 100;
                Console.WriteLine("The final score is: {0}", score);
                break;
            case 7:
            case 8:
            case 9:
                score *= 1000;
                Console.WriteLine("The final score is: {0}", score);
                break;
            case 0:
            default:
                Console.WriteLine("The input score is invalid!");
                break;
        }
    }
}

