using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
  
    }
    private void FixedUpdate()
    {
       
    }
   
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-20,20), Random.Range(7,12));
            Heartsystem.health -= 1;
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Background"))
        {
            gameObject.GetComponent<Collider2D>().enabled=false;
            anim.SetBool("IsGround", true);
        }

    }

}
