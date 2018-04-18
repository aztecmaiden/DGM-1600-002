using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public ParticleSystem deathParticle;
    private Container container = null;

    private void Start()
    {
        if (GetComponent<Container>())
        {
            container = GetComponent<Container>();
        }
    }


    public void IncrementHealth(int amount)
    {
        health += amount;
        if (health <= 0)
        {
            Die();
            //do something
        }
    }

    public void Die() {
        Destroy(gameObject);

        if (deathParticle != null)
        {
            ParticleSystem particle = Instantiate(deathParticle, gameObject.transform.position, Quaternion.identity);
            Destroy(particle, particle.main.duration);
        }
        if (container != null)
        {
            container.Drop();

        }
    }
}












