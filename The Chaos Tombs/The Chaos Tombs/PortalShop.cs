using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int potionP;
            double armorP;
            double weaponP;
            int difficultyP;

            while(true)
            {

                potionP = 20 + 10 * p.mods;
                armorP = 100 * p.armorValue;
                weaponP = 100 * (p.weaponValue + 1);
                difficultyP = 300 + 100 * p.mods;

                Console.WriteLine("     Portal Shop");
                Console.WriteLine("[]__________________[]");
                Console.WriteLine("||(W)eapon:"+ weaponP);
                Console.WriteLine("||(A)rmor:"+ armorP);
                Console.WriteLine("||(P)otion:" + potionP);
                Console.WriteLine("||(M)od:"+ difficultyP);
                Console.WriteLine("[]__________________[]");
                //Wait for input
            }
        }
    }
}
