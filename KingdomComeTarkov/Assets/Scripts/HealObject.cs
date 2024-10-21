using System;
using UnityEngine;

public class HealObject : MonoBehaviour
{
    [SerializeField] private int healScore = 20;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<HealthSystem>())
        {
            other.gameObject.GetComponent<HealthSystem>().Healing(healScore);
            Destroy(this.gameObject);
        }
    }
}
