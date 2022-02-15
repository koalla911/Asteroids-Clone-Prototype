using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Coroutines
{
    public class CoroutineMoveRandom
    {
        public static IEnumerator Movement(Transform source, float speed)
        {
            Vector3 direction = new Vector3(Random.Range(-2, 3), Random.Range(-1, 1), 0f);

            while (source.gameObject.activeInHierarchy)
            {
                source.position += source.transform.up * (speed * Time.deltaTime);

                yield return null;
            }
        }
    }
}