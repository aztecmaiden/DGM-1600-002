using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoveling : MonoBehaviour {
    [Space(10), Header ("Shoveling Stuffs")]
    public float shootDistance;
    public float minDistance;
    public float maxDistance;
    private bool lookLeft;
    public Vector3 offset;
    public Color shootColor;
    private LineRenderer lineRenderer;
    public float shootTime;
    private Animator anim;
    private SpriteRenderer rend;



    // Use this for initialization
    void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Horizontal") > -0.1f)
        {
            //flip sprite renderer
            rend.flipX = true;
            lookLeft = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0.1f)
        {
            //unflip
            rend.flipX = false;
            lookLeft = false;
        }
        if (Input.GetButton("Fire1"))
    {
        anim.SetTrigger("ShootGo");
        Shoot();

    }

}
    public void Shoot()
    {
        Vector2 position = transform.position;
        // figure out direction
        Vector2 direction;
        if (lookLeft)
        {
            direction = Vector2.left;
            //if we're looking left, modify position
            position += new Vector2(-0.5f, 0);
            lineRenderer.SetPosition(0, new Vector3(-0.5f, 0, 0));
            lineRenderer.SetPosition(1, new Vector3(-10.5f, 0, 0));
        }
        //or shift it right
        else
        {
            direction = Vector2.right;
            position += new Vector2(0.5f, 0);
            lineRenderer.SetPosition(0, new Vector3(0.5f, 0, 0));
            lineRenderer.SetPosition(1, new Vector3(10.5f, 0, 0));

            Debug.DrawRay(position, direction, Color.red, 0.25f);
            lineRenderer.enabled = true;
            RaycastHit2D hit = Physics2D.Raycast(position, direction, shootDistance);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.GetComponent<Health>())
                {
                    hit.collider.GetComponent<Health>().IncrementHealth(-1);
                }
            }
        }
        StartCoroutine(LaserOff());
    }
    IEnumerator LaserOff()
    {
        yield return new WaitForSeconds(shootTime);
        lineRenderer.enabled = false;
    }

}
