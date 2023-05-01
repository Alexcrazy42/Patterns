using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WebSite
{
    public class JavaDeveloper : IDeveloper
    {
        public void WriteCode()
        {
            Console.WriteLine("Java Developer writes Java code...");
        }
    }
}
