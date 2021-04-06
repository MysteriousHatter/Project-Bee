using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] float timeRemaining;
    [SerializeField] float initialTime;
    Text[] allText;
    Text timerText;

    void Start() {
        timeRemaining = initialTime;
        allText = FindObjectsOfType<Text>();
        for (int i = 0; i < allText.Length; i++) {
            if (allText[i].name == "TimerText") {
                timerText = allText[i];
            }
        }
        timerText.text = timeRemaining.ToString("0.00");
        timerText.color = Color.yellow;
        //timerText.fontSize = 45;
    }

    void Update() {
        if (timeRemaining > 1) {
            timeRemaining -= Time.deltaTime;
            timerText.text = timeRemaining.ToString("0.00");
        }
        else if (timeRemaining > 0) {
            timerText.color = Color.red;
            //timerText.fontSize = 45;
            timeRemaining -= Time.deltaTime;
            timerText.text = timeRemaining.ToString("0.00");
        }
        else {
            timeRemaining = 0;
        }
    }

    public float getGameTime() {
        return timeRemaining;
    }

    public void resetGameTimer() {
        timeRemaining = 0;
    }
}
