using Assets.Scripts.ObjectPooler;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class AsteroidSpawner : MonoBehaviour
    {
        [SerializeField] private Enemy[] _enemies;
        [SerializeField] private int _poolCount = 20;
        [SerializeField] private bool _autoExpand = false;
        [SerializeField] private float _spawnRadius = 15f;

        [SerializeField] private GameObject _gameArea;

        public float _disactivateRadius = 18f;

        public float _maxSpeed = 1.0f;
        public float _minSpeed = 0.75f;


        private WaitForSeconds _waitTime = new WaitForSeconds(1f);
        private int _asteroidPerSecond = 1;
        private Vector3 _randomizePosition;
        private PoolSeveral<Enemy> _pool;
        

        private void Awake()
        {
            _randomizePosition = Vector3.zero;
            _pool = new PoolSeveral<Enemy>(_enemies, _poolCount, transform, _autoExpand);
        }

        private void Start()
        {
            StartCoroutine(SpawnEnemies());
        }


        private IEnumerator SpawnEnemies()
        {
            for (int i = 0; i < _asteroidPerSecond; i++)
            {
                InitialPopulation();
                i--;

                yield return _waitTime;
            }
        }

        private void InitialPopulation()
        {
            Enemy enemy = _pool.GetFreeElement();

            Vector3 position = RandomPosition.GetRandomPosition(false, _randomizePosition, _spawnRadius, _gameArea);

            AddEnemy(position, enemy);
        }


        private void AddEnemy(Vector3 position, Enemy enemy)
        {
            enemy.gameObject.transform.position = position;
            enemy.gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, (_gameArea.transform.position - position));

            enemy._spawner = this;
            enemy.game_area = _gameArea;
            enemy.speed = Random.Range(_minSpeed, _maxSpeed);

        }
    }
}