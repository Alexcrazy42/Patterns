using FactoryMethod.Domain;
using FactoryMethod.Factories;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Welcone to FitnessClub App <<\n");

        Console.WriteLine("> Enter the membership type you would like to create: ");

        Console.WriteLine("> G - Gym");
        Console.WriteLine("> P - Gym + Poll");
        Console.WriteLine("> T - Personal Training");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);

        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n> Membership you've just created: \n");

        Console.WriteLine(
            $"Name: {membership.Name}\n" +
            $"Description: {membership.Description}\n" +
            $"Price: {membership.GetPrice()}");

    }

    public static MembershipFactory GetFactory(string memberShipType) => 
        memberShipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic membership"),
            "p" => new GymWithPollMembershipFactory(250, "Good price membership"),
            "t" => new PersonalTrainingMembershipFactory(400, "Best for professionals"), 
            _ => null
        };
    
}