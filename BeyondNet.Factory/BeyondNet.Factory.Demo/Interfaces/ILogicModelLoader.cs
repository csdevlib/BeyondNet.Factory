using BeyondNet.Factory.Demo.Models;

namespace BeyondNet.Factory.Demo.Interfaces
{
    public interface ILogicModelLoader
    {
        ModelLogic Load(ePersonalizationType personalizationType);
    }
}
