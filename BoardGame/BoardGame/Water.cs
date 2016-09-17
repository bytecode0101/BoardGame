using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Water : ResourceType
    {
        public Water()
        {
            Color = Color.Blue;
        }
        public override ResourceType Clone()
        {
            Water clone = new Water();
            clone.Color = this.Color;
            return clone;
        }

        internal override void Print()
        {
            Console.Write(Color);
        }
    }
}