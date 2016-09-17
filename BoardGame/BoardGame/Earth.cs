using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Earth : ResourceType
    {
        public Earth()
        {
            Color = Color.Grey;
        }
        public override ResourceType Clone()
        {
            Earth clone = new Earth();
            clone.Color = this.Color;
            return clone;
        }

        internal override void Print()
        {
            Console.Write(Color);
        }
    }
}