using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Banking
{
    public class CDeveloper : IDeveloper
    {
        public void WriteCode()
        {
            Console.WriteLine("C developer writes code....");
        }
    }
}
