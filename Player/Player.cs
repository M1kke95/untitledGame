using System;
using System.Collections.Generic;
using System.Text;
using untitledGame.Enums;
using untitledGame.Items;

namespace untitledGame.Player
{
    internal class Player
    {
        public PlayerStats Stats { get; private set; }
        public PlayerInventory Inventory { get; private set; }

        private CharacterState currentState;

        private Weapon equippedWeapon;

        private Tool equippedTool;



        public Player()
        {
            Stats = new PlayerStats
            {
                Health = 100.0f,
                Stamina = 100.0f,
                AttackPower = 10.0f,
                Defense = 5.0f,
                Experience = 0.0f
                
            };
            PlayerInventory inventory = new PlayerInventory();
            currentState = CharacterState.Idle;
            equippedWeapon = new Weapon("Basic Sword", "A simple sword", 5f, 1, 10f);
            equippedTool = new Tool("Basic Axe", "A simple wooden axe", 6f, 1);

        }

        public void update()
        {
            switch (currentState)
            {
                case CharacterState.Idle:
                    RegenerateStamina();
                    break;
                case CharacterState.Moving:
                    MoveCharacter();
                    break;
                case CharacterState.Attacking:
                    PerformAttack();
                    break;
                case CharacterState.Mining:
                    MineResource();
                    break;
                // Add other states as needed
                default:
                    break;
            }

            currentState = CharacterState.Idle; 
        }


        public void updateState(CharacterState newState)
        {
            currentState = newState;
        }

        private void MoveCharacter()
        {
            Console.WriteLine("Player is moving");
            
        }

        private void UpdateInventory(Player player) { }

        private void UseItem(/* item param*/) { }

        private void EquipItem(/* item param*/) { }

        private void UnequipItem(/* item param*/) { }

        private void Interact(/*interractable param npc, environment etc */) { }
        private void InteractWithEnvironment() { }

        private void CraftItem() { }

        private void LevelUp() { }
        private void GainExperience(int amount)
        {
            // experience += amount; if(experience + amount > 100) LevelUp() remainingXP = amount -100; if(remainingXP>0 experience = remainingXP; 
        }


        private void SaveGame() { }
        private void LoadGame() { }

        private void PerformAttack()
        {
            Console.WriteLine("Player is attacking");
            //use equippedWeapon to deal damage
        }

        private void MineResource(/*Tool param + resource param*/)
        {
            Console.WriteLine("Player is mining");
            //use equippedTool to mine resource
        }


        private void TalkToNPC(/*npc param*/) { }

        private void HandleDeath() { }
        private void RegenerateStamina() {
            Console.WriteLine("Player is regenerating stamina");
        }

        

    }
}
