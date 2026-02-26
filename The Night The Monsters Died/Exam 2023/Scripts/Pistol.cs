using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public int damage = 20;
    public float fireRate = 10f;
    public float range = 100f;
    public Transform bulletSpawn;
    [SerializeField] Camera cam;
    public ParticleSystem effect;
    public AudioClip clip;
    public AudioSource source;
    float nextFire = 0f;
    public GameObject hitEffect;

    void Start()
    {

    }


    void Update()
    {
        if (PickUp.isPistol == true)
        {
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + 1f / fireRate;
                Shoot();
            }

        }
    }

    void Shoot()
    {

        RaycastHit hit;
        Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range);
        {
            if (PlayerManager.bulletAmount > 0)
            {
                effect.Play();
                source.PlayOneShot(clip);
                PlayerManager.bulletAmount -= 1;
                if (hit.collider.tag == "Enemy")
                {
                    GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(impact, 2f);
                    var enemy = hit.transform.GetComponent<Enemy>();
                    enemy.TakeDamage(damage);
                    Debug.Log("" + hit.collider);



                }
            }


        }
    }


}

