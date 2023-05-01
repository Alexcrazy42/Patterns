using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public class GymMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price; 

        public GymMembership(decimal price)
        {
            _price = price;
            _name = "Gym membership";
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
