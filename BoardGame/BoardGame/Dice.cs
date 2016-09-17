using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Dice
    {
        static Random random = new Random(6);

        public int Throw()
        {
            int res = 0;

            List<int> facets = new List<int>();
            facets.Add(1);
            facets.Add(2);
            facets.Add(3);
            facets.Add(4);
            facets.Add(5);
            facets.Add(6);

            var r = random.Next(0, facets.Count - 1);
            res = facets[r];

            return res;
        }
    }
}