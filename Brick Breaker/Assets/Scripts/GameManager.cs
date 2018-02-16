using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;


    // Use this for initialization
    void Awake()
    {
        //Singleton
        if (instance == null)
        {
            instance = this;                    //if instance is not assigned                      
        }
        else if (instance != this)              //then assign instance to this object
        {
            Destroy(this.gameObject);           //then destroy this object
        }

        DontDestroyOnLoad(this.gameObject);
    }


    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }


}