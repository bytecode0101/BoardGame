using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Pawn : AbstractMapElement
    {
       
        private string name;
        private List<Resource> resources;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Resource> Resources
        {
            get
            {
                return resources;
            }

            set
            {
                resources = value;
            }
        }

        internal void CollectResource(Resource resource1, object resource2, Pawn pawn, Pawn p2)
        {
            throw new NotImplementedException();
        }

        internal void CollectResource(Resource resource1, object resource2)
        {
            throw new NotImplementedException();
        }

        public Pawn(int v1, int v2, string v3)
        {
            Location = new Point();
            Location.X = v1;
            Location.Y = v2;
            Name = v3;
            Resources = new List<Resource>();
        }

        internal override void Print()
        {
            Console.WriteLine("Pawn: " + Name);
            Location.Print();
            Console.Write("Resources: ");
            foreach (var resource in Resources)
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
            Resources.Add(resource);
        }

        public void Attack(string opponentName)
        {
            Console.WriteLine("{0} attacks {1}" , Name, opponentName );
        }
       

    }
}