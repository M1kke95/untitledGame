using System;
using System.Collections.Generic;
using System.Text;

namespace untitledGame.Player
{
    internal class Player
    {
        public PlayerStats Stats { get; private set; }
    

       public Player()
        {
            Stats = new PlayerStats
            {
                Health = 100.0f,
                Stamina = 100.0f,
                AttackPower = 10.0f,
                Defense = 5.0f
            };

        }
    }
}
