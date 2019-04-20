﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpSpeed = 240f;
    public float forwardSpeed = 20f;

    private Rigidbody2D body2D;
    private InputState inputState;

    private void Awake()
    {
        body2D = GetComponent<Rigidbody2D>();
        inputState = GetComponent<InputState>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inputState.standing)
        {
            if (inputState.actionButton)
            {
                body2D.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
            }
        }
    }
}
