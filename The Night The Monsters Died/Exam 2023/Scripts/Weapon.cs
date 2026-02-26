using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageAmount = 20;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy"&&WeaponAttack.IsAttack==true)
        {
            other.GetComponent<Enemy>().TakeDamage(damageAmount);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
