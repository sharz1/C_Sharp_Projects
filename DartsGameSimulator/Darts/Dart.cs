using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Wedge { get; set; }
        public int Band { get; set; }

        private Random _random;

        public Dart(Random random)
        {
            _random = random;
        }



        public void Throw()
        {
            Wedge = _random.Next(21);
            Band = _random.Next(20);
        }

    }
}
