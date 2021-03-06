using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private readonly float projectileSpeed = 15f;

    void Update()
    {
        transform.position -= new Vector3(projectileSpeed, 0) * Time.deltaTime;
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
