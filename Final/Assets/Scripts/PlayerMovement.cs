using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D rigid;
    public float speed;
    private Animator anim;
    private SpriteRenderer rend;
    public float jump;
    private bool isGrounded;
    public LayerMask groundLayer;

    [Space(20)]
    public float shootDistance;
    public float minDistance;
    public float maxDistance;
    private bool lookLeft;
    public Vector3 offset;
    public Color shootColor;
    private LineRenderer lineRenderer;
    public float shootTime;




    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //check for button pushes

        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        anim.SetFloat("HorizontalGo", Input.GetAxisRaw("Horizontal"));
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
        if (Input.GetButtonDown("Jump"))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 2.0f, 8);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "Ground")
                {
                    isGrounded = true;
                    Debug.Log("found ground");
                }
                else
                {
                    isGrounded = false;
                    Debug.Log("no ground");
                }
            }
        }
    }
    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.5f;

        Debug.DrawRay(position, direction, Color.green, 0.25f);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    void Shoot()
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



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = false;
        }
    }
    public void ExampleDealDamage()
    {

    }
}

