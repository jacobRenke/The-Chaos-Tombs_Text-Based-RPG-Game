using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Chaos_Tombs
{
    public class Player
    {
        Random rand = new Random();
        public string name { get; set; }
        public string tempName;
        public double coins = 500;
        public int health = 10;
        public int damage = 1;
        public int armorValue = 0;
        public int healthPotion = 5;
        public int weaponValue = 1;

        public int mods = 0;

        //adding a 'power' method that will calculate how much damage, armor, etc the player has based off of item aquired
        public int DetermineStamina()
        {
            //setting a range for this method to randomly decide, using mod weights
            int upper = (2 * mods + 5);
            int lower = (mods + 2);
            return rand.Next(lower, upper);
        }

        public int DetermineStrength()
        {
            //setting a range for this method to randomly decide, using mod weights
            int upper = (2 * mods + 3);
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }

        public int GetCoins()
        {
            int upper = (15 * mods + 50);
            int lower = (10 * mods + 10);
            return rand.Next(lower, upper);
        }
    }
}
