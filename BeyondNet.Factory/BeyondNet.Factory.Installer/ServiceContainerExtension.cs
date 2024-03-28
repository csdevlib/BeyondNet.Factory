using BeyondNet.Factory.Interfaces;
using LightInject;
using BeyondNet.Factory.Impl;
using BeyondNet.ServiceLocator.Installer;


namespace BeyondNet.Factory.Installer
{

    public static class ServiceContainerExtension
    {
        public static void AddFactory(this IServiceContainer container, Action<IFactoryBuilder> action=null)
        {
            container.AddServiceLocator();

            if (container.AvailableServices.All(x => x.ServiceType != typeof(IFactory)))
            {
                container.Register<IFactory, Impl.Factory>(new PerContainerLifetime());
            }

            if (container.AvailableServices.All(x => x.ServiceType != typeof(IFactoryCreator)))
            {
                container.Register<IFactoryCreator, FactoryCreator>(new PerContainerLifetime());
            }

            if (container.AvailableServices.All(x => x.ServiceType != typeof(IFactoryRecordSetupProvider)))
            {
                container.Register<IFactoryRecordSetupProvider, FactoryRecordSetupProvider>(new PerContainerLifetime());
            }

            if(action!=null)
            {
                action(new FactoryBuilder(container));
            }
        }

        public static IFactory GetFactory(this IServiceContainer container)
        {
            return container.GetInstance<IFactory>();
        }
    }
}
