using System;
using UnityEngine;
using UnityEngine.UI;

namespace Sity
{
    public class SityMeny : MonoBehaviour
    {
        [SerializeField] private Button _garageOpen;
        [SerializeField] private Button _hostelOpen;
        [SerializeField] private Button _bankOpen;
        [SerializeField] private Button _shopOpen;

        [SerializeField] private Garage _garage;
        [SerializeField] private Hostel _hostel;
        [SerializeField] private Bank _bank;
        [SerializeField] private Shop _shop;

        private void OnEnable()
        {
            _garageOpen.onClick.AddListener(OpenGarage);
            _hostelOpen.onClick.AddListener(OpenHostel);
            _bankOpen.onClick.AddListener(OpenBank);
            _shopOpen.onClick.AddListener(OpenShop);
        }


        private void OnDisable()
        {
            _garageOpen.onClick.RemoveListener(OpenGarage);
            _hostelOpen.onClick.RemoveListener(OpenHostel);
            _bankOpen.onClick.RemoveListener(OpenBank);
            _shopOpen.onClick.RemoveListener(OpenShop);
        }

        private void OpenShop()
        {
            _shop.gameObject.SetActive(!_shop.gameObject.activeSelf);
        }

        private void OpenBank()
        {
            _bank.gameObject.SetActive(!_bank.gameObject.activeSelf);
        }

        private void OpenHostel()
        {
            _hostel.gameObject.SetActive(!_hostel.gameObject.activeSelf);
        }

        private void OpenGarage()
        {
            _garage.gameObject.SetActive(!_garage.gameObject.activeSelf);

        }
    }
}