using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Enemy : MonoBehaviour
    {
        public AsteroidSpawner _spawner;
        public GameObject game_area;
        public float speed;

        private void Update()
        {
            transform.position += transform.transform.up * (speed * Time.deltaTime);
            float distance = Vector3.Distance(transform.position, game_area.transform.position);
            if (distance > _spawner._disactivateRadius)
            {
                Disactivate();
            }
        }

        private void Disactivate()
        {
            gameObject.SetActive(false);
        }
    }
}