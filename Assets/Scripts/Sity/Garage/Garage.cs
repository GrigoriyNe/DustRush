using RoadTrane;
using UnityEngine;
using YG;

namespace Sity
{
    public class Garage : MonoBehaviour
    {
        [SerializeField] private ConstuctorTrane _constuctorTrane; 
        [SerializeField] private FabricTrane _fabricTrane;
        [SerializeField] private GarageInventoryPlayer _inventoryPlayer;

        private void OnEnable()
        {
            _constuctorTrane.ChangeView(true);
        }

        private void OnDisable()
        {
            _constuctorTrane.ChangeView(false);
            _fabricTrane.Save();
            _inventoryPlayer.Save();
            YG2.SaveProgress();
        }
    }
}