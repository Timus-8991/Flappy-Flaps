﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbird : MonoBehaviour {

	const float force = 200f;
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
    // Use this for initialization
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, force));
                anim.SetTrigger("Flap_Trigger");
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        anim.SetTrigger("Die_Trigger");
        GameControlScript.instance.onBirdDied();
    }
}
