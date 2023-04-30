using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Cars
{
    public abstract class BaseCar
    {
        protected string Descriprion = "";

        public string GetDescription()
        {
            return Descriprion;
        }

        public abstract double GetCost();
    }
}
