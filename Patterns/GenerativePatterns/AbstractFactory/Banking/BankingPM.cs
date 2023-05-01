using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Banking
{
    public class BankingPM : IProjectManager
    {
        public void ManageProject()
        {
            Console.WriteLine("Banking PM manage project....");
        }
    }
}
