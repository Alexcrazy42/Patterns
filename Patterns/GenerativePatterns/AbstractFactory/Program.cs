

using AbstractFactory.Banking;
using AbstractFactory.Interfaces;
using AbstractFactory.WebSite;


class Program
{
    static void Main(string[] args)
    {
        IProjectTeamFactory teamFactoryToBank = new BankingTeamFactory();
        IDeveloper developerToBank = teamFactoryToBank.GetDeveloper();
        ITester testerToBank = teamFactoryToBank.GetTester();
        IProjectManager pmToBank = teamFactoryToBank.GetProjectManager();

        Console.WriteLine("Starting Bank Project.....");
        developerToBank.WriteCode();
        testerToBank.TestCode();
        pmToBank.ManageProject();

        Console.WriteLine();
        IProjectTeamFactory teamFactoryToWebSite = new WebSiteTeamFactory();
        IDeveloper developerToWebSite = teamFactoryToWebSite.GetDeveloper();
        ITester testerToWebSite = teamFactoryToWebSite.GetTester();
        IProjectManager pmToWebSite = teamFactoryToWebSite.GetProjectManager();

        Console.WriteLine("Starting Bank Project.....");
        developerToWebSite.WriteCode();
        testerToWebSite.TestCode();
        pmToWebSite.ManageProject();



    }
    
}