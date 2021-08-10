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
                    Console.WriteLine("The Card Pile is Empty!");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine(currentCard.Concept);
                Console.ReadLine();
                Console.WriteLine(currentCard.Description);
                Console.ReadLine();

                flashCards.discardCard(currentCard);
            }
        }
    }
}
