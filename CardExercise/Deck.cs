using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardExercise
{
    public class Deck
    {
        public List<Card> Cards { get { return cards; }}
        private List<Card> cards;

        private DeckOptions deckOptions;

        internal Deck()
        {
            this.deckOptions = new DeckOptions();
            this.initializeDeck();
        }

        internal Deck(DeckOptions options)
        {
            this.deckOptions = options;
            this.initializeDeck();
        }

        private void initializeDeck()
        {
            buildOrderedDeck();

            if (!deckOptions.Sorted)
            {
                this.Shuffle();
            }
        }

        // gets a full deck according to the current sorting rules (in deck options)
        private void buildOrderedDeck()
        {
            this.cards = new List<Card>();

            foreach (var suit in deckOptions.SuitOrder)
            {
                foreach (var value in deckOptions.CardOrder)
                {
                    this.cards.Add(new Card(suit, value));
                }
            }
        }

        public Card DrawCard()
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            // this will shuffle whatever cards are present...
            var currentCards = this.cards;
            this.cards = new List<Card>();
            var initialCount = currentCards.Count;

            var random = new Random();

            for (var i = 0; i < initialCount; i++)
            {
                var randomCardIndex = random.Next(0, currentCards.Count - 1);
                var card = currentCards.ElementAt(randomCardIndex);
                this.cards.Add(card);
                currentCards.RemoveAt(randomCardIndex);
            }
        }
        
        public void Sort()
        {
            var suits = new Dictionary<Suit, IEnumerable<Card>>();
            suits.Add(Suit.Club, getOrderedSuit(Suit.Club));
            suits.Add(Suit.Spade, getOrderedSuit(Suit.Spade));
            suits.Add(Suit.Heart, getOrderedSuit(Suit.Heart));
            suits.Add(Suit.Diamond, getOrderedSuit(Suit.Diamond));

            var sortedCards = new List<Card>();

            foreach(var suit in deckOptions.SuitOrder)
            {
                var sortedSuitCards = suits[suit];
                sortedCards.AddRange(sortedSuitCards);
            }

            this.cards = sortedCards;
        }

        private IEnumerable<Card> getOrderedSuit(Suit suit)
        {
            return Cards.Where(c => c.Suit == suit).OrderBy(c => deckOptions.CardOrder.IndexOf(c.Value));
        }

    }
}
