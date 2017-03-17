using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevel;

    private void Start()
    {
        if (autoLoadNextLevel <= 0)
            Debug.Log("Need a positive number");
        else
            Invoke("LoadNextLevel", autoLoadNextLevel);
    }


    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void quitRequest()
    {

    
    }

}
