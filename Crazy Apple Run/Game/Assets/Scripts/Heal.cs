using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Heal : Heartsystem
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag=="Player")
        {
            if(Heartsystem.health <= 2)
            {
              Heartsystem.health += 1;
              Destroy(gameObject);
            }
            else 
            {
                Destroy(gameObject);
            }
                       
        }
    }
}
