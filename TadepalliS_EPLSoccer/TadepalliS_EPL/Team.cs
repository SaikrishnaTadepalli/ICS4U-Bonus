using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadepalliS_EPL
{
    class Team
    {
        public string name;
        public int rating; // rating out of 10
        public int points; // total wins + ties + losses 
        public int wins; // total wins
        public int ties; // total ties
        public int losses; // total losses
        public int goals; // total goals

        public Team(string teamName, int teamRating)
        {
            name = teamName;
            rating = teamRating;
            points = 0;
            wins = 0;
            ties = 0;
            losses = 0;
            goals = 0;
        }

        public void matchWon()
        {
            points += 3;
            wins += 1;
        }

        public void matchTied()
        {
            points += 1;
            ties += 1;
        }
        public void matchLost()
        {
            losses += 1;
        }
    }
}
