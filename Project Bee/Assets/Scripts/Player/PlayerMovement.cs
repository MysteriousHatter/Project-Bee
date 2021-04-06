using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour

{
    private float xInput;
    private float yInput;
    private Vector2 Bounds;
    private readonly float objectWidth;
    private readonly float objectHeight;
    [SerializeField] AudioClip buzzing;

    private void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(buzzing);
        Cursor.lockState = CursorLockMode.Confined;
        Bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal") * 4;
        yInput = Input.GetAxisRaw("Vertical") * 4;

        transform.position += new Vector3(xInput, yInput) * Time.deltaTime;
    }

    void LateUpdate()
    {
        Vector3 objectPosition = transform.position;
        objectPosition.x = Mathf.Clamp(objectPosition.x, -Bounds.x + objectWidth, Bounds.x - objectWidth);
        objectPosition.y = Mathf.Clamp(objectPosition.y, -Bounds.y + objectHeight, Bounds.y - objectHeight);
        transform.position = objectPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if ((collision.gameObject.tag == "Pickup") || (collision.gameObject.tag=="PlayerBullet")) {
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
