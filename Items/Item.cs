using System;
using System.Collections.Generic;
using System.Text;

namespace untitledGame.Items
{
    public abstract class Items
    {
        public String Name { get; private set; }
        public String Description { get; private set; }
        public float Weight { get; private set; }
        public float Durability { get; private set; }
        public int MaxStackSize { get; private set; }


        protected Items(string name, string description, float weight, float durability, int maxStackSize)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Durability = durability;
            MaxStackSize = maxStackSize;
        }
    }

}
