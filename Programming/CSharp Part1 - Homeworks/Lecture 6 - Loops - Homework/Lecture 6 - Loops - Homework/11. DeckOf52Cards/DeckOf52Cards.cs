using System;

class DeckOf52Cards
{
    static void Main()
    {
        string[] cards = { "Clubs", "Diamonds", "Hearts", "Spades" };
        string[] cardsIndex = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        foreach (string i in cards)
        {
            foreach (string k in cardsIndex)
            {
                Console.WriteLine(k + " " + i);
            }
        }
    }
}

