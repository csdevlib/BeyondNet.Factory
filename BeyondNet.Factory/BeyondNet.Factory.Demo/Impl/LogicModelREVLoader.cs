using BeyondNet.Factory.Demo.Interfaces;
using BeyondNet.Factory.Demo.Models;

namespace BeyondNet.Factory.Demo.Impl
{
    public class LogicModelREVLoader : ILogicModelLoader
    {
        public ModelLogic Load(ePersonalizationType personalizationType)
        {
            return new ModelLogic()
            {
                Message = "REV",
            };
        }
    }
}
