using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public abstract class AbstractMapElement
    {
        private Point location;

        public Point Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        internal abstract void Print();
        
    }
}