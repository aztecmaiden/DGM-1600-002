using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static int brickCount;
    
    public static GameManager instance = null;

    // Use this for initialization
    void Awake()
    {
        Screen.fullScreen = !Screen.fullScreen;
        if (instance == null)                               
        {
            //then assign instance to this object
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(this.gameObject);

            //then destroy this object
        }

        DontDestroyOnLoad(this.gameObject);
    }


    public void LoadLevel(string level)
    {
        brickCount = 0;
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel()
    {
        brickCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
