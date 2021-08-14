using System;

using System.Collections;

namespace FlashCards
{
    class Program
    {

        static void Main(string[] args)
        {
            CardPile flashCards = new CardPile(@"C:\Software Engineering\Personal Projects\Repos\FlashCards\FlashCards_C#.csv");
            CycleThroughCards(flashCards);
            ConsoleDisplay.DisplayAndWait("The Card Pile is Empty.");
        }

        static void CycleThroughCards(CardPile flashCards)
        {
            Card currentCard;
            while (true)
            {
                Console.Clear();
                currentCard = flashCards.getRandomCard();
                if (currentCard==null)
                    return;

                DisplayCardsRemaining(flashCards);
                DisplayCurrentCard(currentCard);

                string userInput = UserPrompts.askToDiscard();
                if (userInput == "y")
                    flashCards.discardCard(currentCard);
            }
        }

        static void DisplayCardsRemaining(CardPile flashCards)
        {
            Console.WriteLine($"({flashCards.Cards.Count} Remaining)");
            Console.WriteLine();
        }
        static void DisplayCurrentCard(Card currentCard)
        {
            ConsoleDisplay.DisplayAndWait(currentCard.Concept);
            ConsoleDisplay.DisplayAndWait(currentCard.Description);
        }

       
    }
}
