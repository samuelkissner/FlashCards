using System;
using System.Collections;

namespace FlashCards
{
    class Program
    {
        static void Main(string[] args)
        {
 
            CardPile flashCards = new CardPile();
            flashCards.CreateDefaultCardPile();
            Card currentCard;


            while (true)
            {
                Console.Clear();
                currentCard = flashCards.getRandomCard();

                if(currentCard == null)
                {
                    Console.WriteLine("The Card Pile is Empty.");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine(currentCard.Concept);
                Console.ReadLine();
                Console.WriteLine(currentCard.Description);
                Console.ReadLine();

                string userInput = "";
                Console.WriteLine("Discard current card? \"y\" or \"n\"");
                while (true)
                {
                    
                    userInput = Console.In.ReadLine();
                    if (userInput == "y" || userInput == "n")
                        break;
                    else
                        Console.WriteLine("please enter either \"y\" or \"n\"");
                }
                
                if (userInput == "y")
                    flashCards.discardCard(currentCard);
            }
        }
    }
}
