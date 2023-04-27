using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Power
{
    public class NoPower : IPowerful
    {
        public void HavePower()
        {
            Console.WriteLine("I'm not have power");
        }
    }
}
