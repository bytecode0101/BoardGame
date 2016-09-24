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
        private DiceThrower diceThrower;

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

        public DiceThrower DiceThrower
        {
            get
            {
                return diceThrower;
            }

            set
            {
                diceThrower = value;
            }
        }

        public void Run()
        {
            LoadGame();
            PrintMap();

            Play();
        }

        private void Play()
        {
            Console.WriteLine("Press ENTER to throw dice");
            Console.ReadLine();
            Console.Clear();


            Pawns[0].Move(3, 4);
            Pawns[0].CollectResource(Map.Tiles[3,4].Element);


            Pawns[1].Move(4, 5);
            Pawns[1].CollectResource(Map.Tiles[4, 5].Element);


            PrintMap();
            
          var dt =  DiceThrower.ThrowDices();
        }

        private void PrintMap()
        {
            Map.Print();
            PrintPawns();
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

            DiceThrower = new DiceThrower();
           

        }

        private void PrintPawns()
        {
            foreach (var p in Pawns)
            {
                p.Print();
                Console.WriteLine();
            }
        }
    }
}