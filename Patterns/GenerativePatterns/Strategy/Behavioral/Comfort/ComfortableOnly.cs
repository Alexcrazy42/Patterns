using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Comfort
{
    public class ComfortableOnly : IComfortable
    {
        public void HaveComfort()
        {
            Console.WriteLine("I only have comfort");
        }
    }
}
