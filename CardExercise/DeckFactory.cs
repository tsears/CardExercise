using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardExercise
{
    public class DeckFactory
    {
        public static Deck GetOrderedDeck()
        {
            return GetOrderedDeck(new DeckOptions());
        }

        public static Deck GetOrderedDeck(DeckOptions options)
        {
            return new Deck(options);
        }

        public static Deck GetShuffledDeck()
        {
            return GetShuffledDeck(new DeckOptions() { Sorted = false });
        }

        public static Deck GetShuffledDeck(DeckOptions options)
        {
            return new Deck(options);
        }
    }
}
