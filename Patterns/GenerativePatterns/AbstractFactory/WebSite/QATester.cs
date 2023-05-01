using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WebSite
{
    public class QATester : ITester
    {
        public void TestCode()
        {
            Console.WriteLine("QA Tester tests code...");
        }
    }
}
