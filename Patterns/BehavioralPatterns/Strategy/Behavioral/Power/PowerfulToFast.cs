using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Power
{
    public class PowerfulToFast : IPowerful
    {
        public void HavePower()
        {
            Console.WriteLine("I powerful and I can rides fast");
        }
    }
}
