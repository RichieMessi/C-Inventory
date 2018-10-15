using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            Console.WriteLine("Welcome to the Board Game Cafe");
            Console.WriteLine("The games available for rent are as follows...");

            Console.WriteLine("-----------------------------------------------------------");

            //GET ALL GAMES 
            inventory.getAllInventoryItems();

            //GET ONLY AVAILABLE GAMES
            inventory.getAvailableGames();

            Console.WriteLine("===========================================================");
            Console.WriteLine("How Many Players...?");

            int totalPlayers = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered {totalPlayers}");
            
            inventory.getGamesForDesiredNumOfPlayers(totalPlayers);


            Console.WriteLine("===========================================================");


            Console.WriteLine($"For how many hours? Please provide an max limit and a min limit of your expected playtime... For Example: {0.5} for half hr and {2} hr for two hrs");
            Console.WriteLine("What is the min limit of your expected time...?");
            double minLimit = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the max limit of your expected time...?");
            double maxLimit = double.Parse(Console.ReadLine());

            Console.WriteLine($"You entered { maxLimit } to  { minLimit } as your required timeframe");
            inventory.getGamesForDesiredTime(minLimit, maxLimit);

            inventory.getCostOfIncompleteAndLostGames();

            Console.WriteLine("*********************************");
            Console.WriteLine("Thanks for using the software");



            Console.ReadKey();

        }
    }
}
