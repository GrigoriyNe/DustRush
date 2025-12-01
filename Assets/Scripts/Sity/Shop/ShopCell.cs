using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sity
{
    public class ShopCell : MonoBehaviour
    {
        [SerializeField] private int _coustMoney;
        [SerializeField] private int _coustMetal;
        [SerializeField] private Button _buttonActivate;

        [SerializeField] private TextMeshProUGUI _coustMoneyView;
        [SerializeField] private TextMeshProUGUI _coustMetalView;

        public int IdContent { get; private set; }
        public bool IsByed { get; private set; } = false;

        public event Action<int, int, int> Byed;
        public event Action<int> OnUsed;

        private void OnEnable()
        {
            _buttonActivate.onClick.AddListener(OnClick);
            _coustMoneyView.text = _coustMoney.ToString();
            _coustMetalView.text = _coustMetal.ToString();
        }

        private void OnDisable()
        {
            _buttonActivate.onClick.RemoveListener(OnClick);
        }

        public void SetID(int key)
        {
            if (key > 0)
                IdContent = key;
        }

        public void SetBuyState(bool isByed)
        {
            IsByed = isByed;

            if (IsByed)
            {
                _coustMoneyView.gameObject.SetActive(false);
                _coustMetalView.gameObject.SetActive(false);
            }
        }

        private void OnClick()
        {
            if (IsByed == false)
            {
                Byed?.Invoke(IdContent, _coustMoney, _coustMetal);
            }
            else
            {
                OnUsed?.Invoke(IdContent);
            }
        }
    }
}