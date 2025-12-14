using System;
using UnityEngine;

namespace EnemyGroup
{
    [RequireComponent(typeof(Common.Health))]
    public class Enemy : MonoBehaviour
    {
        private void Update()
        {
            transform.Translate(Vector3.up * 1f * Time.deltaTime);
        }
    }
}