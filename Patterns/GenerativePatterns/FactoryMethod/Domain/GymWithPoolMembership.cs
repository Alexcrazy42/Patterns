using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public class GymWithPoolMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GymWithPoolMembership(decimal price)
        {
            _name = "Gym + Pool membership";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
