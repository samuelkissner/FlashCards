using System;
using Microsoft.VisualBasic.FileIO;
using System.Collections;

namespace FlashCards
{
    class Program
    {
        static void Main(string[] args)
        {

            CardPile flashCards = new CardPile();

            var path = @"C:\Software Engineering\Personal Projects\Repos\FlashCards\FlashCards_C#.csv";
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    string concept= fields[0];
                    string description = fields[1];
                    flashCards.Cards.Add(new Card(concept, description));
                }
            }

            Card currentCard;


            while (true)
            {
                Console.Clear();
                currentCard = flashCards.getRandomCard();

                if(currentCard == null)
                {
                    ConsoleDisplay.DisplayAndWait("The Card Pile is Empty.");
                    break;
                }
                
                ConsoleDisplay.DisplayAndWait(currentCard.Concept);
                ConsoleDisplay.DisplayAndWait(currentCard.Description);
          

                string userInput = UserPrompts.askToDiscard();
                if (userInput == "y")
                    flashCards.discardCard(currentCard);
            }
        }
    }
}
