using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Chaos_Tombs
{
    public class PortalShop
    {
        static double armorMod;
        static double weaponMod;
        static double difficultyMod;
        

        public static void OpenShopPortal(Player currentPlayer)
        {
            armorMod = currentPlayer.armorValue;
            weaponMod = currentPlayer.weaponValue;
            difficultyMod = currentPlayer.mods;

            RunShop(currentPlayer);
        }

        public static void RunShop(Player currentPlayer)
        {
            while(true)
            {
                Console.WriteLine("    Portal Shop      ");
                Console.WriteLine("");
                Console.WriteLine("      0000000      ");
                Console.WriteLine("   0000|    |0000       ");
                Console.WriteLine("000|(W)eapon:  |000      ");
                Console.WriteLine("000|(A)rmor;     |000      ");
                Console.WriteLine("000|(P)otion;    |000     ");
                Console.WriteLine("000|(M)od        |000      ");
                Console.WriteLine("   0000|    |0000       ");
                Console.WriteLine("      0000000      ");
            }
        }
    }
}
