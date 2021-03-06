﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public AudioSource movementSound;
    [SerializeField]
    public AudioSource bgMusic;
    public AudioSource lullaby;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Scene4")
        {
            bgMusic.Stop();
            if(!lullaby.isPlaying)
            {
                lullaby.Play();
            }
        }
    }

    void FixedUpdate()
    {
         if(Input.GetButton("Horizontal"))
         {
             if(!movementSound.isPlaying)
             {
                 movementSound.Play();
             }
         }
         else
         {
             movementSound.Stop();
         }

        Vector3 vel = rb.velocity;
        vel.x = Input.GetAxis("Horizontal") * 10;

        rb.velocity = vel;
        Vector3 scale = gameObject.transform.localScale;

        if(rb.velocity.x * scale.x < 0)
        {
            scale.x *= -1;
            gameObject.transform.localScale = scale;
        }
    }
}
