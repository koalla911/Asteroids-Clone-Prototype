using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class RandomPosition : MonoBehaviour
    {
        public static Vector3 GetRandomPosition(bool isWithinCamera, Vector3 randomizedPosition, float spawnRadius, GameObject gameArea)
        {
            randomizedPosition = Random.insideUnitCircle;

            if (isWithinCamera == false)
            {
                randomizedPosition = randomizedPosition.normalized;
            }

            randomizedPosition *= spawnRadius;
            randomizedPosition += gameArea.transform.position;

            return randomizedPosition;
        }
    }
}