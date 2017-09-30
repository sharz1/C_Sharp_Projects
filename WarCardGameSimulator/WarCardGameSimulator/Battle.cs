using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameSimulator
{
    public class Battle
    {
        public Card Card1 { get; set; }
        public Card Card2 { get; set; }
        public int Index { get; set; }
        public List<Card> Wincards { get; set; }
        public Player Winner { get; set; }

        public Battle()
        {
            Index = 0;
        }

        public void PlayBattle(Player player1, Player player2)
        {
            Card1 = player1.Hand[Index];
            Card2 = player2.Hand[Index];

            if (Card1.Value == Card2.Value)
            {
                // bonus battle (move to index 2 (or1) --only if they have enough cards
                // if last card left in one player's hand is same in battle, player with most cards wins
                if (Index + 2 < player1.Hand.Count && Index + 2 < player2.Hand.Count)
                {
                    Index += 2;
                    PlayBattle(player1, player2);
                }
                else if (Index + 1 < player1.Hand.Count && Index + 1 < player2.Hand.Count)
                {
                    Index += 1;
                    PlayBattle(player1, player2);
                }
                else if (player1.Hand.Count > player2.Hand.Count) MoveCards(player1, player2);
                else MoveCards(player2, player1);


            }
            else if (Card1.Value > Card2.Value) MoveCards(player1, player2);
            else MoveCards(player2, player1);

            
        }
        public void MoveCards(Player winner, Player loser)
        {
            //Set battle property Winner to "winner" parameter
            Winner = winner;
            //move all wincards to bottom of winner's hand
            Wincards = (winner.Hand.GetRange(0, Index + 1));
            Wincards.AddRange(loser.Hand.GetRange(0, Index + 1));
            winner.Hand.RemoveRange(0, Index + 1);
            loser.Hand.RemoveRange(0, Index + 1);

            winner.Hand.AddRange(Wincards);
        }
    }
}