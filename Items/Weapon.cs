using System;
using System.Collections.Generic;
using System.Text;

namespace untitledGame.Items
{
    public class Weapon : Items
    {
        public float AttackPower { get; private set; }

        public Weapon(string name, string description, float weight, int maxStackSize, float attackPower)
            : base(name, description, weight, maxStackSize)
        {
            AttackPower = attackPower;
        }
    }
}