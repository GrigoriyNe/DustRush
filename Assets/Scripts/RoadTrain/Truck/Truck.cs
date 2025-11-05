using System;
using UnityEngine;
using YG;

namespace RoadTrane
{
    public class Truck : MonoBehaviour
    {
        public const string SpeedTrusk = "Speeder";
        public const string Attacker = "Attacker";
        public const string Stealther = "Stealther";

        public string TypeTrusk { get; private set; }

        //   public string TypeTrusk

        private void OnEnable()
        {
            string saved = YG2.saves.TruskType;

            if (saved == SpeedTrusk)
            {
                TypeTrusk = SpeedTrusk;
            }
            else if (saved == Attacker)
            {
                TypeTrusk = Attacker;
            }
            else if (saved == Stealther)
            {
                TypeTrusk = Stealther;
            }
        }
    }
}
