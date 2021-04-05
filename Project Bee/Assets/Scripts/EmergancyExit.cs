using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmergancyExit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            EmergencyExit();
        if (Input.GetKey(KeyCode.R))
            Restart();
    }
    public void EmergencyExit() => Debug.Break();
    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
}
