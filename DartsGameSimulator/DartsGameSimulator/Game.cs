using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DartsGameSimulator
{
    public class Game
    {
        public Player _player1;
        public Player _player2;
        private Random _random;

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player { Name = player1Name };
            _player2 = new Player { Name = player2Name };

            _random = new Random();
        }
        public void PlayRound()
        {
            ThrowDarts(_player1);
            ThrowDarts(_player2);
        }
        private void ThrowDarts(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                player.Score += Score.HitScore(dart.Wedge, dart.Band);
            }
        }
        
    }
}