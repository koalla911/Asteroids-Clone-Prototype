using Assets.Scripts.DamageStrategy;
using UnityEngine;

namespace Assets.Scripts.CollisionStrategy
{
    public class CollisionObstacle : MonoBehaviour, ICollision
    {
        /*public delegate void ObstacleCollide();
        public static event ObstacleCollide OnObstacleCollide;*/

        private IDamagable _obstacle;


        private void Awake()
        {
            _obstacle = gameObject.GetComponent<IDamagable>();
        }


        public void Collide()
        {
            //OnObstacleCollide?.Invoke();
            _obstacle.ApplyDamage();
        }

    }
}