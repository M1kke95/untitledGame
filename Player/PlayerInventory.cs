using System;
using System.Collections.Generic;
using System.Text;

namespace untitledGame.Player
{
    internal class PlayerInventory
    {

        private List<string> inventory = new List<string>(16);


        public void addItemToInventory(string item)
        {
            inventory.Add(item);
        }

        public void removeItemFromInventory(string item)
        {
            inventory.Remove(item);
        }

        public void printInventory()
        {
            foreach (string item in inventory)
            {
                Console.WriteLine(item);
            }
        }

        public List<string> getInventory()
        {
            return new List<string>(inventory);
        }
    }
}
