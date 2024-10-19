using BeyondNet.Factory.Model;

namespace BeyondNet.Factory.Interfaces
{
    public interface IFactory
    {
        TService[] Create<TTarget, TService>(TTarget target, string name) where TService : class;

        TService[] Create<TTarget, TService>(TTarget target) where TService : class;

        SetupItem[] ConfigurationFor<TTarget, TService>(TTarget target, string name) where TService : class;

        SetupItem[] ConfigurationFor<TTarget, TService>(TTarget target) where TService : class;

        IFactorySetupProvider ConfigurationProvider { get; }

        IFactoryCreator Creator { get; }

        IFactoryInterceptor Interceptor { get; set; }
    }
}
