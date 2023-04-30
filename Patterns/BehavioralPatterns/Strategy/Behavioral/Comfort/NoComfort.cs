using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavioral.Comfort
{
    public class NoComfort : IComfortable
    {
        public void HaveComfort()
        {
            Console.WriteLine("I'm not have comfort");
        }
    }
}
