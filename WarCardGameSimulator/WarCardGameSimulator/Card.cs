using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameSimulator
{
    public class Card
    {
        public string Name { get; set; }
        public string Face { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public int GetValueFromName()
        {
            int result;
            if (int.TryParse(Face, out result)) return result;
            else
            {
                if (Face == "J") return 11;
                else if (Face == "Q") return 12;
                else if (Face == "K") return 13;
                else if (Face == "A") return 14;
                else return 0;
            };

            
        }
    }

}