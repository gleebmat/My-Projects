using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static float HP = 100f;
    public Animator animator;
    public static bool IsDead = false;
    public AudioSource source;
    public AudioClip walk;
    public AudioClip run;
    public AudioClip death;

    private void Start()
    {
        IsDead = false;
    }


    void Update()
    {
        if (HP <= 0 && IsDead == false)
        {
            animator.SetTrigger("Death");
            //GetComponent<Collider>().enabled = false;
            IsDead = true;
            Destroy(gameObject, 5f);
        }
        if (Enemy.IsDead == true)
        {
            //GetComponent<Collider>().enabled = false;
        }


    }

    public void TakeDamage(float damageAmount)
    {
        if (PickUp.isWeapon == true)
        {
            HP -= damageAmount;
            if (HP <= 0)
            {

                animator.SetTrigger("Death");
                //GetComponent<Collider>().enabled = false;
                IsDead = true;
                Destroy(gameObject, 5f);
            }
            else
            {
                animator.SetTrigger("Damage");
            }
        }
        if (PickUp.isGun == true)
        {
            HP -= damageAmount;
            if (HP <= 0)
            {
                animator.SetTrigger("Death");
                //GetComponent<Collider>().enabled = false;
                IsDead = true;
                print("oh");
                Destroy(gameObject, 5f);
            }
            else
            {
                animator.SetTrigger("Damage");
            }
        }
        if(PickUp.isShotGun==true)
        {
            HP -= damageAmount;
            if (HP <= 0)
            {
                animator.SetTrigger("Death");
                //GetComponent<Collider>().enabled = false;
                IsDead = true;
                print("wow");
                Destroy(gameObject, 5f);
            }
            else
            {
                animator.SetTrigger("Damage");
            }
        }
        if(PickUp.isPistol==true)
        {
            HP -= damageAmount;
            if(HP<=0)
            {
                animator.SetTrigger("Death");
                //GetComponent<Collider>().enabled = false;
                IsDead = true;
                print("yarrr");
                Destroy(gameObject, 5f);
            }
            else
            {
                animator.SetTrigger("Damage");
            }
        }





    }

}
