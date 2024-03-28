using BeyondNet.Factory.Fluent.Interfaces;
using BeyondNet.Factory.Model;

namespace BeyondNet.Factory
{
    public class FactoryRecordSetupGroupCreateBuilder<TTarget, TService> : IFactoryRecordSetupGroupCreateBuilder<TTarget, TService>
    {
        private readonly List<RecordSetupItem> _objectFactoryConfigurationItems;

        private readonly string _name;

        public FactoryRecordSetupGroupCreateBuilder(List<RecordSetupItem> objectFactoryConfigurationItems, string name)
        {
            _objectFactoryConfigurationItems = objectFactoryConfigurationItems;

            _name = name;
        }

        public IFactoryRecordSetupWhenBuilder<TTarget> Create<TImplementation>() where TImplementation : TService
        {
            var value = new RecordSetupItem(typeof(TTarget), typeof(TImplementation), typeof(TService), _name);

            _objectFactoryConfigurationItems.Add(value);

            return new FactoryRecordSetupWhenBuilder<TTarget>(value);
        }

    }
}