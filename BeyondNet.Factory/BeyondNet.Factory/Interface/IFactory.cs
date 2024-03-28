using BeyondNet.Factory.Model;

namespace BeyondNet.Factory.Interfaces
{
    public interface IFactory
    {
        TService[] Create<TTarget, TService>(TTarget target, string name) where TService : class;

        TService[] Create<TTarget, TService>(TTarget target) where TService : class;

        RecordSetupItem[] ConfigurationFor<TTarget, TService>(TTarget target, string name) where TService : class;

        RecordSetupItem[] ConfigurationFor<TTarget, TService>(TTarget target) where TService : class;

        IFactoryRecordSetupProvider ConfigurationProvider { get; }

        IFactoryCreator Creator { get; }

        IFactoryInterceptor Interceptor { get; set; }
    }
}
