using FactoryMethod.Domain;

namespace FactoryMethod.Factories
{
    public class GymMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description; 

        public GymMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymMembership membership = new GymMembership(_price)
            {
                Description = _description
            };
            return membership;
        }
    }
}
