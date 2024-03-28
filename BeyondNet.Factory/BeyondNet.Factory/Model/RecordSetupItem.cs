
namespace BeyondNet.Factory.Model
{
    public class RecordSetupItem
    {
        public RecordSetupItem(Type target, Type implementation, Type service, string name, object selector)
        {
            Name = name;

            Selector = selector;

            ImplementationType = implementation;

            TargetType = target;

            ServiceType = service;
        }

        public RecordSetupItem(Type target, Type implementation, Type service, string name)
        : this(target, implementation, service, name, null)
            {

            }

        public RecordSetupItem(Type target, Type service, string name)
            : this(target, null, service, name)
        {

        }

        public string Name { get; }

        public Type TargetType { get; }

        public Type ImplementationType { get; set; }

        public Type ServiceType { get; }

        public object Selector { get; set; }
    }
}