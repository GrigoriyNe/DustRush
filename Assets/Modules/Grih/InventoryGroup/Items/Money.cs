using Modules.Grih.InventoryGroup;

namespace Inventory
{
    public class Money : InventoryItem
    {
        public override void Init(int savedValue)
        {
            ChangeValue(savedValue);
        }
    }
}
