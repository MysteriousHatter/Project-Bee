using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberShoot : MonoBehaviour
{
    public Transform shoot1, shoot2, shoot3;
    public BomberFollowScript toShoot;
    public GameObject bulletPre;

    // Start is called before the first frame update
    void Start()
    {
        shoot1.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Bomb")
        {
            if (toShoot.canMove != false)
            {
                //Debug.Log("Shoot");
                GameObject enemyBlast = Instantiate(bulletPre, shoot1.position, shoot1.rotation) as GameObject;
                GameObject enemyBlast2 = Instantiate(bulletPre, shoot2.position, shoot2.rotation) as GameObject;
                GameObject enemyBlast3 = Instantiate(bulletPre, shoot3.position, shoot3.rotation) as GameObject;
                enemyBlast3.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -900f);
                enemyBlast2.GetComponent<Rigidbody2D>().velocity = new Vector2(-15.0f, 0);
                enemyBlast.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -900f);
            }
        }
        else if(this.gameObject.tag == "Bomb(G)")
        {
            if (toShoot.canMove != false)
            {
                GameObject eneBlast = Instantiate(bulletPre, shoot1.position, shoot1.rotation) as GameObject;
                eneBlast.GetComponent<Rigidbody2D>().AddForce(-transform.up * 14f, ForceMode2D.Impulse);
            }
        }
    }
}
