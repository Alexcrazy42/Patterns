using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Cars
{
    public class Audi : BaseCar
    {
        public Audi()
        {
            Descriprion = "Audi";
        }

        public override double GetCost()
        {
            return 1000000;
        }
    }
}
