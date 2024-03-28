using BeyondNet.Factory.Fluent.Interfaces;
using BeyondNet.Factory.Model;

namespace BeyondNet.Factory
{
    public class FactoryRecordSetupWhenBuilder<TTarget> : IFactoryRecordSetupWhenBuilder<TTarget>
    {
        private readonly RecordSetupItem _item;

        public FactoryRecordSetupWhenBuilder(RecordSetupItem item)
        {
            _item = item;
        }

        public void When(Func<TTarget, bool> selector)
        {
            _item.Selector = selector;
        }
    }
}
