using System;
using System.Collections.Generic;
using System.Text;

namespace untitledGame.Items
{
    public class Tool : Item
    {
        //might add specific properties for tools later, like mining speed and tier. keeping it simple for now.
        public Tool(string name, string description, float weight, int maxStackSize)
            : base(name, description, weight, maxStackSize)
        {

        }

        public void UseTool()
        {
            DurabilityDecrease(1.0f); 
        }
    }
}
