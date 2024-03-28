using BeyondNet.Factory.Impl;
using BeyondNet.Tests.Factory.Test.Interfaces;
using BeyondNet.Tests.Factory.Test.Models;

namespace BeyondNet.Tests.Factory.Test.Impl
{
    public class FactoryRecordSetupSource : AbstractFactoryRecordSetupSource
    {
        public FactoryRecordSetupSource()
        {
            For<Consultant, IDoSomething>().Create<DoSomething>().When(x => x.Age > 18);
            For<Consultant, IDoSomething>().Create<DoSomethingLessThan18>().When(x => x.Age < 18);
        }
    }

}

