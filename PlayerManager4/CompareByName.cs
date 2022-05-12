using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class CompareByName : IComparer<Player>
    {
        public bool UpOrDown { get; set;}

        public CompareByName (bool newUpOrDown)
        {
            this.UpOrDown = newUpOrDown;
        }

        public int Compare (Player x, Player y)
        {
            if (UpOrDown)
                return String.Compare(x.Name, y.Name);
            else
            {
                return -1 * String.Compare(x.Name, y.Name);
            }


        }
    }
        
}