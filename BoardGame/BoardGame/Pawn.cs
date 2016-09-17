using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Pawn : AbstractMapElement
    {
       
        private string name;

        public Pawn(int v1, int v2, string v3)
        {
            Location = new Point();
            Location.X = v1;
            Location.Y = v2;
            name = v3;
        }

        internal override void Print()
        {
            Console.Write(name);
        }
    }
}