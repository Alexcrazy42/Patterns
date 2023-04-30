using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Cars
{
    public class Volvo : BaseCar
    {
        public Volvo()
        {
            Descriprion = "Volvo";
        }

        public override double GetCost()
        {
            return 800000;
        }
    }
}
