using BeyondNet.Factory.Demo.Impl;
using BeyondNet.Factory.Demo.Interfaces;
using BeyondNet.Factory.Demo.Models;
using BeyondNet.Factory.Impl;

namespace BeyondNet.Factory.Demo.Bootstrapper
{
    public class LogicModelFactoryRecordSetup : AbstractFactorySetupSource
    {
        public LogicModelFactoryRecordSetup()
        {
            For<Criteria, ILogicModelLoader>().Create<LogicModelCATLoader>().When(x => x.PersonalizationType == ePersonalizationType.CAT);
            For<Criteria, ILogicModelLoader>().Create<LogicModelPADLoader>().When(x => x.PersonalizationType == ePersonalizationType.PAD);
            For<Criteria, ILogicModelLoader>().Create<LogicModelREVLoader>().When(x => x.PersonalizationType == ePersonalizationType.REV);
        }
    }
}
