﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Tile
    {
        private AbstractMapElement element;

        public AbstractMapElement Element
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
    }
}