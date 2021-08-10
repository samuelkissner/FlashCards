using System;
using System.Collections.Generic;
using System.Text;

namespace FlashCards
{
    class Card
    {
        public string Concept { get; set; }  //front of the card
        public string Description { get; set; } //back of the card

        public Card(string concept, string description)
        {
            this.Concept = concept;
            this.Description = description;
        }
        
    }
}
