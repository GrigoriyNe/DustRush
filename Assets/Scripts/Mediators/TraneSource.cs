using System;
using System.Collections.Generic;
using Modules.Grih.RoadTrane.Public.Interfaces;
using Modules.Grih.RoadTrane;
using YG;

namespace General
{
    internal class TraneSource : IFraneFabricSource
    {
        private Modules.Grih.RoadTrane.Public.Interfaces.IFraneFabricSource _source;

        public event Action<List<int>, List<int>> Saves;

        public void Init(
            Modules.Grih.RoadTrane.Public.Interfaces.IFraneFabricSource source,
            Modules.Grih.RoadTrane.FabricTrane fabricTrane,
            List<int> savedWagons,
            List<int> savedTower,
            string savedTrusk)
        {
            _source = source;
            _source.Saves += OnSave;
            _source.Init(fabricTrane, savedWagons, savedTower, savedTrusk);
        }

        public void OnSave(List<int> savedWagons, List<int> savedTowers)
        {
            YG2.saves.SavedWagons = savedWagons;
            YG2.saves.SavedTowers = savedTowers;
        }
    }

}