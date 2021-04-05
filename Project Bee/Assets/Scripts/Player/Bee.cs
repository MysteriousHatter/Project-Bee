using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    public Animator anim;
    Coroutine firingCoroutine;
    Coroutine hurtCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        Hurt();
    }
    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("Firing");
            firingCoroutine = StartCoroutine(fireContinuously());
        }
        if (Input.GetButtonUp("Fire1"))
        {
            anim.SetTrigger("CeaseFire");
            StopCoroutine(firingCoroutine);
        }

    }
    private void Hurt()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            anim.SetTrigger("Hurt");
            hurtCoroutine = StartCoroutine(reactToPain());
        }
        if (Input.GetButtonUp("Fire2"))
        {
            anim.SetTrigger("Recovered");
            StopCoroutine(hurtCoroutine);
        }

    }
    IEnumerator reactToPain()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
        }
    }
    IEnumerator fireContinuously()
    {
        while (true)
        {
            yield return new WaitForSeconds(.5f);
        }
    }
}
