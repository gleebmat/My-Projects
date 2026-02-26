using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Player : MonoBehaviour
{
    public static List<int> scores = new List<int>();
    Animator anim;
    Rigidbody2D rb;
    int move = 0;


    Vector3 size, inverseSize;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        inverseSize = size = transform.localScale;
        inverseSize.x *= -1;

    }

    void Update()
    {
       if(rb.velocity.y==0)
       {
            anim.SetBool("jump", false);
       }
       else
       {
            anim.SetBool("jump", true);
       }
    }
    private void FixedUpdate()
    {
       if(Input.GetKey(KeyCode.A))
       {
            rb.transform.Translate(Vector2.right * Time.fixedDeltaTime * -5);
       }

        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Translate(Vector2.right * Time.fixedDeltaTime * 5);
        }


        rb.transform.Translate(Vector2.right * Time.deltaTime * move);
    }


    public void Setmovement(int move)
    {
        this.move = move;

        if (move > 0)
        {
            transform.localScale = size;
        }
        if (move < 0)
        {
            transform.localScale = inverseSize;
        }

        anim.SetInteger("move", move);
    }

    public void Jump()
    {
        if (rb.velocity.y == 0)
        {
            rb.velocity = new Vector2(0, 10);
        }
    }
}
