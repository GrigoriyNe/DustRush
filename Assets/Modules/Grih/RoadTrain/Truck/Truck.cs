using System;
using UnityEngine;

namespace Modules.Grih.RoadTrane
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Truck : TranePart
    {
        public const string SpeedTrusk = "Speeder";
        public const string Attacker = "Attacker";
        public const string Stealther = "Stealther";

        private SpriteRenderer _spriteRenderer;

        [SerializeField] private Sprite _speedSprite;
        [SerializeField] private Sprite _attackerSprite;
        [SerializeField] private Sprite _stealtherSprite;

        private string _savedType;

        public string TypeTrusk { get; private set; }

        public override void OnEnabled()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();


            SetLoadType();
        }

        public void Init(string type)
        {
            _savedType = type;
        }

        private void SetLoadType()
        {
            if (_savedType == SpeedTrusk)
            {
                TypeTrusk = SpeedTrusk;
                _spriteRenderer.sprite = _speedSprite;
            }
            else if (_savedType == Attacker)
            {
                TypeTrusk = Attacker;
                _spriteRenderer.sprite = _attackerSprite;

            }
            else if (_savedType == Stealther)
            {
                TypeTrusk = Stealther;
                _spriteRenderer.sprite = _stealtherSprite;

            }
        }

        public void ChangeType(int id)
        {
            string type;

            if (id == 2)
                type = Attacker;
            else if (id == 3)
                type = Stealther;
            else
                type = SpeedTrusk;

       //     YG2.saves.TruskType = type;
            SetLoadType();
      //      YG2.SaveProgress();
        }
    }
}
