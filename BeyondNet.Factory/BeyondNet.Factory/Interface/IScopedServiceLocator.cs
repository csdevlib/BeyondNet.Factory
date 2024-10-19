
namespace BeyondNet.Factory.Interfaces
{
    public interface IScopedServiceLocator : IServiceLocator
    {
        IDisposable BeginScope();
    }
}
