using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_Objects
{
    public class Card
    {
        // onstructor values assigned to an object upon creation
        public Card()
        {
            Suit = "Spades"; //  Constructor method name is always the name of the class
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
