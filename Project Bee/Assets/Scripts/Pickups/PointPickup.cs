using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPickup : MonoBehaviour
{
    [SerializeField] int value;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.ModifyScore(value);
        Destroy(gameObject);
    }
}
