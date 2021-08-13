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
            while (true)
            {
                Card currentCard = flashCards.getRandomCard();
                if (currentCard==null)
                    return;
                
                DisplayCurrentCard(currentCard);

                string userInput = UserPrompts.askToDiscard();
                if (userInput == "y")
                    flashCards.discardCard(currentCard);
            }
        }
        static void DisplayCurrentCard(Card currentCard)
        {
            Console.Clear();
            ConsoleDisplay.DisplayAndWait(currentCard.Concept);
            ConsoleDisplay.DisplayAndWait(currentCard.Description);
        }
    }
}
