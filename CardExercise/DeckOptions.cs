using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardExercise
{
    public class DeckOptions {
       
        // default suit order
        private List<Suit> suitOrder = new List<Suit> {
            Suit.Club,
            Suit.Spade,
            Suit.Diamond,
            Suit.Heart
        }; 

        // default Card Order
        private List<Value> cardOrder = new List<Value> {
                Value.Ace,
                Value.Two,
                Value.Three,
                Value.Four,
                Value.Five,
                Value.Six,
                Value.Seven,
                Value.Eight,
                Value.Nine,
                Value.Ten,
                Value.Jack,
                Value.Queen,
                Value.King
            };

        public List<Value> CardOrder
        {
            get
            {
                return cardOrder;
            }

            set
            {
                // validate all cards are present
                if (value.Count < 13)
                {
                    throw new ArgumentException("Expected all 13 Values");
                }

                if (value.Distinct().Count() < 13 )
                {
                    throw new ArgumentException("Duplicate Values are not allowed.");
                }

                cardOrder = value;
            }
        }

        public List<Suit> SuitOrder
        {
            get
            {
                return suitOrder;
            }

            set
            {
                // validate all suits are present
                if (value.Count < 4)
                {
                    throw new ArgumentException("Expected 4 Suits");
                }

                if (value.Distinct().Count() < 4)
                {
                    throw new ArgumentException("Duplicate Suits are not allowed.");
                }

                suitOrder = value;
            }
        }

        public bool Sorted
        {
            get { return sorted; }
            set { sorted = value; }
        }

        private bool sorted = true;
        
    }
}
