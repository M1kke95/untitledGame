using System;
using System.Collections.Generic;
using System.Text;
using untitledGame.Enums;

namespace untitledGame.Player
{
    internal class Player
    {
        public PlayerStats Stats { get; private set; }
        public PlayerInventory Inventory { get; private set; }

        private CharacterState currentState;

        public Player()
        {
            Stats = new PlayerStats
            {
                Health = 100.0f,
                Stamina = 100.0f,
                AttackPower = 10.0f,
                Defense = 5.0f
            };

            currentState = CharacterState.Idle;

        }

        void update() { }

        void updateState(CharacterState newState)
        {
            currentState = newState;
        }

        private void MoveCharacter() { }

        private void UpdateInventory() { }

        private void UseItem() { }

        private void EquipItem() { }

        private void UnequipItem() { }

        private void InteractWithEnvironment() { }

        private void CraftItem() { }

        private void LevelUp() { }
        private void GainExperience(int amount) { }

        private void SaveGame() { }
        private void LoadGame() { }

        private void PerformAttack() { }

        private void MineResource() { }

        private void TalkToNPC() { }

        private void HandleDeath() { }
        private void RegenerateStamina() { }
        

    }
}
