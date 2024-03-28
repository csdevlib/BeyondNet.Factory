using BeyondNet.Factory.Demo.Models;

namespace BeyondNet.Factory.Demo.Interfaces
{
    public interface IStrategyBuilder
    {
        Strategy Build(Criteria criteria);
    }
}
