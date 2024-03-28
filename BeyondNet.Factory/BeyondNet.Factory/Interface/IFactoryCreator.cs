namespace BeyondNet.Factory.Interfaces
{
    public interface IFactoryCreator
    {
        T Create<T>(Type type) where T:class;
    }
}