using System.Diagnostics;

namespace BeyondNet.Factory.Model
{
    public class RecordSetup
    {
        public List<RecordSetupItem> Items { get; }

        public RecordSetup(List<RecordSetupItem> items)
        {
            Items = items;
        }

        public RecordSetup()
        {
            Items = new List<RecordSetupItem>();
        }
    }
}
