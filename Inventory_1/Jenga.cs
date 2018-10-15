using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_1
{

    class Jenga : Game
    {
        public Jenga (String newName, int minPlayers, int maxPlayers, double duration, int newCost,
            bool newAvailability, bool newLostStatus, bool newBorrowedStatus, bool newCompletionStatus) : base(newName, minPlayers, maxPlayers, duration, newCost, newAvailability, newLostStatus, newBorrowedStatus,
                    newCompletionStatus)
        {

        }
    }
}
