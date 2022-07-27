using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveMent : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void walk()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody2D.velocity = Vector2.left * speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody2D.velocity = Vector2.right * speed; 
        }
    }

    private void Update()
    {
        walk();
    }
}
