using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FlashCards
{
    class CardPile
    {
        //fields/properties
        public ArrayList Cards { get; set; }
        private Random random; 

        
        //constructor
        public CardPile (string filePath)
        {
            Cards = AddCardsToPile(filePath);
            random = new Random(); 
        }

        //methods
        public Card getRandomCard()
        {
            if (Cards.Count == 0)
                return null;

            int randomNumber = random.Next(0, Cards.Count - 1);
            Card randomCard = (Card)Cards[randomNumber];
            return randomCard;
        }

        public void discardCard(Card currentCard)
        {
            Cards.Remove(currentCard);
        }

        public ArrayList AddCardsToPile(string filePath)
        {
            CSVParser csvParser = new CSVParser(filePath);      
            return csvParser.AddCSVRecordsToArrayList();
        }
    }
}
