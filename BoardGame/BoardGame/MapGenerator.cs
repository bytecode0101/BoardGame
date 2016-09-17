using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class MapGenerator
    {
        public static Tile[,] GenerateMap(int x, int y)
        {
            Tile[,] res = new Tile[x,y];

            List<ResourceType> availableResources = new List<ResourceType>();

            availableResources.Add(new Water());
            availableResources.Add(new Air());
            availableResources.Add(new Light());
            availableResources.Add(new Earth());
            availableResources.Add(new Life());


            Random random = new Random(5);

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
