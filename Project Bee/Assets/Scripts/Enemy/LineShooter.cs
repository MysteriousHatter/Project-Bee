using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I don't know if I chose the best name for this, but this script makes enemies shoot directly left of their current position
public class LineShooter : MonoBehaviour
{
    public GameObject bullet;
    private bool ableToFire = true;

    // Update is called once per frame
    void Update()
    {
        if (ableToFire == true)
        {
            StartCoroutine(FireWeapons());
        }
    }

    IEnumerator FireWeapons()
    {
        ableToFire = false;
        GameObject enemyBlast = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        //enemyBlast.GetComponent<Rigidbody2D>().velocity = new Vector2(15.0f, 0);
        yield return new WaitForSeconds(2f);
        ableToFire = true;
        
        //allowFire = false;
        //Debug.Log("Pew!");
        //GameObject _1 = Instantiate(bullet, transform.position, transform.rotation);

        //allowFire = true;
    }
}