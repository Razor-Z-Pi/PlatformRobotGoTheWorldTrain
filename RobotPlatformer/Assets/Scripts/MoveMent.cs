using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveMent : MonoBehaviour
{
    public float speed;
    public Rigidbody2D _rigidbody2D;
    public float jumpForce;


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

    private void JumpUp() 
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody2D.AddForce(Vector2.up * (jumpForce * Time.deltaTime), ForceMode2D.Impulse);
        }
    }
    
    private void Update()
    {
        walk();
        JumpUp();
    }
}
