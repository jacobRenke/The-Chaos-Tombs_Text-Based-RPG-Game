using System;

namespace The_Chaos_Tombs
{
    internal class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("---The Chaos Tombs---");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your name, adventurer?");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You wake in a cold, stone room.\n There is blood all over the walls.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You smell burnt flesh. *Your* flesh. \n You look down at your bruised body...still dazed...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("While trying to stand up, you slip on the blood soaked floor, knocking a nearby table over.\n The impact of the chair echoes out of the room into the nearby hallway...you have awoken something...");
        }
    }
}
