using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        public Player (string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string Name { get; }
        public int Score { get; set; }

        public int CompareTo(Player other)
        {
            if (other == null) return 1; 
            if (Score > other.Score) return 1;
            else if (Score < other.Score) return -1;
            else return 0;
        }
    }
}