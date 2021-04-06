using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    [SerializeField] TimerScript gameTimer;
    [SerializeField] SceneLoader sceneLoader;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameTimer.getGameTime() <= 0) {
            StartCoroutine(WaitForTimeNext());
        }
        /* 
         if(player dies) {
           StartCoroutine(WaitForTimeLose());
           sceneLoader.LoadGameOverScene();
         */
    }

    IEnumerator WaitForTimeNext() {
        yield return new WaitForSeconds(.3f);
        sceneLoader.LoadNextScene();
    }

    IEnumerator WaitForTimeLose() {
        yield return new WaitForSeconds(.3f);
        sceneLoader.LoadGameOverScene();
    }

}
