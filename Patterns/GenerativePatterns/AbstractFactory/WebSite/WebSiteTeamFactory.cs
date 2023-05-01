using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WebSite
{
    public class WebSiteTeamFactory : IProjectTeamFactory
    {
        public IDeveloper GetDeveloper()
        {
            return new JavaDeveloper();
        }

        public ITester GetTester()
        {
            return new QATester();
        }
        
        public IProjectManager GetProjectManager()
        {
            return new WebSitePM();
        }
    }
}
