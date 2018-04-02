using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour {

    public ParticleSystem deathParticle;
    public Health healthScript;

    private void Start()
    {
        healthScript = GetComponent<Health>();
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        healthScript.health--;
        if (healthScript.health <= 0)
        {
            //die
            //play death particle
            ParticleSystem particle= Instantiate(deathParticle, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
