using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Power
{
    public class PowerfulToPullCars : IPowerful
    {
        public void HavePower()
        {
            Console.WriteLine("I power and I can pull cars!");
        }
    }
}
