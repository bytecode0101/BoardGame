using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Tile
    {
        private Resource element;

        public Resource Element
        {
            get
            {
                return element;
            }

            set
            {
                element = value;
            }
        }

        internal void Print()
        {
            Element.Print();
        }
    }
}