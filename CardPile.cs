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
        public CardPile ()
        {
            Cards = new ArrayList();
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

        public void AddCardsToPile(string filePath)
        {

        }
        
        public void CreateDefaultCardPile()
        {
            Cards.Add(new Card("namespace", "container for a set of related classes and other namespaces (analagous to a package in Java)"));
            Cards.Add(new Card("Property", "Encapsulates a private field within a class. This private field can only be accessed from the getter and setter "));
            Cards.Add(new Card("C# Field", "A class-level variable that holds a value. Generally, it has the 'private' access modifier keyword applied to it."));
            Cards.Add(new Card("Literal Keywords", "keywords that apply to the current instance or value of an object. They include null, false, true, value, and void."));
            Cards.Add(new Card("Access Keywords", "keywords used to access the containing class or the base class of an object or class. They include this and base."));

        }
    }
}
