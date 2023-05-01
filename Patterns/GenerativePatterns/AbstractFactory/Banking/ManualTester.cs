using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Banking
{
    public class ManualTester : ITester
    {
        public void TestCode()
        {
            Console.WriteLine("Manual tester testing code...");
        }
    }
}
