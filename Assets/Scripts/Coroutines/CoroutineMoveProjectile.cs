using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Coroutines
{
    public class CoroutineMoveProjectile
    {
        private static float _speed = 40f;

        public static IEnumerator MoveToTarget(Transform source, Vector3 direction)
        {
            float t = 0f;
            const float duration = 1.0f;

            while (t < 1)
            {
                Vector3 startPosition = source.position;
                startPosition += direction * t * Time.deltaTime * _speed;
                source.position = startPosition;
                t += Time.deltaTime / duration;

                yield return null;
            }

            source.gameObject.SetActive(false);
        }
    }
}