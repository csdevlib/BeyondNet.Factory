using BeyondNet.Tests.Factory.Test.Interfaces;

namespace BeyondNet.Tests.Factory.Test.Impl
{
    public class DoSomethingLessThan18 : IDoSomething
    {
        public bool Apply()
        {
            return true;
        }
    }
}