using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageForPlayer : MonoBehaviour
{
    public int damageCount = 10;


    void Start()
    {
        
    }

    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(FindObjectOfType<PlayerManager>().Damage(damageCount));

    }
}
