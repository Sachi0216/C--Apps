using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_Objects
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            // Nested forloop
            foreach (string Face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = Face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
