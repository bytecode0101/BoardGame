using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Map
    {
        private Tile[,] tiles;
        private int width;
        private int height;

        public Tile[,] Tiles
        {
            get
            {
                return tiles;
            }

            set
            {
                tiles = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
    }
}