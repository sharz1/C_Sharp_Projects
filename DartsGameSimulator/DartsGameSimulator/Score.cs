using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DartsGameSimulator
{
    public class Score
    {
        public static int HitScore(int Wedge, int Band)
        {
            //If dart hits bullseye area (Wedge:0), check if outer or inner bullseye
            if (Wedge == 0)
            {
                if (Band == 0) return 50;
                else return 25;
            }
            //If dart hits any other wedge, check for double or triple band
            else if (Band == 2 || Band == 3) return Wedge * Band;
         
            //If band is not double or triple, return Wedge # as points
            else return Wedge;
        }
    }
}