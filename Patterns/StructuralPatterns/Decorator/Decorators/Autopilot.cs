using Decorator.Cars;

namespace Decorator.Decorators
{
    public class Autopilot : AdditionDecoratorBase
    {
        private BaseCar _car;

        public Autopilot(BaseCar car)
        {
            _car = car;
            Descriprion = _car.GetDescription() + " +Autopilot";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 1000000;
        }
    }
}
