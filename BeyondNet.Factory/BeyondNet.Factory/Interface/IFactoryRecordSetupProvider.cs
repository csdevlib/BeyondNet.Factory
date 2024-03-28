using BeyondNet.Factory.Model;

namespace BeyondNet.Factory.Interfaces
{
    public interface IFactoryRecordSetupProvider
    {
        IEnumerable<IFactoryRecordSetupSource> Sources { get; }

        RecordSetup Configuration { get; }

        RecordSetupItem[] Provide<TTarget, TService>(TTarget target, string name);
    }
}
