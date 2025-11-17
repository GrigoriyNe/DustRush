using System.Collections;
using UnityEngine;

namespace RoadTrane
{
    public abstract class TranePart : MonoBehaviour
    {
        private const float MaxDelay = 3f;
        private const float MinDelay = 1f;

        private const float MinDirectionVibration = -0.15f;
        private const float MaxDirectionVibration = 0.15f;

        private float _randomStartDelayValue;
        private float _randomDirectionValue;
        private float _reternValue = 0.2f;

        private WaitForSeconds _waitVibration;
        private WaitForSeconds _waitReternVibration;

        private void OnEnable()
        {
            _waitReternVibration = new WaitForSeconds(_reternValue);
            Vibration();
            OnEnabled();
        }

        public abstract void OnEnabled();

        private void Vibration()
        {
            _randomStartDelayValue = Random.Range(MinDelay, MaxDelay);
            _waitVibration = new WaitForSeconds(_randomStartDelayValue);

            StartCoroutine(Virationing());
        }

        private IEnumerator Virationing()
        {
            float randomDirection;

            randomDirection = Random.Range(MinDirectionVibration, MaxDirectionVibration);

            yield return _waitVibration;

            transform.position = new Vector2(
                randomDirection,
                transform.position.y);

            yield return _waitReternVibration;

            transform.position = new Vector2(
                0,
                transform.position.y);

            Vibration();
        }
    }
}