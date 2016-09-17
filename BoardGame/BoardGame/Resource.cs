using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class Resource : AbstractMapElement
    {
        private ResourceType resourceType;

        public ResourceType ResourceType
        {
            get
            {
                return resourceType;
            }

            set
            {
                resourceType = value;
            }
        }

        internal override void Print()
        {
            ResourceType.Print();
        }
    }
}