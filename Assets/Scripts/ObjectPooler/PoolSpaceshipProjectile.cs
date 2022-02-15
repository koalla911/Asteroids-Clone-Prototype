using Assets.Scripts.Coroutines;
using UnityEngine;

namespace Assets.Scripts.ObjectPooler
{
    public class PoolSpaceshipProjectile : MonoBehaviour
    {
        [SerializeField] private Projectile _prefab;
        [SerializeField] private Transform _activatePoint;
        [SerializeField] private int _poolCount = 10;
        [SerializeField] private bool _autoExpand = false;

        private PoolMono<Projectile> _pool;


        private void OnEnable()
        {
            SpaceshipActionEvents.OnProjectileShootingEvent += ShootActivate;
        }


        private void Awake()
        {
            _pool = new PoolMono<Projectile>(_prefab, _poolCount, transform, _autoExpand);
        }


        private void ShootActivate()
        {
            Projectile projectileActive = _pool.GetFreeElement();
            StartCoroutine(CoroutineMoveProjectile.MoveToTarget(projectileActive.gameObject.transform, gameObject.transform.up));
            projectileActive.transform.position = _activatePoint.position;
        }


        private void OnDisable()
        {
            SpaceshipActionEvents.OnProjectileShootingEvent -= ShootActivate;
        }
    }
}