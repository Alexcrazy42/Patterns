using Decorator.Cars;

namespace Decorator.Decorators
{
    public class AutoParking : AdditionDecoratorBase
    {
        private BaseCar _car;

        public AutoParking(BaseCar car)
        {
            _car = car;
            Descriprion = _car.GetDescription() + " +Auto parking";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 300000;
        }
    }
}
