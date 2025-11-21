using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace RoadTrane
{
    public class WagonsHashTable : MonoBehaviour
    {
        private const int IdWagonEmpty_1 = 10;
        private const string IdWagonEmptyName_1 = "Empty_1";

        private const int IdWagonEmpty_2 = 11;
        private const string IdWagonEmptyName_2 = "Empty_2";

        private const int IdWagonEmpty_3 = 12;
        private const string IdWagonEmptyName_3 = "Empty_3";

        private const int IdWagonBattery = 21;
        private const string IdWagonBatteryWagonName = "BatteryWagon";

        private const int IdFuelWagon = 25;
        private const string IdFuelWagonName = "FuelWagon";

        private const int IdEngineeringWagon = 31;
        private const string IdEngineeringWagonName = "EngineeringWagon";

        private const int IdLivingWagon = 35;
        private const string IdLivingWagonName = "LivingWagon";

        private const int IdMlitaryWagon = 40;
        private const string IdMlitaryWagonName = "MlitaryWagon";

        private const int IdSolarBWagon = 45;
        private const string IdSolarBWagonName = "SolarBWagon"; 

        private const int IdFuelPowerGeneratorWagon = 51;
        private const string IdFuelPowerGeneratorWagonName = "FuelPowerGeneratorWagon"; 

        [SerializeField] private GameObject _wagonEmpty_1;
        [SerializeField] private GameObject _wagonEmpty_2;
        [SerializeField] private GameObject _wagonEmpty_3;

        [SerializeField] private GameObject _batteryWagon;
        [SerializeField] private GameObject _fuelWagon;

        [SerializeField] private GameObject _engineeringWagon;
        [SerializeField] private GameObject _livingWagon;
        [SerializeField] private GameObject _mlitaryWagon;
        [SerializeField] private GameObject _solarBWagon;
        [SerializeField] private GameObject _fuelPowerGeneratorWagon;

        public Dictionary<int, GameObject> _wagonsTable = new Dictionary<int, GameObject>();

        public Dictionary<int, GameObject> WagonsTable => _wagonsTable;

        private void OnEnable()
        {
            _wagonsTable.Add(IdWagonEmpty_1,
                _wagonEmpty_1);

            _wagonsTable.Add(IdWagonEmpty_2,
                _wagonEmpty_2);

            _wagonsTable.Add(IdWagonEmpty_3,
                _wagonEmpty_3);

            _wagonsTable.Add(IdWagonBattery,
               _batteryWagon); 
            
            _wagonsTable.Add(IdLivingWagon,
               _livingWagon);

            _wagonsTable.Add(IdFuelWagon,
               _fuelWagon);

            _wagonsTable.Add(IdEngineeringWagon,
               _engineeringWagon);

            _wagonsTable.Add(IdMlitaryWagon,
               _mlitaryWagon);

            _wagonsTable.Add(IdSolarBWagon,
               _solarBWagon);

            _wagonsTable.Add(IdFuelPowerGeneratorWagon,
               _fuelPowerGeneratorWagon);
            

            InitId();
        }

        private void InitId()
        {
            foreach (var item in _wagonsTable)
            {
                var wagon = item.Value.GetComponent<Wagon>();

                wagon.SetID(item.Key);
            }
        }
    }
}
