using BeyondNet.Factory.Model;

namespace BeyondNet.Factory.Interfaces
{
    public interface IFactorySetupProvider
    {
        IEnumerable<IFactorySetupSource> Sources { get; }

        Setup Configuration { get; }

        SetupItem[] Provide<TTarget, TService>(TTarget target, string name);
    }
}
