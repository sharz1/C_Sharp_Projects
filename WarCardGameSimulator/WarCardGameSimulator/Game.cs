using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameSimulator
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public List<Card> CardDeck { get; set; }
        public Player Winner { get; set; }

        public Game()
        {
            Random random = new Random();

            
            //Create deck of cards collection and set values
            string[] suits = new string[] { "D", "S", "H", "C" };
            string[] faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            CardDeck = new List<Card>();

            foreach (string suit in suits)
            {
                foreach(string face in faces)
                {
                    CardDeck.Add(new Card { Name = suit + face, Face = face, Suit = suit});
                }
            }
            foreach (Card card in CardDeck) card.Value = card.GetValueFromName();
            /*
            CardDeck = new List<Card>
            {
                new Card { Name="D2" }, new Card { Name = "D3" }, new Card { Name = "D4" },
                new Card { Name="D5" }, new Card { Name = "D6" }, new Card { Name = "D7" },
                new Card { Name="D8" }, new Card { Name = "D9" }, new Card { Name = "D10" },
                new Card { Name="DJ" }, new Card { Name = "DQ" }, new Card { Name = "DK" },
                new Card { Name = "DA" },
                new Card { Name="S2" }, new Card { Name = "S3" }, new Card { Name = "S4" },
                new Card { Name="S5" }, new Card { Name = "S6" }, new Card { Name = "S7" },
                new Card { Name="S8" }, new Card { Name = "S9" }, new Card { Name = "S10" },
                new Card { Name="SJ" }, new Card { Name = "SQ" }, new Card { Name = "SK" },
                new Card { Name = "SA" },
                new Card { Name="H2" }, new Card { Name = "H3" }, new Card { Name = "H4" },
                new Card { Name="H5" }, new Card { Name = "H6" }, new Card { Name = "H7" },
                new Card { Name="H8" }, new Card { Name = "H9" }, new Card { Name = "H10" },
                new Card { Name="HJ" }, new Card { Name = "HQ" }, new Card { Name = "HK" },
                new Card { Name = "HA" },
                new Card { Name="C2" }, new Card { Name = "C3" }, new Card { Name = "C4" },
                new Card { Name="C5" }, new Card { Name = "C6" }, new Card { Name = "C7" },
                new Card { Name="C8" }, new Card { Name = "C9" }, new Card { Name = "C10" },
                new Card { Name="CJ" }, new Card { Name = "CQ" }, new Card { Name = "CK" },
                new Card { Name = "CA" },
            };
            foreach (Card card in CardDeck) card.Value = card.GetValueFromName();
            */

        }
        public void DealtoPlayers(Random random)
        {
            //Shuffle and Deal cards (half to each player)
            while (CardDeck.Count > 0)
            {
                Player1.Dealtome(random, CardDeck);
                /*
                int randomcard = random.Next(carddeck.Count);
                player1.Hand.Add(carddeck.ElementAt(randomcard));
                carddeck.Remove(carddeck.ElementAt(randomcard));
                */
                Player2.Dealtome(random, CardDeck);
                /*
                randomcard = random.Next(carddeck.Count);
                player2.Hand.Add(carddeck.ElementAt(randomcard));
                carddeck.Remove(carddeck.ElementAt(randomcard));
                */
            }
        }

    }
}