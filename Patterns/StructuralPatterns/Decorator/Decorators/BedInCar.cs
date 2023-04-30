using Decorator.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class BedInCar : AdditionDecoratorBase
    {
        private BaseCar _car;
        
        public BedInCar(BaseCar car)
        {
            _car = car;
            Descriprion = _car.GetDescription() + " +Bed in car";
        }
        
        public override double GetCost()
        {
            return _car.GetCost() + 50000;
        }
    }
}
