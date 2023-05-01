using FactoryMethod.Domain;

namespace FactoryMethod.Factories
{
    public class GymWithPollMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymWithPollMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership()
        {
            GymWithPoolMembership membership = new GymWithPoolMembership(_price)
            {
                Description = _description
            };
            return membership;
        }
    }
}
