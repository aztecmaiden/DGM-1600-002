using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public GameObject[] items;
    public bool burst;
    [Range(100, 1000)]
    public float burstPower;
    

    public void Drop()
    {
        for (int i = 0; i < items.Length; i++)
        {
            GameObject item = Instantiate(items[i], gameObject.transform.position, Quaternion.identity);
            //make sure item has rigidbody
            if (item.GetComponent<Rigidbody2D>())
            {
                item.AddComponent<Rigidbody2D>();
            }
            //make sure item collider is not trigger
            if (item.GetComponent<Collider2D>())
            {
                item.AddComponent<CapsuleCollider2D>();
            }
            else
            {
                item.GetComponent<Collider2D>().isTrigger = false;
            }
            if (burst) {
                item.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-burstPower, burstPower),Random.Range(-100, 100)));
            }
        }
    }
}
