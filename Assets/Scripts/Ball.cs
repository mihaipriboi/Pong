using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Vector2 startDir;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = startDir * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
