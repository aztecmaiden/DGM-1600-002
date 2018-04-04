using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public int value;
    public Color colorTint;
    private GameObject manager;
    private Manager myManager;

    private void Start()
    {
        myManager = FindObjectOfType<Manager>().GetComponent<Manager>();
    }
    

    private void OnTriggerEnter2D(Collider2D collider)
    {
        myManager.IncrementScore(value);
        Destroy(gameObject);
    }



}
