using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeveltoLoad : MonoBehaviour {

    public string level;
    public Manager manager;


    private void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<PlayerMovement>())
        {
            //Game Over
            Debug.Log("GameOver");
            manager.LoadLevel(level);
        }
    }
}
