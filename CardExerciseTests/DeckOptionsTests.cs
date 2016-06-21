using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardExercise;
using System.Collections.Generic;

namespace CardExerciseTests
{
    [TestClass]
    public class DeckOptionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsIfSuitMissing()
        {
            var deckOptions = new DeckOptions();

            deckOptions.SuitOrder = new List<Suit> { Suit.Club, Suit.Diamond, Suit.Heart };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsIfCardMissing()
        {
            var deckOptions = new DeckOptions();

            deckOptions.CardOrder = new List<Value> {
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
                };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsIfSuitDuplicated()
        {
            var deckOptions = new DeckOptions();

            deckOptions.SuitOrder = new List<Suit> { Suit.Club, Suit.Club, Suit.Diamond, Suit.Heart };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsIfCardDuplicated()
        {
            var deckOptions = new DeckOptions();

            deckOptions.CardOrder = new List<Value> {
                Value.Ace,
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
            };
        }
    }
}
