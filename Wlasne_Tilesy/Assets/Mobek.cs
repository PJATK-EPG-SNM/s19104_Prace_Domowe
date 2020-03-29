using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobek : MonoBehaviour
{
    public float speed = 1;
    private float xPos = 0;
    public float xDestianation = 0;

    
    void Start()
    {
        xPos = transform.position.x;
        xDestianation = xDestianation - xPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time * speed , xDestianation) + xPos, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
