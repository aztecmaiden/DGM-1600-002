using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeveltoLoad : MonoBehaviour
{

    private Manager manager;
    public string level;

    private void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMovement>())
        {        
            manager.LoadLevel(level);
        }
    }
}
