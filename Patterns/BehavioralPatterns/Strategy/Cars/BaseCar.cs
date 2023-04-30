using Strategy.Behavioral.Fast;
using Strategy.Behavioral.Power;
using Strategy.Behavioral.Comfort;

namespace Strategy.Cars
{
    public class BaseCar
    {

        protected IFastable fastBehavioral;
        protected IPowerful powerBehavioral;
        protected IComfortable comfortBehavioral;

        public BaseCar()
        {
            fastBehavioral = new JustFast();
            powerBehavioral = new PowerfulToFast();
            comfortBehavioral = new ComfortableOnly();
        }

        public void Display()
        {
            Console.WriteLine($"I am {this.GetType().Name}");
        }

        public void Ride()
        {
            Console.WriteLine("I ride");
        }

        public void RidesFast()
        {
            fastBehavioral.RidesFast();
        }

        public void HavePower()
        {
            powerBehavioral.HavePower();
        }

        public void HaveComfort()
        {
            comfortBehavioral.HaveComfort();
        }

        public void SetComfortable(IComfortable comfortable)
        {
            comfortBehavioral = comfortable;
        }
    }
}
