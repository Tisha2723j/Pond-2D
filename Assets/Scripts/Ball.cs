using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
using Random = UnityEngine.Random; // Import UnityEngine's Random class

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        Launch();
    }
    
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch()
    {
        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1; 
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1; 
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}