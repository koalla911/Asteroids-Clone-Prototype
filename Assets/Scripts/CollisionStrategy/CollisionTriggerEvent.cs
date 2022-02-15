using UnityEngine;

namespace Assets.Scripts.CollisionStrategy
{
    public class CollisionTriggerEvent : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            collision.gameObject.GetComponent<ICollision>().Collide();
        }
    }
}