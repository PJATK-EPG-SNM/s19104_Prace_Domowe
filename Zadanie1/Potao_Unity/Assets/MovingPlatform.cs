using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2;

    //private bool col = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time * speed, 3), transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
    /*
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject == Player)
            {
                Player.transform.parent = transform;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject == Player)
            {
                Player.transform.parent = null;
                col = false;
            }
        }
        */
}
