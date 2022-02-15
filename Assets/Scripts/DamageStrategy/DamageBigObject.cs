using Assets.Scripts.ObjectPooler;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DamageStrategy
{
    public class DamageBigObject : MonoBehaviour, IDamagable
    {
        [SerializeField] private SpriteRenderer _sprite;
        [SerializeField] private BoxCollider2D _collider;
        [SerializeField] private DamageSmallObject _prefab;
        [SerializeField] private int _poolCount = 10;

        private bool _autoExpand = false;
        private Transform _activatePoint;
        private float _offsetPosition = 2;

        private PoolMono<DamageSmallObject> _pool;


        private void Awake()
        {
            _pool = new PoolMono<DamageSmallObject>(_prefab, _poolCount, transform, _autoExpand);
            _activatePoint = gameObject.transform;
        }


        public void ApplyDamage()
        {
            _sprite.enabled = false;
            _collider.enabled = false;
            ActivateSmallObjects();
        }


        private void ActivateSmallObjects()
        {
            for (int i = 0; i < _poolCount; i++)
            {
                Vector3 offset = new Vector3(Random.Range(-_offsetPosition, _offsetPosition), Random.Range(-_offsetPosition, _offsetPosition), 0);
                DamageSmallObject smallActive = _pool.GetFreeElement();
                smallActive.transform.position = _activatePoint.position + offset;
            }
        }
    }
}