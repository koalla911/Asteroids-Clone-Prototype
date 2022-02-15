using UnityEngine;

namespace Assets.Scripts.CollisionStrategy
{
    public class CollisionBound : MonoBehaviour, ICollision
    {
        public delegate void ScreenBoundCollide();
        public static event ScreenBoundCollide OnScreenBoundCollide;

        public void Collide()
        {
            OnScreenBoundCollide?.Invoke();
        }

    }
}