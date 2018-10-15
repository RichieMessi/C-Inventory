using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_1
{
    class Game
    {
        String name;
        int min_players;
        int max_players;
        double playtime;
        int cost;
        DateTime purchaseDate;
        bool isAvailable;
        bool isLost;
        bool isBorrowed;
        bool isComplete;

        public Game(String newName, int minPlayers, int maxPlayers, double duration, int newCost, bool newAvailabilityStatus, bool newLostStatus, bool newBorrowedStatus, bool newCompleteStatus)
        {
            this.name = newName;
            this.min_players = minPlayers;
            this.max_players = maxPlayers;
            this.playtime = duration;
            this.cost = newCost;
            this.isAvailable = newAvailabilityStatus;
            this.purchaseDate = new DateTime();
            this.isLost = newLostStatus;
            this.isBorrowed = newBorrowedStatus;
            this.isComplete = newCompleteStatus;
        }

        public bool getAvailabilityStatus()
        {
            return this.isAvailable;
        }

        public void setAvailabilityStatus(bool newAvailabilityStatus)
        {
            this.isAvailable = newAvailabilityStatus;
        }

        public bool getLostStatus()
        {
            return this.isLost;
        }

        public void setLostStatus(bool newLostStatus)
        {
            this.isLost = newLostStatus;
        }

        public bool getBorrowedStatus()
        {
            return this.isBorrowed;
        }

        public void setBorrowedStatus(bool newBorrowedStatus)
        {
            this.isBorrowed = newBorrowedStatus;
        }

        public bool getCompletionStatus()
        {
            return this.isComplete;
        }

        public void setCompletionStatus(bool newCompletionStatus)
        {
            this.isComplete = newCompletionStatus;
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String newName)
        {
            this.name = newName;
        }

        public int getCost()
        {
            return this.cost;
        }

        public void setCost(int newCost)
        {
            this.cost = newCost;
        }

        public int getMinPlayers()
        {
            return this.min_players;
        }

        public void setMinPlayers(int newMinPlayersValue)
        {
            this.min_players = newMinPlayersValue;
        }

        public int getMaxPlayers()
        {
            return this.max_players;
        }

        public void setMaxPlayers(int newMaxPlayersValue)
        {
            this.max_players = newMaxPlayersValue;
        }

        public double getPlaytime()
        {
            return this.playtime;
        }

        public void setPlaytime(double newPlaytimeValue)
        {
            this.playtime = newPlaytimeValue;
        }
        

        public String toString()
        {
            return "Name: " + this.name + " Players-Range: " + this.min_players + " - " + this.max_players + " playtime: "
                + this.playtime + " cost: " + this.cost;
        }


    }
}
