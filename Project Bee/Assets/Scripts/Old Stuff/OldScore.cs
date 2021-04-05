using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OldScore : MonoBehaviour
{
    [SerializeField] int pointsPerHit = 100;
    [SerializeField] int currentScore = 0;

    //private void Awake()
    //{
    //    int gameStatusCount = FindObjectsOfType<Score>().Length;
    //    if (gameStatusCount > 1)
    //    {
    //        gameObject.SetActive(false);
    //        Destroy(gameObject);
    //    }
    //    else
    //   {
    ///      DontDestroyOnLoad(gameObject);
    //    }
    //}

    public int GetScore()
    {
        return currentScore;
    }

    public void AddToScore()
    {
        currentScore += pointsPerHit;
    }

    public void ResetScore()
    {
        Debug.Log("Reseting...");
        Destroy(gameObject);
    }
}
