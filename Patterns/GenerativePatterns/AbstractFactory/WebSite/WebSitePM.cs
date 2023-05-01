using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WebSite
{
    public class WebSitePM : IProjectManager
    {
        public void ManageProject()
        {
            Console.WriteLine("PM manages web site project....");
        }
    }
}
