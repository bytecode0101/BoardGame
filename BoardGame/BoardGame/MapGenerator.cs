using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class MapGenerator
    {
        static Random random;
        static List<ResourceType> availableResources;

        static MapGenerator()
        {
            availableResources = new List<ResourceType>();
            random = new Random(availableResources.Count);

            availableResources.Add(new Water());
            availableResources.Add(new Air());
            availableResources.Add(new Light());
            availableResources.Add(new Earth());
            availableResources.Add(new Life());
        }

        public static Tile[,] GenerateMap(int x, int y)
        {
            Tile[,] res = new Tile[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var r = random.Next(0, availableResources.Count - 1);
                    var tile = new Tile();
                    tile.Element = new Resource()
                    {
                        ResourceType = availableResources[r].Clone()
                    };
                    res[i, j] = tile;
                }
            }

            return res;
        }
    }
}
