using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DamageStrategy
{
    public class DamageSmallObject : MonoBehaviour, IDamagable
    {
        public void ApplyDamage()
        {
            gameObject.SetActive(false);
        }

    }
}