using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Chaos_Tombs
{
    class Encounters
    {
        //Encounter Generic


        //Encounter 
        public static void FirstEnounter()
        {
            Console.WriteLine("You look around frantically look around for something to wield as a weapon.\n Conveniently, there is a large steel sword next to the doorway.");
            Console.WriteLine("The *thing* you have awoken gets louder and louder. Snarling like a rabit dog but moving at the speed of a cheetah.");
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
                    //Attack                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
                }
                if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                }
                if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                }
                if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                }
            }
        }
    }
}
