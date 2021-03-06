﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {

    public enum Power { Health, Speed, Damage, Poison};
    public Power powerupType;
    private SpriteRenderer rend;
    public Sprite[] images;
    public Animator animator;
    public Animation[] graphics;



	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>();
        Debug.Log(rend);
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (powerupType)
        {
            case Power.Health:
                rend.sprite = images[0];
                break;
            case Power.Damage:
                rend.sprite = images[1];
                break;

        }

        
		
	}
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            switch (powerupType)
            {
                case Power.Health:
                    collider.GetComponent<Health>().IncrementHealth(5);
                    break;
                case Power.Damage:
                    
                    break;
            }
            Destroy(gameObject);
        }
    }
}
