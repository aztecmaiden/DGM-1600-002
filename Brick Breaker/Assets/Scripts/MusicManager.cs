using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager instance = null;


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
}