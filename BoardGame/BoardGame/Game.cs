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
            PrintMap();
        }

        private void PrintMap()
        {
            Map.Print();
        }

        private void LoadGame()
        {
            Map = new Map();
            Map.Width = 10;
            Map.Height = 10;
            Map.Tiles = MapGenerator.GenerateMap(Map.Width, Map.Height);


           var p1 = new Pawn(0, 0, "A");
           var t1 = new Tile();
            t1.Element = p1;
            Map.Tiles[0, 0] = t1;

            var p2 = new Pawn(Map.Height - 1, Map.Width - 1, "B");
            var t2= new Tile();
            t2.Element = p2;
            Map.Tiles[Map.Height - 1, Map.Width - 1] = t2;

        }
    }
}