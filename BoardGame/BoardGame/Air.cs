using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Air : ResourceType
    {
        public Air()
        {
            Color = Color.Green;
        }
        public override ResourceType Clone()
        {
            Air clone = new Air();
            clone.Color = this.Color;
            return clone;
        }

        internal override void Print()
        {
            Console.Write(Color);
        }
    }
}