
namespace BeyondNet.Factory.Fluent.Interfaces
{
    public interface IFactoryRecordSetupGroupCreateBuilder<out TTarget, in TService>
    {
        IFactoryRecordSetupWhenBuilder<TTarget> Create<TImplementation>() where TImplementation : TService;
    }
}