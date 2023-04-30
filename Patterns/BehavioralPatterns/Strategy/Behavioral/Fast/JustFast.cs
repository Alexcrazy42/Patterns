using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Fast
{
    public class JustFast : IFastable
    {
        public void RidesFast()
        {
            Console.WriteLine("I just fast");
        }
    }
}
