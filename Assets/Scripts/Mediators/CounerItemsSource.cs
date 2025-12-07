using Modules.Grih.InventoryGroup;
using Modules.Grih.InventoryGroup.Public.Interfaces;
using System;
using YG;

namespace General
{
    internal class CounerItemsSource : ICounterSource
    {
        private ICounterSource _source;

        public event Action<int> NewScoreMoney;
        public event Action<int> NewScoreMetal;

        public void Init(
            ICounterSource source,
            InventoryItem money,
            InventoryItem metal,
            int savedScoreMoney,
            int savedScoreMetal)
        {
            _source = source;
            _source.Init(money, metal, savedScoreMoney, savedScoreMetal);
        }

        public void OnMetalSave(int value)
        {
            YG2.saves.Metal = value;
        }

        public void OnMoneySave(int value)
        {
            YG2.saves.Money = value;
        }
    }
}