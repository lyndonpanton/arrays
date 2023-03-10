using System;
using ConsoleCards;

namespace Exercise11
{
    /// <summary>
    /// Exercise 11
    /// </summary>
    class Program
    {
        /// <summary>
        /// Exercise 11
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // problem 1
            Deck deck = new Deck();
            Card[] cards = new Card[5];

            deck.Shuffle();

            // problem 2
            Card topCardOfDeck = deck.TakeTopCard();

            cards[0] = topCardOfDeck;
            cards[0].FlipOver();

            cards[0].Print();

            // problem 3
            Card secondCardFromTopOfDeck = deck.TakeTopCard();

            cards[1] = secondCardFromTopOfDeck;
            cards[1].FlipOver();

            Console.WriteLine();
            cards[0].Print();
            cards[1].Print();
        }
    }
}
