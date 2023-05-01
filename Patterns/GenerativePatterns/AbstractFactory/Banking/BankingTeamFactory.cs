using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Banking
{
    public class BankingTeamFactory : IProjectTeamFactory
    {
        public IDeveloper GetDeveloper()
        {
            return new CDeveloper();
        }

        public ITester GetTester()
        {
            return new ManualTester();
        }

        public IProjectManager GetProjectManager()
        {
            return new BankingPM();
        }
    }
}
