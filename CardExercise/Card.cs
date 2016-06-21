using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardExercise
{
    public class Card
    {
        public Suit Suit { get; }
        public Value Value { get; }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
