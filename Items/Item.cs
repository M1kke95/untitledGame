using System;
using System.Collections.Generic;
using System.Text;

namespace untitledGame.Items
{
    public abstract class Item
    {
        public String Name { get; private set; }
        public String Description { get; private set; }
        public float Weight { get; private set; }
        public float Durability { get; private set; }
        public int MaxStackSize { get; private set; }


        protected Item(string name, string description, float weight, int maxStackSize)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Durability = 100;
            MaxStackSize = maxStackSize;
        }

        public void DurabilityDecrease(float amount = 1.0f)
        {
            Durability -= amount;
            if (Durability < 0f)
            {
                Durability = 0f;
            }
        }

        public void RepairTool(float repairAmount)
        {

            if(Durability < 100f)
            {
                Durability += repairAmount;
                if (Durability > 100.0f)
                {
                    Durability = 100.0f;
                }
               
            }
            //Might change later to not repair increments and instead fully repair
        }
    }


}
