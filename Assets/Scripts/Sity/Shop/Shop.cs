using Common;
using Pool;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sity
{
    public class Shop : MonoBehaviour
    {
        [SerializeField] private List<Transform> _placesForCell = new List<Transform>();
        [SerializeField] private InventoryHashTable _inventoryHashTable;
        [SerializeField] private Inventory.Money _money;
        [SerializeField] private Inventory.Metal _metal; 
        [SerializeField] private GarageInventoryPlayer _garageInventoryPlayer; 

        private List<ShopCell> _createdCell = new List<ShopCell>();

        private void Start()
        {
            SetCell();
        }

        private void OnDestroy()
        {
            foreach (ShopCell cell in _createdCell)
            {
                cell.Byed -= TryBye;
            }
        }

        private void SetCell()
        {
            ShopCell cell = null;

            foreach (var item in _inventoryHashTable.ContentTable)
            {
                cell = Instantiate(item.Value.GetComponent<ShopCell>());
                cell.transform.localPosition = _placesForCell[_createdCell.Count].position;
                cell.transform.SetParent(_placesForCell[_createdCell.Count]);
                cell.SetID(item.Key);
                cell.Byed += TryBye;
                _createdCell.Add(cell);
            }
        }

        private void TryBye(int id, int moneyCoust, int metalCoust)
        {
            if (_money.Value > moneyCoust)
            {
                if (_metal.Value > metalCoust)
                {
                    if (_garageInventoryPlayer.PlaceInventory < _createdCell.Count)
                    {
                        _money.ChangeValue(-moneyCoust);
                        _metal.ChangeValue(-metalCoust);

                        _garageInventoryPlayer.AddCell(_inventoryHashTable.ContentTable[id], id);
                    }
                }
            }
        }
    }
}