using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Pawn : AbstractMapElement
    {
       
        private string name;
        private List<Resource> resources;
        

        public Pawn(int v1, int v2, string v3)
        {
            Location = new Point();
            Location.X = v1;
            Location.Y = v2;
            name = v3;
            resources = new List<Resource>();
        }

        internal override void Print()
        {
            Console.WriteLine("Pawn: " + name);
            Location.Print();
            Console.Write("Resources: ");
            foreach (var resource in resources)
            {
                resource.Print();
            }
            Console.WriteLine();
        }

        public void Move(int x, int y)
        {
            Location.X = x;
            Location.Y = y;
        }

        public void CollectResource(Resource resource)
        {
            resources.Add(resource);
        }
    }
}