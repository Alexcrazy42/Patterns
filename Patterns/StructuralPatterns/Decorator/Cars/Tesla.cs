using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Cars
{
    public class Tesla : BaseCar
    {
        public Tesla()
        {
            Descriprion = "Tesla";
        }

        public override double GetCost()
        {
            return 1500000;
        }
    }
}
