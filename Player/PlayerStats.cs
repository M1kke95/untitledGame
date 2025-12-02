using System;
using System.Collections.Generic;
using System.Text;

namespace untitledGame.Player
{
    internal class PlayerStats
    {
        public float Health { get; set; }
        public float Stamina { get; set; }
        public float AttackPower { get; set; }
        public float Defense { get; set; }

        public float Experience { get; set; }

        //todo: add more stats as needed + Add a method to level up stats correctly based on experience

    }
}
