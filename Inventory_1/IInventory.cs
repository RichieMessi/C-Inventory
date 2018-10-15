using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_1
{
    interface IInventory
    {
        void getAllAvailStatus();
        void setAvailabilityStatus();
        void getAllInventoryItems();
        void getAvailableGames();
        void getGamesForDesiredNumOfPlayers(int desired_players);
        void getGamesForDesiredTime(double min_time, double max_time);
        void getCostOfIncompleteAndLostGames();
    }
}
