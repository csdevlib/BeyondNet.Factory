using BeyondNet.Factory.Interfaces;
using BeyondNet.Factory.Model;

namespace BeyondNet.Factory.Impl
{
    public class FactoryRecordSetupProvider : IFactoryRecordSetupProvider
    {
        public RecordSetup Configuration { get; }

        public IEnumerable<IFactoryRecordSetupSource> Sources { get; }

        public FactoryRecordSetupProvider(IEnumerable<IFactoryRecordSetupSource> sources)
        {
            if (sources == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }

            Sources = sources;

            Configuration = new RecordSetup(Sources.Select(source => source.Source()).Where(source => source != null).SelectMany(source => source.Items).ToList());

            foreach (var item in Configuration.Items.Where(objectFactoryConfigurationItem => objectFactoryConfigurationItem.ImplementationType == null || objectFactoryConfigurationItem.ServiceType==null))
            {
                throw new ArgumentException($"The implementation/service type for the item named {item.Name} for the target {item.TargetType.FullName} is null");
            }
        }

        public RecordSetupItem[] Provide<TTarget, TService>(TTarget target, string name)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            return Configuration.Items.Where(item => SameTargetTypeOf<TTarget>(item) && SameServiceTypeOf<TService>(item) && SameNameConfiguration(item, name) && IsSelected(item, target) && ImplementationAssignableTo<TService>(item)).ToArray();
        }

        private static bool IsSelected<TTarget>(RecordSetupItem item, TTarget instance)
        {
            var selector = item.Selector as Func<TTarget, bool>;

            var isselected = true;

            if (selector != null)
            {
                isselected = selector(instance);
            }

            return isselected;
        }

        private static bool SameTargetTypeOf<TTarget>(RecordSetupItem item)
        {
            return item.TargetType == typeof (TTarget);
        }

        private static bool SameServiceTypeOf<TService>(RecordSetupItem item)
        {
            return item.ServiceType == typeof(TService);
        }

        private static bool ImplementationAssignableTo<TService>(RecordSetupItem item)
        {
            return typeof(TService).IsAssignableFrom(item.ImplementationType);
        }

        private static bool SameNameConfiguration(RecordSetupItem item, string name)
        {
            return item.Name == name;
        }
    }
}
