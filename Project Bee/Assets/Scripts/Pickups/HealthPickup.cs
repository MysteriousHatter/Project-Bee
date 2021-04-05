using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] int addedHealth;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth.AddPlayerHealth(addedHealth);
        Destroy(gameObject);
    }
}
