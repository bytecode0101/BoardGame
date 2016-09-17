using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Air : ResourceType
    {
        public override ResourceType Clone()
        {
            Air clone = new Air();
            clone.Color = this.Color;
            return clone;
        }
    }
}