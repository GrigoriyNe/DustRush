using System;
using System.Collections;
using System.Collections.Generic;
using Pool;

namespace EnemyGroup
{
    public class EnemyPool
    {
        private Enemy _enemyPrefab;
        private Pool<Enemy> _enemyPool;

        private List<Enemy> _createdEnemies = new List<Enemy>();

        public EnemyPool(Enemy prefab)
        {
            _enemyPrefab = prefab;
        }

        public List<Enemy> CreateEnemy(int count)
        {
            SetEnemy(_enemyPrefab);
            FillEnemiesPool(count);
            return _createdEnemies;
        }

        public Enemy GetEnemy()
        {
            return _enemyPool.GetItem() as Enemy;
        }

        public void ReturnToPool(Enemy enemy)
        {
            _enemyPool.ReturnItem(enemy);
        }

        private void SetEnemy(Enemy enemyPrefab)
        {
            _enemyPool = new Pool<Enemy>(enemyPrefab);
        }

        private void FillEnemiesPool(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Enemy enemy = _enemyPool.GetItem() as Enemy;
                enemy.gameObject.SetActive(false);

                _createdEnemies.Add(enemy);
            }
        }
    }
}