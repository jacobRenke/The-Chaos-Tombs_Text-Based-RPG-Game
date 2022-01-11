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
            Console.WriteLine("You frantically look around for something to wield as a weapon.\n Conveniently, there is a large steel sword next to the doorway. You pick it up.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The *thing* you have awoken gets louder and louder...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Suddenly, some creature with charred skin, hollow eyes, and horns sticking out of it's back rushes you from the hallway! *queue battle music*");
            Console.ReadKey();
            Console.Clear();
            Combat(false, "Imp of Chaos", 1, 4);
        }

        public static void BasicEncounter()
        {
            Console.Clear();
            Console.WriteLine("You hear the snarls of another monster in the distant...ready yourself...");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }

        //Add 2-3 more encounter types here! 

        //Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 4))
            {
                case 0: BasicEncounter();
                    break;
                case 1: //Add more encounters
                    break;
                case 2: //Add more encounters
                    break;
                case 3: //Add more encounters
                    break;
                case 4: //Add more encounters
                    break;
            }
        }
        public static void Combat(bool random, string name, int power, int health)  //this determines who is in the encounter
        {
            string n = ""; //name
            int p = 0; //power
            int h = 0; //health 
            if(random)
            {
                n = GetName();
                p = rand.Next(1, 8);
                h = rand.Next(1, 8);
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }

            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(" ---"+n+"---");
                Console.WriteLine("   "+ p + " Power / " + h + " Health");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("        "+Program.currentPlayer.name);
                Console.WriteLine(" ||==================||");
                Console.WriteLine("|| (A)ttack  (D)efend ||");
                Console.WriteLine("||                    ||");
                Console.WriteLine("||  (R)un     (H)eal  ||");
                Console.WriteLine(" ||==================||");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("   Potions: " + Program.currentPlayer.healthPotion + " Health: " + Program.currentPlayer.health);
                Console.WriteLine("   Choose an action!");
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack - maybe update this with multiple weapons.
                    //Sword Attack
                    Console.WriteLine("You thrust forward, sword in hand! The " + n + " strikes back at you!");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    //Attack damage is equal to a random number between 0 and weapon value, plus a random number between 0-3.
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("The " + n + " strikes! You have anticipated the attack and raised your sword to defend.");
                    int damage = (p / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage.");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you attempt to evade the " + n + " you lose your footing, allowing the " + n + " to strike you.");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0) 
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You decide to not tempt fate. With haste, you run from the " +n+".");
                        Console.ReadKey();
                        //go to store or town, etc
                    }
                    
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if (Program.currentPlayer.healthPotion == 0)
                    {
                        Console.WriteLine("You feel nothing but the inside of your pockets as you reach in for health potion.");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + n + " damages you for " + damage + " health!");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your pocket and pull out an Elixir of Health, then taking a long drink.");
                        int potionValue = 5; //First instance of giving the amount of healing a potion does a value.
                        Console.WriteLine("You gain " + potionValue + " health.");
                        Program.currentPlayer.health += potionValue;
                        Console.WriteLine("While you were healing, the" + n + " took advances on you and landed a blow.");
                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health.");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Try again, peasant.");
                }

                //Death
                if (Program.currentPlayer.health <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Your wounds become too much to handle...\nNo longer can you hold the sword straight...\nYou've lost too much blood... \nThe " + n + " rears back for it's final attack, landing a fatal blow.You drift off in to eternal slumber...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-----GAME OVER-----");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
            Console.Clear();
            int c = rand.Next(2, 25);
            Console.WriteLine("You stand victorious over the " + n + "!. This is likely not the last of them...\nYou search through it's dead corpse and find "+ c +" coins.");
            Program.currentPlayer.coins += c;
            Console.ReadKey();
        }

        //This method will generate random names for us to use during the dungeon. I can always come back and add more to spice things up.
        public static string GetName()
        {
            switch(rand.Next(0, 5))
            {
                case 0:
                    return "Greater Daemon";
                case 1: 
                    return "Spawn of Darkness";
                case 2:
                    return "Imp of Chaos";
                case 3:
                    return "Hound of the Void";
                case 4:
                    return "Succulent Succubus";
                case 5:
                    return "Mind-Flayed";
            }
            return "Decayed Daemon of Torment";
        }
    }
}
