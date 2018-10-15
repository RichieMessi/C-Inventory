using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_1
{
    class Inventory : IInventory 
    {
        Chess chess_1;
        Chess chess_2;
        Chess chess_3;
        Jenga jenga_1;
        Jenga jenga_2;
        Jenga jenga_3;
        Scribble scribble_1;
        Scribble scribble_2;
        Scribble scribble_3;
        Scribble scribble_4;
        List<Game> items;


        public Inventory()
        {
            chess_1 = new Chess("chess 1", 2, 10, 5, 10, false, true, false, true);
            chess_2 = new Chess("chess 2", 3, 4, 5, 11, false, false, true, true);
            chess_3 = new Chess("chess 3", 4, 5, 6, 12, false, false, false, true);
            jenga_1 = new Jenga("jenga 1", 8, 9, 1, 30, false, false, false, true);
            jenga_2 = new Jenga("jenga 2", 9, 10, 2, 31, false, false, false, true);
            jenga_3 = new Jenga("jenga 3", 10, 11, 3, 32, false, false, false, false);
            scribble_1 = new Scribble("scribble 1", 2, 10, 10, 10, false, false, false, true);
            scribble_2 = new Scribble("scribble 2", 2, 10, 10, 10, false, false, false, true);
            scribble_3 = new Scribble("scribble 3", 2, 10, 10, 10, false, false, false, true);
            scribble_4 = new Scribble("scribble 4", 2, 10, 10, 10, false, true, false, true);

            //items = items.asList(chess_1, chess_2, chess_3, jenga_1, jenga_2, jenga_3, scribble_1, scribble_2, scribble_3,
            //scribble_4);
            items = new List<Game>
            {
                chess_1, chess_2, chess_3, jenga_1, jenga_2, jenga_3, scribble_1, scribble_2, scribble_3, scribble_4
            };
            this.setAvailabilityStatus();
        }

        public void getAllAvailStatus()
        {
            foreach(Game game in items)
            {
                Console.WriteLine($"{game.getName()} and {game.getAvailabilityStatus()}");
            }
        }

        public void setAvailabilityStatus()
        {
            foreach(Game game in items)
            {
                if(!game.getLostStatus())
                {
                    if(!game.getBorrowedStatus())
                    {
                        if(game.getCompletionStatus())
                        {
                            game.setAvailabilityStatus(true);
                        }
                    }
                }
            }
        }

        public void getAllInventoryItems()
        {
            foreach (Game game in items)
            {
                Console.WriteLine(game.toString());
            }
        }

        public void getAvailableGames()
        {
            foreach (Game game in items)
            {
                if (game.getAvailabilityStatus())
                {
                    Console.WriteLine("The games available for rent are " + game.getName());
                }
            }
        }

        public void getGamesForDesiredNumOfPlayers(int desired_players)
        {
            foreach (Game game in items)
            {
                if (game.getAvailabilityStatus())
                {
                    if (desired_players >= game.getMinPlayers() && desired_players <= game.getMaxPlayers())
                    {
                        Console.WriteLine("The games available for " + desired_players + " players  are " + game.getName());
                    }
                }
            }
        }

        public void getGamesForDesiredTime(double min_time, double max_time)
        {
            foreach (Game game in items)
            {
                if (game.getAvailabilityStatus())
                {
                    if (min_time > 0 && max_time <= game.getPlaytime())
                    {
                        Console.WriteLine("The game  " + game.getName() + " is available for the playtime of " + min_time
                                + " hrs - " + max_time + " hrs");
                    }
                }
            }
        }

        public void getCostOfIncompleteAndLostGames()
        {
            int cost = 0;
            foreach (Game game in items)
            {
                if (game.getLostStatus() || !game.getCompletionStatus())
                {
                    cost = cost + game.getCost();
                }
            }
            Console.WriteLine("The total cost of incomplete and lost games is $" + cost);
        }
    }
}
