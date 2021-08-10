using System;
using System.Collections;

namespace FlashCards
{
    class Program
    {
        static void Main(string[] args)
        {
 
            ArrayList flashCards = new ArrayList();
            flashCards.Add(new Card("namespace", "container for a set of related classes and other namespaces (analagous to a package in Java)"));
            flashCards.Add(new Card("Property", "Encapsulates a private field within a class. This private field can only be accessed from the getter and setter "));
            flashCards.Add(new Card("C# Field", "A class-level variable that holds a value. Generally, it has the 'private' access modifier keyword applied to it."));
            flashCards.Add(new Card("Literal Keywords", "keywords that apply to the current instance or value of an object. They include null, false, true, value, and void."));
            flashCards.Add(new Card("Access Keywords", "keywords used to access the containing class or the base class of an object or class. They include this and base."));

            Random random = new Random();
            Card currentCard;
            while (true)
            {
                Console.Clear();
                int randomNumber = random.Next(0, flashCards.Count - 1);
                currentCard = (Card) flashCards[randomNumber];

                Console.WriteLine(currentCard.Concept);
                Console.ReadLine();
                Console.WriteLine(currentCard.Description);
                Console.ReadLine();
            }
        }
    }
}
