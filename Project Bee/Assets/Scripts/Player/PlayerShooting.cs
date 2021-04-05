using System.Collections;
using UnityEditor;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    private bool allowFire = false;

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            allowFire = true;
            StartCoroutine(FireWeapons());
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            allowFire = false;
            StopCoroutine(FireWeapons());
            
        }
    }

    IEnumerator FireWeapons()
    {

        while(allowFire)
        {
            GameObject beeBlast = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            beeBlast.GetComponent<Rigidbody2D>().velocity = new Vector2(15.0f, 0);
            yield return new WaitForSeconds(0.25f);
        }
        //allowFire = false;
        //Debug.Log("Pew!");
        //GameObject _1 = Instantiate(bullet, transform.position, transform.rotation);

        //allowFire = true;
    }
}