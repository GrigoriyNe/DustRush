using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    //[RequireComponent(typeof(Weapon))]
    public class AimState : State
    {
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _rotationSpeed = 180f;
        [SerializeField] private float _angleOffset = 0f;
        //[SerializeField] private float _shootDelay;

        private Transform _target;
        //private Weapon _weapon;
        //private float _shootElapsedTime = 0f;

        //private void Awake()
        //{
        //    _weapon = GetComponent<Weapon>();
        //}

        private void OnEnable()
        {
            _target = Enemy;
            SetEnemyTransform(_target);
        }

        private void Update()
        {
            if (_target == null) return;

            Vector3 direction = _target.position - _barrel.position;

            float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            targetAngle += _angleOffset;

            float currentAngle = _barrel.eulerAngles.z;
            float newAngle = Mathf.MoveTowardsAngle(currentAngle, targetAngle, _rotationSpeed * Time.deltaTime);

            _barrel.rotation = Quaternion.Euler(0f, 0f, newAngle);

            //Shoot();
        }

        //private void Shoot()
        //{
        //    _shootElapsedTime += Time.deltaTime;
        //    if (_shootElapsedTime >= _shootDelay)
        //    {
        //        _weapon.Shoot();
        //        _shootElapsedTime = 0f;
        //    }
        //}
    }
}