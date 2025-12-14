using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyGroup
{
    public class EnemyFactory : MonoBehaviour
    {
        [SerializeField] private int _enemiesInPool;
        [SerializeField] private List<Enemy> _enemyPrefabs;

        private EnemyPool _enemyPool;
        private List<EnemyPool> _readyMadeEnemiesPools = new List<EnemyPool>();

        public List<EnemyPool> ReadyMadeEnemiesPools => _readyMadeEnemiesPools;

        private void OnEnable()
        {
            CreateEnemyPools();
        }

        private void CreateEnemyPools()
        {
            foreach (var enemy in _enemyPrefabs)
            {
                _enemyPool = new EnemyPool(enemy);
                _enemyPool.CreateEnemy(_enemiesInPool);
                _readyMadeEnemiesPools.Add(_enemyPool);
                Debug.Log(_readyMadeEnemiesPools);
            }
        }
    }
}