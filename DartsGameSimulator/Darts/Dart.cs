using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        Random random = new Random();

        public int Wedge { get; set; }
        public int Band { get; set; }

        public void Throw()
        {
            Wedge = random.Next(21);
            Band = random.Next(20);
        }

    }
}
