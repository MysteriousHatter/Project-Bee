using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private readonly float projectileSpeed = 20f;

    void Update()
    {
        transform.position += new Vector3(projectileSpeed, 0) * Time.deltaTime;
        Destroy(gameObject,2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Pickup") || (collision.gameObject.tag == "Player"))
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
