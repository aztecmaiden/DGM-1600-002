using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {

    public enum Power { Health, Speed};
    public Power powerupType;
    private SpriteRenderer rend;
    public Sprite[] images;




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
            case Power.Speed:
                rend.sprite = images[1];
                break;
         }
		
	}
}
