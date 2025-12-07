using Modules.Grih.InventoryGroup;

namespace Inventory
{
    public class Metal : InventoryItem
    {
        public override void Init(int savedValue)
        {
            ChangeValue(savedValue);
        }
    }
}
