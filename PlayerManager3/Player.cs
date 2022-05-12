using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class Player : IComparable<Player>
    {
        public string  Name{ get ; }
        public int Score { get; set; }

        public Player (string newName, int newScore)
        {
            Name = newName;
            Score = newScore;
        }


        public int CompareTo(Player other)
        {
            if (other == null) return 1;
            return other.Score - this.Score;
        }
    }
        
}