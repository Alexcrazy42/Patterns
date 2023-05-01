using FactoryMethod.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();
    }
}
