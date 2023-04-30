using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Fast
{
    public class NoFast : IFastable
    {
        public void RidesFast()
        {
            Console.WriteLine("I'm not rides fast");
        }
    }
}
