using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int health;
    public Sprite[] sprite;

    public void Awake()
    {
        GameManager.brickCount++;
        print(GameManager.brickCount);
        GetComponent<SpriteRenderer>().sprite = sprite[0];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        GetComponent<SpriteRenderer>().sprite = sprite[health];

        //if our health gets to zero 
        if (health <= 0)
          Destroy(gameObject);
        GameManager.brickCount--;
        print(GameManager.brickCount);
        if(GameManager.brickCount == 0)
        {
            FindObjectOfType<GameManager>().LoadNextLevel();
        }
        //then destroy this object

    }
}