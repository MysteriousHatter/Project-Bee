using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PathFollower : MonoBehaviour
{
    WaveConfig waveConfig;
    [SerializeField] GameObject FX;
    private int waypointIndex = 0;
    List<Transform> wayPoints;



    private void Start()
    {
        wayPoints = waveConfig.GetWayPoints();
        transform.position = wayPoints[0].transform.position;
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {

        if (waypointIndex < wayPoints.Count)
        {
            if (wayPoints[waypointIndex] != null)
            {
                var targetPosition = wayPoints[waypointIndex].transform.position;
                var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
                transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);

                if (transform.position == targetPosition)
                {
                    waypointIndex++;
                }
            }
        }
        else Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayEffects();
        Score.ModifyScore(100);
        Destroy(gameObject);
    }

    void PlayEffects()
    {
        GameObject particals = Instantiate(FX, transform.position, Quaternion.identity);
        Destroy(particals, 2);
    }
}
