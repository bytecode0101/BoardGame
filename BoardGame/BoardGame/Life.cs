using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Life : ResourceType
    {
        public Life()
        {
            Color = Color.Red;
        }
        public override ResourceType Clone()
        {
            Life clone = new Life();
            clone.Color = this.Color;
            return clone;
        }

        internal override void Print()
        {
            Console.Write(Color);
        }
    }
}