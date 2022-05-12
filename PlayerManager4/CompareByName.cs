using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class CompareByName : IComparer<Player>
    {
        IComparer<Player> comp = new CompareByName();

        public bool UpOrDown { get;}

        public CompareByName (bool UpOrDown)
        {
            UpOrDown = newUpOrDown;
        }
    }
        
}