using System;

namespace The_Chaos_Tombs
{
    public class PortalShop
    {
        public static void OpenShopPortal(Player p)
        {
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            double potionP;
            double armorP;
            double weaponP;
            double difficultyP;

            while (true)
            {

                potionP = 20 + 10 * p.mods;
                armorP = 100 * (p.armorValue + 1);
                weaponP = 100 * p.weaponValue;
                difficultyP = 300 + 100 * p.mods;
                Console.Clear();
                Console.WriteLine("     Portal Shop");
                Console.WriteLine("[]__________________[]");
                Console.WriteLine("||(W)eapon:" + weaponP);
                Console.WriteLine("||(A)rmor:" + armorP);
                Console.WriteLine("||(P)otion:" + potionP);
                Console.WriteLine("||(M)od:" + difficultyP);
                Console.WriteLine("[]__________________[]");
                Console.WriteLine("||(E)xit:");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("  " + p.name + "'s Stats");
                Console.WriteLine("[]__________________________[]");
                Console.WriteLine("||Current Health: " + p.health);
                Console.WriteLine("||Amount of Coins: " + p.coins);
                Console.WriteLine("||Weapon Strength: " + p.weaponValue);
                Console.WriteLine("||Defensive Modifier: " + p.armorValue);
                Console.WriteLine("||Number of Potions: " + p.weaponValue);
                Console.WriteLine("||Difficulty Modifier: " + p.weaponValue);
                Console.WriteLine("[]__________________________[]");


                string input = Console.ReadLine().ToLower();

                if (input == "w" || input == "weapon")
                {
                    TryBuy("weapon", weaponP, p);
                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorP, p);
                }
                else if (input == "p" || input == "potion")
                {
                    TryBuy("potion", potionP, p);
                }
                else if (input == "m" || input == "mod")
                {
                    TryBuy("mods", difficultyP, p);
                }
                else if (input == "e" || input == "exit")
                {
                    break;
                }
                    

            }
        }

        static void TryBuy(string item, double cost, Player p)
        {
            if (p.coins >= cost)
            {
                if (item == "weapon")
                {
                    p.weaponValue++;
                }
                else if (item == "armor")
                {
                    p.armorValue++;
                }
                else if (item == "potion")
                {
                    p.healthPotion++;
                }
                else if (item == "mods")
                {
                    p.mods++;
                }

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("Unfortunately, the engima at the counter wants more gold for that.");
                Console.ReadKey();
            }
        }
    }
}
