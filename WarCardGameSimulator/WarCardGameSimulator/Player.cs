using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameSimulator
{
    public class Player
    {
        public string Name { get; set; }
        public int Seat { get; set; }
        public List<Card> Hand { get; set; }
        public int Score { get; set; }

        public void Dealtome(Random random, List<Card> deck)
        {
            int randomcard = random.Next(deck.Count);
            Hand.Add(deck.ElementAt(randomcard));
            deck.Remove(deck.ElementAt(randomcard));
        }
    }
}