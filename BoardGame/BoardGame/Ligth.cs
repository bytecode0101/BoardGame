﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Light : ResourceType
    {
        public Light()
        {
            Color = Color.Yellow;
        }
        public override ResourceType Clone()
        {
            Light clone = new Light();
            clone.Color = this.Color;
            return clone;
        }

        internal override void Print()
        {
            Console.Write(Color);
        }
    }

}