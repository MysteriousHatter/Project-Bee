using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class Score
{
    static int playerScore = 0;
    
    static public int GetScore()
    {
        return playerScore;
    }

    static public void ModifyScore(int mod)
    {
        playerScore += mod;
    }

    static public void ResetScore()
    {
        playerScore = 0;
        Debug.Log("Resetting Player Score...");
    }
}
