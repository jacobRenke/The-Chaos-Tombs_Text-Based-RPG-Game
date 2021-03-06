using System;

namespace The_Chaos_Tombs
{
    internal class Program
    {
        //The below constructor creates the "Player" that will store the data of the user.
        public static Player currentPlayer = new Player();
        public static bool Loop = true;
        private static string answer;

        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEnounter();
            while (Loop == true)
            {
                Encounters.RandomEncounter();
            }

        }

        //The "Start" method will be what the user sees upon running the program.
        static void Start()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-----The Chaos Tombs-----");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.ReadLine();
            Console.Clear();
            GetName();
            Console.Clear();
            Console.WriteLine("You wake in a cold, stone room.\n There is blood all over the walls.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You smell burnt flesh. *Your* flesh. \n You look down at your bruised body...still dazed...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("While trying to stand up, you slip on the blood soaked floor, knocking a nearby table over.\n The sound of the impact echoes out of the room into the nearby hallway...you have awoken something...");
            Console.ReadLine();
            Console.Clear();
        }
        public static void GetName()
        {
            Console.Clear();
            Console.WriteLine("What is your name, adventurer?");
            currentPlayer.tempName = Console.ReadLine();
            Console.WriteLine("Your name is " + currentPlayer.tempName + "? Please enter 'Yes' or 'No'.");
            answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                currentPlayer.name = currentPlayer.tempName;
            }
            else
            {
                GetName();
            }
        }
    }
}
