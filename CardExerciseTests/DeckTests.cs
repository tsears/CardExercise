using CardExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardExerciseTests
{
    [TestClass]
    public class DeckTests
    {
        private List<Card> sampleOrderedDeck;

        [TestInitialize]
        public void Init()
        {
            this.sampleOrderedDeck = new List<Card>()
            {
                new Card(Suit.Club, Value.Ace),
                new Card(Suit.Club, Value.Two),
                new Card(Suit.Club, Value.Three),
                new Card(Suit.Club, Value.Four),
                new Card(Suit.Club, Value.Five),
                new Card(Suit.Club, Value.Six),
                new Card(Suit.Club, Value.Seven),
                new Card(Suit.Club, Value.Eight),
                new Card(Suit.Club, Value.Nine),
                new Card(Suit.Club, Value.Ten),
                new Card(Suit.Club, Value.Jack),
                new Card(Suit.Club, Value.Queen),
                new Card(Suit.Club, Value.King),
                new Card(Suit.Spade, Value.Ace),
                new Card(Suit.Spade, Value.Two),
                new Card(Suit.Spade, Value.Three),
                new Card(Suit.Spade, Value.Four),
                new Card(Suit.Spade, Value.Five),
                new Card(Suit.Spade, Value.Six),
                new Card(Suit.Spade, Value.Seven),
                new Card(Suit.Spade, Value.Eight),
                new Card(Suit.Spade, Value.Nine),
                new Card(Suit.Spade, Value.Ten),
                new Card(Suit.Spade, Value.Jack),
                new Card(Suit.Spade, Value.Queen),
                new Card(Suit.Spade, Value.King),
                new Card(Suit.Diamond, Value.Ace),
                new Card(Suit.Diamond, Value.Two),
                new Card(Suit.Diamond, Value.Three),
                new Card(Suit.Diamond, Value.Four),
                new Card(Suit.Diamond, Value.Five),
                new Card(Suit.Diamond, Value.Six),
                new Card(Suit.Diamond, Value.Seven),
                new Card(Suit.Diamond, Value.Eight),
                new Card(Suit.Diamond, Value.Nine),
                new Card(Suit.Diamond, Value.Ten),
                new Card(Suit.Diamond, Value.Jack),
                new Card(Suit.Diamond, Value.Queen),
                new Card(Suit.Diamond, Value.King),
                new Card(Suit.Heart, Value.Ace),
                new Card(Suit.Heart, Value.Two),
                new Card(Suit.Heart, Value.Three),
                new Card(Suit.Heart, Value.Four),
                new Card(Suit.Heart, Value.Five),
                new Card(Suit.Heart, Value.Six),
                new Card(Suit.Heart, Value.Seven),
                new Card(Suit.Heart, Value.Eight),
                new Card(Suit.Heart, Value.Nine),
                new Card(Suit.Heart, Value.Ten),
                new Card(Suit.Heart, Value.Jack),
                new Card(Suit.Heart, Value.Queen),
                new Card(Suit.Heart, Value.King)
            };
        }

        [TestMethod]
        public void GetsOrderedDeckByDefault()
        {
            var deck = DeckFactory.GetOrderedDeck();

            var sampleCardArray = this.sampleOrderedDeck.ToArray();
            var newDeckArray = deck.Cards.ToArray();

            if (newDeckArray.Length != sampleCardArray.Length)
            {
                Assert.Fail("Incorrect deck size");
            }

            for (var i = 0; i < newDeckArray.Length; i++)
            {
                if (newDeckArray[i].Suit != sampleCardArray[i].Suit || newDeckArray[i].Value != sampleCardArray[i].Value)
                {
                    // fail if any card isn't identical between decks
                    Assert.Fail("Card Order Mismatch");
                }
            }
        }

        [TestMethod]
        public void CanGetShuffledDeck()
        {
            var shuffledDeck = DeckFactory.GetShuffledDeck();

            var sampleCardArray = this.sampleOrderedDeck.ToArray();
            var shuffledCardArray = shuffledDeck.Cards.ToArray();

            if (shuffledCardArray.Length != sampleCardArray.Length)
            {
                // something went wrong here...
                Assert.Fail("Incorrect deck size");
            }

            var isShuffled = false;

            for (var i = 0; i < shuffledCardArray.Length; i++)
            {
                if (shuffledCardArray[i].Suit != sampleCardArray[i].Suit || shuffledCardArray[i].Value != sampleCardArray[i].Value)
                {
                    // at least one card was in a different position.
                    isShuffled = true;
                    break;
                }
            }

            if (!isShuffled)
            {
                Assert.Fail("Deck not shuffled!");
            }
        }

        [TestMethod]
        public void CanSortDeck()
        {
            var deckOptions = new DeckOptions();

            var sortedCards = DeckFactory.GetOrderedDeck().Cards.ToArray();
            var shuffledDeck = DeckFactory.GetShuffledDeck();
            shuffledDeck.Sort();
            var shuffledSortedCards = shuffledDeck.Cards.ToArray();

            if (sortedCards.Length != shuffledSortedCards.Length)
            {
                Assert.Fail("Incorrect deck size");
            }

            for (var i = 0; i < shuffledSortedCards.Length; i++)
            {
                if (sortedCards[i].Suit != shuffledSortedCards[i].Suit || sortedCards[i].Value != shuffledSortedCards[i].Value)
                {
                    // fail if any card isn't identical between decks
                    Assert.Fail("Card Order Mismatch");
                }
            }


        }
    }
}

