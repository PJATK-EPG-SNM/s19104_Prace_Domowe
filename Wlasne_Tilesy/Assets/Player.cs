using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 750;
    private float jump = 360;

    private Rigidbody2D rb;
    private bool isGrounded;
    public bool Destroyed = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown("space") && isGrounded == true)
        {
            rb.AddForce(new Vector2(0, jump));
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Collide")
        {
            isGrounded = true;

        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "WaterCollider")
        {
            rb.gravityScale = 0.2f;
            jump = 100;
            speed = 200;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WaterCollider")
        {
            rb.gravityScale = 2;
            jump = 360;
            speed = 750;
        }
    }
}
