using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;

    public float moveSpeed = 5;
    public float ballVerticalImpulse = 2;

    private Vector3 movement;

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(upKey))
        {
            movement = new Vector3(0f, 1f, 0f);
        }
        else if (Input.GetKey(downKey))
        {
            movement = new Vector3(0f, -1f, 0f);
        }
        else
        {
            movement = new Vector3(0f, 0f, 0f);
        }

        GetComponent<Rigidbody2D>().transform.position = GetComponent<Rigidbody2D>().transform.position + movement * moveSpeed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            // distance of the colision, from the center of the paddle [-1, 1]
            float relDist = -(transform.position.y - collision.GetContact(0).point.y) / (GetComponent<BoxCollider2D>().bounds.size.y / 2);

            collision.rigidbody.velocity += new Vector2(0f, relDist * ballVerticalImpulse);
        }
    }
}