using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberFollowScript : MonoBehaviour
{
    [SerializeField] WaveConfig waveConfig;
    List<Transform> waypoints;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] int waypointIndex = 0;


    [SerializeField] public bool canMove = true;
    [SerializeField] int whenToGo = 4;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        waypoints = waveConfig.GetWayPoints();
        transform.position = waypoints[0].transform.position;
        animator = gameObject.GetComponent<Animator>();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.canMove == true) { MOve(); }
    }

    private void MOve()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointIndex].transform.position;
            targetPosition.z = 0.0f;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);

            if (transform.position == targetPosition)
            {
                StartCoroutine(WaitToGo(whenToGo));
                waypointIndex++;
            }

        }
        else
        {
            Destroy(gameObject);
        }
    }

    IEnumerator WaitToGo(int seconds)
    {
        this.canMove = false;
        animator.SetBool("toAttack", this.canMove);
        int counter = seconds;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }

        this.canMove = true;
        animator.SetBool("toAttack", this.canMove);
    }
}
