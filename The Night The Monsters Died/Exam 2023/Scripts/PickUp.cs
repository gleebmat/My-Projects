using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject camera;
    public float distance = 15f;
    GameObject currentWeapon;
    bool canPickUp;
    public static bool isWeapon = false;
    public static bool isGun = false;
    public static bool isShotGun = false;
    public static bool isPistol = false;



    public void PickingUp()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "Weapon" || hit.transform.tag == "Gun"||hit.transform.tag=="ShotGun"||hit.transform.tag=="Pistol")
            {
                if (hit.transform.tag == "Weapon")
                {
                    isWeapon = true;
                    isGun = false;
                    isShotGun = false;
                    isPistol = false;
                }
                else if (hit.transform.tag == "Gun")
                {
                    isGun = true;
                    isWeapon = false;
                    isShotGun = false;
                    isPistol = false;

                }
                else if(hit.transform.tag=="ShotGun")
                {
                    isGun = false;
                    isWeapon = false;
                    isShotGun = true;
                    isPistol = false;
                }
                else if(hit.transform.tag=="Pistol")
                {
                    isGun = false;
                    isWeapon = false;
                    isShotGun = false;
                    isPistol = true;
                }
                if (canPickUp) Drop();
                currentWeapon = hit.transform.gameObject;
                currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
                currentWeapon.GetComponent<Collider>().isTrigger = true;
                currentWeapon.transform.parent = transform;
                currentWeapon.transform.localPosition = Vector3.zero;
                currentWeapon.transform.localEulerAngles = new Vector3(5f, 0f, 0f);

                canPickUp = true;
            }
        }
    }

    void Drop()
    {


        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        currentWeapon.GetComponent<Collider>().isTrigger = false;

        canPickUp = false;
        currentWeapon = null;
    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PickingUp();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Drop();
        }
    }
}
