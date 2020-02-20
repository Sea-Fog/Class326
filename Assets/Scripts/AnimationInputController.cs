﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class AnimationInputController : MonoBehaviour
{
    public Animator animator;
    public Transform characterTransform;
    public Rigidbody rb;
    public float speed = 3;
    public float jump = 5;
    public bool onGround = false;
    private float lastYFrame = 0;
    enum AnimationParameters
    {
        forwardMovement
    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardMovement = Input.GetAxis("Horizontal");
        onGround = Vector3.Dot(rb.velocity, Vector3.up) < .01;
        if (onGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jump;
        }

        if (forwardMovement != 0)
        {
            float y = (forwardMovement < 0) ? 180 : 0;
            Vector3 input = new Vector3(0, y, 0);
            characterTransform.eulerAngles = input;
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed * forwardMovement);
        }

        else
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0);
        }

        animator.SetFloat(AnimationParameters.forwardMovement.ToString(), Mathf.Abs(forwardMovement));
    }
}
