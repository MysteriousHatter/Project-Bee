using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene() {
        int currIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currIndex + 1);
    }

    public void LoadGameOverScene() {
        SceneManager.LoadScene("GameOverScene");
    }

    public string getSceneName() {
        return SceneManager.GetActiveScene().name;
    }


    public void LoadStartScene() {
        //FindObjectOfType<TrackPoints>().resetPoints();
        SceneManager.LoadScene(0);
    }
}
