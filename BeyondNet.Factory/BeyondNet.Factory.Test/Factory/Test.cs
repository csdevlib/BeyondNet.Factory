using BeyondNet.Tests.Factory.Test.Impl;
using Locator = BeyondNet.ServiceLocator.Impl;
using BeyondNet.Tests.Factory.Test.Interfaces;
using BeyondNet.Factory.Impl;
using BeyondNet.Factory.Interfaces;


namespace BeyondNet.Tests.Factory.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Create_WithCustomerOlderThan25_ShouldBeNotEmpty()
        {
            var tests = new TestCases();

            var locator = new Locator.ServiceLocator();

            locator.Register(typeof(IDoSomething), new DoSomething(), typeof(DoSomething).FullName);

            var config = new FactoryRecordSetupSource();

            var factory = new BeyondNet.Factory.Impl.Factory (new FactoryRecordSetupProvider(new IFactoryRecordSetupSource[] { (IFactoryRecordSetupSource)config }), new FactoryCreator(locator));

            tests.CreateWithConsultantOlderThan25ShouldBeNotEmpty(factory);
        }
    }
}
