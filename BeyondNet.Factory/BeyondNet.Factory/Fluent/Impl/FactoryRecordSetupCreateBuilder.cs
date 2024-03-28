using BeyondNet.Factory.Fluent.Interfaces;
using BeyondNet.Factory.Model;

namespace BeyondNet.Factory.Fluent.Impl
{
    public class FactoryRecordSetupCreateBuilder<TTarget, TService> : IFactoryRecordSetupCreateBuilder<TTarget, TService>
    {
        private readonly RecordSetupItem _item;

        public FactoryRecordSetupCreateBuilder(RecordSetupItem item)
        {
            _item = item;
        }

        public IFactoryRecordSetupWhenBuilder<TTarget> Create<TImplementation>() where TImplementation : TService
        {
            _item.ImplementationType = typeof(TImplementation);

            return new FactoryRecordSetupWhenBuilder<TTarget>(_item);
        }

    }
}
