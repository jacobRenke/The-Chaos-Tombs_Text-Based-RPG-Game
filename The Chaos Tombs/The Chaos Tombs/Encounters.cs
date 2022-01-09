using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Chaos_Tombs
{
    class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic


        //Encounter 
        public static void FirstEnounter()
        {
            Console.WriteLine("You look around frantically look around for something to wield as a weapon.\n Conveniently, there is a large steel sword next to the doorway.");
            Console.WriteLine("The *thing* you have awoken gets louder and louder. Snarling like a rabid dog but moving at the speed of a cheetah.");
            Console.ReadKey();
        }

        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health)  //this determines who is in the encounter
        {
            string n = ""; //name
            int p = 0; //power
            int h = 0; //health 
            if(random)
            {
                
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }

            while (h > 0)
            {
                Console.WriteLine(" ||==================||");
                Console.WriteLine("|| (A)ttack  (D)efend ||");
                Console.WriteLine("||                    ||");
                Console.WriteLine("||  (R)un     (H)eal  ||");
                Console.WriteLine(" ||==================||");
                Console.WriteLine("    Potions: " + Program.currentPlayer.healthPotion + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack - maybe update this with multiple weapons.
                    //Sword Attack
                    Console.WriteLine("You thrust forward, sword in hand! The "+n+" strikes back at you!");
                    int damage = p - Program.currentPlayer.armorValue;
                    //Attack damage is equal to a random number between 0 and weapon value, plus a random number between 0-3.
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + "health and deal " + attack + " damage.");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("You thrust forward, sword in hand! The " + n + " strikes back at you!");
                    int damage = p - Program.currentPlayer.armorValue;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + "health and deal " + attack + " damage.");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                }
                else
                {
                    Console.WriteLine("Try again, peasant.");
                }
                Console.ReadKey();
            }
        }
    }
}
