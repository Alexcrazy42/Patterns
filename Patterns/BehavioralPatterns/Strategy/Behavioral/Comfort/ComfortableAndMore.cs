using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Comfort
{
    public class ComfortableAndMore : IComfortable
    {
        public void HaveComfort()
        {
            Console.WriteLine("I have comfort and more");
        }
    }
}
