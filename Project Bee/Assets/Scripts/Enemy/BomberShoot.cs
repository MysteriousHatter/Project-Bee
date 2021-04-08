using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberShoot : MonoBehaviour
{
    public Transform[] shootPosition;
    private BomberFollowScript toShoot;
    public GameObject bulletPre;
    float shotCounter;
    [SerializeField] float minTimeBetweenShots = 0.2f;
    [SerializeField] float maxTimeBetweenShots = 3f;

    // Start is called before the first frame update
    void Start()
    {
       // shootPosition.GetComponent<Transform>();
        shotCounter = UnityEngine.Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
        toShoot = GetComponent<BomberFollowScript>();
    }

    // Update is called once per frame
    void Update()
    {
        CountDownAndShoot();
        //Debug.Log(shotCounter);
    }

    private void CountDownAndShoot()
    {
        shotCounter -= Time.deltaTime;
        if (shotCounter <= 0f)
        {
            FireWeapons();
            shotCounter = UnityEngine.Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
        }
    }

    void FireWeapons()
    {
        if (this.gameObject.tag == "Bomb")
        {
            Debug.Log("Shoot");
            if (toShoot.canMove != false)
            {
                
                for (int i = 0; i < shootPosition.Length;i++)
                {
                   
                    GameObject eneBlast = Instantiate(bulletPre, shootPosition[i].position, shootPosition[i].rotation) as GameObject;
                    //eneBlast.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -15);
                }
            }
        }
        else if (this.gameObject.tag == "Bomb(G)")
        {
            if (toShoot.canMove != false)
            {

                for (int i = 0; i < shootPosition.Length; i++)
                {
                    GameObject eneBlast = Instantiate(bulletPre, shootPosition[i].position, shootPosition[i].rotation) as GameObject;
                   // eneBlast.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -15);
                }
            }
        }


    }
}
