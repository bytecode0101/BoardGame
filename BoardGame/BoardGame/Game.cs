using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Game
    {
        private Map map;

        public Map Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }

        public void Run()
        {
            LoadGame();
        }

        private void LoadGame()
        {
            Map = new Map();
            Map.Width = 10;
            Map.Height = 10;
            Map.Tiles = MapGenerator.GenerateMap(Map.Width, Map.Height);
        }
    }
}