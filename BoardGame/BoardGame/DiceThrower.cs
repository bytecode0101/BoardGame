using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class DiceThrower
    {
        List<Dice> dices = new List<Dice>();

        public DiceThrower()
        {
            dices.Add(new Dice());
            dices.Add(new Dice());
        }

        public int[] ThrowDices()
        {
            var res = new int[dices.Count];
            for (int i = 0; i < dices.Count; i++)
            {
                res[i] = dices[i].Throw();
            }

            return res;
        }
    }
}