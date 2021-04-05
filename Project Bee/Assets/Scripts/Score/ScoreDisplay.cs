using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{   
    [SerializeField] private Text scoreText;
    private int playerScore;
    void Update()
    {
        playerScore = Score.GetScore();

        scoreText.text = playerScore.ToString();
    }
}
