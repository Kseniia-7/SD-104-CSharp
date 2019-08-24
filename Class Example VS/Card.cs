using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example_VS
{
    class Card
    {
        //card data
        string rank;
        string suit;
        int val;

        /// <summary>
        /// Creates a card object with the given card rank and suit.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suit">Use ASCII char for club, spade, heart, or diamond</param>
        public Card(string rank, string suit, int val)
        {
            this.rank = rank;
            this.suit = suit;
        }
            public override string ToString()
        {
            return rank + " " + suit;
        }
    
    }
}
