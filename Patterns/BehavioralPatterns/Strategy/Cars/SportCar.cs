using Strategy.Behavioral.Comfort;
using Strategy.Behavioral.Fast;
using Strategy.Behavioral.Power;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cars
{
    public class SportCar : BaseCar
    {
        public SportCar()
        {
            fastBehavioral = new JustFast();
            powerBehavioral = new PowerfulToFast();
            comfortBehavioral = new NoComfort();
        }

        
    }
}
