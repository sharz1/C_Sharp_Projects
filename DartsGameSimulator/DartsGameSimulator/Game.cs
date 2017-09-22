using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DartsGameSimulator
{
    public class Game
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        Dart dart1 = new Dart();
        Dart dart2 = new Dart();
        Dart dart3 = new Dart();

        public void PlayRound()
        {
            ThrowDarts();
            Player1Score += Score.HitScore(dart1.Wedge,dart1.Band) 
                    + Score.HitScore(dart2.Wedge,dart2.Band)
                    + Score.HitScore(dart3.Wedge, dart3.Band);

            ThrowDarts();
            Player2Score += Score.HitScore(dart1.Wedge, dart1.Band)
                    + Score.HitScore(dart2.Wedge, dart2.Band)
                    + Score.HitScore(dart3.Wedge, dart3.Band);

        }
        private void ThrowDarts()
        {
            dart1.Throw();
            dart2.Throw();
            dart3.Throw();
        }
        
    }
}