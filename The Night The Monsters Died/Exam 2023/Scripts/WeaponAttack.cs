using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    Animator animator;
    public static bool IsAttack=false;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (PickUp.isWeapon == true)
        {
            if (Input.GetButtonDown("Fire1")) 
            {
                animator.SetBool("Attack", true);
                IsAttack = true;
            }
            else if (Input.GetButtonUp("Fire1")) 
            {
                animator.SetBool("Attack", false);
                IsAttack = false;
            }
        }

}
}
