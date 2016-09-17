using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Game
    {
        private Map map;
        private List<Pawn> pawns;

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

        public List<Pawn> Pawns
        {
            get
            {
                return pawns;
            }

            set
            {
                pawns = value;
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

            Pawns = new List<Pawn>();
            var p1 = new Pawn(0, 0, "A");
            var p2 = new Pawn(Map.Height - 1, Map.Width - 1, "B");
            Pawns.Add(p1);
            Pawns.Add(p2);
            PrintPawns();
        }

        private void PrintPawns()
        {
            foreach (var p in Pawns)
            {
                p.Print();
            }
        }
    }
}